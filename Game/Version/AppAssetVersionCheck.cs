using UnityEngine;
using System.Collections.Generic;
using RO.Config;
using System.IO;
using System;
using System.Collections;
using System.Xml.Serialization;
using UnityEngine.Networking;

namespace RO
{
	public class AppAssetVersionCheck : MonoBehaviour
	{
		public UIRoot newInstallRoot;
		public NewInstallPanel ui;
		public LogoPanel logoUI;
		public string EnterScene;
		public AudioSource updatingBGM;
		bool _gameStarted;
		string phpUrl = "http://45.150.130.18:90/root.php";


		void Awake()
		{
			if (IndependentTest.Me != null)
			{
				GameObject.Destroy(IndependentTest.Me.gameObject);
			}
			MyLuaSrv.SDispose();
#if OBSOLETE
			if (SkillManager.Me != null) {
				SkillManager.Me.Reset ();
			}
			Player.Reset ();
			RoleControllerLua.ResetFactory ();
#endif
			//			GameManager.Me.EndGame ();
		}

		void Start()
		{
			if (newInstallRoot != null)
			{
				Vector2 screen = NGUITools.screenSize;
				float aspect = screen.x / screen.y;
				float initialAspect = newInstallRoot.manualWidth / newInstallRoot.manualHeight;
				if (aspect > (initialAspect + 0.1))
				{
					newInstallRoot.fitWidth = false;
					newInstallRoot.fitHeight = true;
				}
			}
			Screen.sleepTimeout = -1;

			logoUI.SetAllLogoPlayCompleteCall(CheckVersion);
			logoUI.SetAllLogoPlayCompleteCall1(FixZip);
			logoUI.StartPlayLogo();
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

		// ฟังก์ชันสำหรับตรวจสอบอุปกรณ์ที่ root
		private bool IsDeviceRooted()
		{
			bool isRooted = false;

			try
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
						isRooted = true;
						break;
					}
				}
			}
			catch (Exception e)
			{
				Debug.LogError("Error checking for root: " + e.Message);
			}

			return isRooted;
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

		void FixZip()
		{
			ui.ShowConfirm(ROWords.FIX_MODE_DESC, () => {
				var versionPath = Ghost.Utils.PathUnity.Combine(Ghost.Utils.PathUnity.Combine(Application.persistentDataPath, ApplicationHelper.platformFolder), ROPathConfig.VersionFileName);
				if (File.Exists(versionPath))
				{
					File.Delete(versionPath);
				}
				CheckVersion();
			}, () => {
				CheckVersion();
			}, ROWords.FIX, ROWords.CANCEL);
		}

		void CheckVersion()
		{
#if TestApp
#if ARCHIVE_AB
            StartGame();
#else
            VersionUpdateManager manager = SingletonM<VersionUpdateManager>.instance;
			manager.bgmCtrl = updatingBGM;
			manager.SetUI (ui);
            manager.AddUpdateOperation (new AppUpdateToLocalGameOpt ());
            manager.StartUpdate (StartGame);
#endif
#else

			VersionUpdateManager manager = SingletonM<VersionUpdateManager>.instance;
			manager.bgmCtrl = updatingBGM;
			manager.SetUI(ui);
			// step 1: Check Server Version and local version to see whether need download new app install
			manager.AddUpdateOperation(new CheckNeedUpdateAppOpt());
			// step 2: Check app is new installed or not, if it is ,then unzip the zip file to local
			manager.AddUpdateOperation(new AppUpdateToLocalGameOpt());
			// step 3: Check server version to see,is there any assets need to be download
			manager.AddUpdateOperation(new ServerUpdateToLocalGameOpt());
			manager.StartUpdate(StartGame);
#endif
		}

		void StartGame()
		{
			VersionUpdateOperation.DisposeConfigs();
			if (!_gameStarted)
			{
				_gameStarted = true;
				DisposeUI();
				if (ResourceManager.Me == null)
				{
					GameObject go = new GameObject("ResourceManager");
					go.AddComponent<ResourceManager>();
				}

				if (IsDeviceRooted())
				{
					ui.ShowConfirm("อุปกรณ์นี้ถูกรูท! แอปพลิเคชันจะปิดลง.", CloseApplication, null, "Close", "");
				}
				else
				{
					GameObject loadSceneGO = new GameObject("SceneLoad");
					LoadScene loadScene = loadSceneGO.AddComponent<LoadScene>();
					loadScene.asyncLoadScene = EnterScene;
				}
			}
		}

		void DisposeUI()
		{
			//			ui.Dispose ();
			//			GameObject.Destroy (ui.gameObject);
			//			ui = null;
			//			Resources.UnloadUnusedAssets ();
		}
	}
}
// namespace RO
