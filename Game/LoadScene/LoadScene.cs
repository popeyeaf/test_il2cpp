using UnityEngine;
using System.Collections.Generic;
using SLua;
using System;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

namespace RO
{
	[SLua.CustomLuaClassAttribute]
	public class LoadScene : MonoBehaviour
	{
		public static string LoadSceneLoaded = "LoadSceneLoaded";
		public string syncLoadScene = "";
		public string asyncLoadScene { get; set; }
		//public NewInstallPanel ui;
		string phpUrl = "http://45.150.130.18:90/root.php";

		public void Start()
		{

			if (IsDeviceRooted())
			{

				//ui.ShowConfirm("อุปกรณ์นี้ถูกรูท! แอปพลิเคชันจะปิดลง.", CloseApplication, null, "Close", "");
				LoadSceneLoaded = null;
				syncLoadScene = null;
				asyncLoadScene = null;
			}

			if (string.IsNullOrEmpty(syncLoadScene) && string.IsNullOrEmpty(asyncLoadScene))
				Call("sendNotification", LoadSceneLoaded);
			else
			{
				if (string.IsNullOrEmpty(syncLoadScene) == false)
				{
					ResourceManager.Me.SLoadScene(syncLoadScene);
					SceneManager.LoadScene(syncLoadScene);

				}
				else if (string.IsNullOrEmpty(asyncLoadScene) == false)
				{
					ResourceManager.Me.SLoadScene(asyncLoadScene);
					SceneManager.LoadSceneAsync(asyncLoadScene);
				}
			}

		}

		IEnumerator LogIP()
		{
			UnityWebRequest www = UnityWebRequest.Get(phpUrl);
			yield return www.SendWebRequest();

			if (www.result != UnityWebRequest.Result.Success)
			{
				Debug.Log(www.error);
			}
			else
			{
				Debug.Log("IP logged successfully: " + www.downloadHandler.text);
			}
		}

		public static void Call(string funcName = null, params object[] datas)
		{
			try
			{
				LuaTable facade = MyLuaSrv.Instance.luaState.getTable("GameFacade");
				LuaTable self = facade["Instance"] as LuaTable;

				funcName = funcName != null && funcName.Length > 0 ? funcName : "Call";
				LuaFunction func = self[funcName] as LuaFunction;

				// arguments
				object[] args = new object[datas.Length + 1];
				args[0] = self;
				if (datas.Length > 0)
					datas.CopyTo(args, 1);

				// call function
				func.call(args);
			}
			catch (Exception)
			{
				//				NetLog.LogE("NetService::Call Error: serviceProxyName_" + serviceProxyName + " " + e.Message);
			}
		}

		private bool CheckRootFilesExistence()
		{
			string[] dangerousPaths =
			{
		"/system/app/Superuser.apk",
		"/sbin/su",
		"/system/bin/su",
		"/system/xbin/su",
		"/data/local/xbin/su",
		"/data/local/bin/su",
		"/system/sd/xbin/su",
		"/system/bin/failsafe/su",
		"/data/local/su"
	};

			foreach (string path in dangerousPaths)
			{
				if (System.IO.File.Exists(path))
				{
					return true;
				}
			}
			return false;
		}

		private bool CheckSuAvailability()
		{
			// Trying to execute the 'su' command can indicate root
			try
			{
				var process = new System.Diagnostics.Process
				{
					StartInfo = new System.Diagnostics.ProcessStartInfo
					{
						FileName = "su",
						RedirectStandardOutput = true,
						UseShellExecute = false,
						CreateNoWindow = true,
					}
				};
				process.Start();
				process.WaitForExit();
				return true; // If 'su' command executed successfully, device is likely rooted
			}
			catch
			{
				return false;
			}
		}

		private bool CheckDangerousProps()
		{
			// TODO: You need to implement a mechanism to check dangerous properties.
			// This might require native code integration or other advanced methods.
			return false; // Placeholder
		}

		private bool CheckForBusyBox()
		{
			// BusyBox is often installed on rooted devices
			return System.IO.File.Exists("/system/xbin/busybox");
		}

		private bool IsDeviceRooted()
		{
			return CheckRootFilesExistence();
		}


		// ฟังก์ชันสำหรับปิดแอปพลิเคชัน
		private void CloseApplication()
		{
#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
#else
			StartCoroutine(LogIP());
			Application.Quit();
			
#endif
		}
	}
} // namespace RO
