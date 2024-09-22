using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;
using RO;
using System;
using EditorTool;
using Ghost.Utils;
using System.Threading;

public static class AutoBuildAssetBundles
{
	const string buildBundlePath = "Assets/";

	[MenuItem("AssetBundle/Pure packaging (without scanning resources)")]
	public static void BuildAssetBundles ()
	{
		System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
		stopWatch.Start();
		
		// Choose the output path according to the build target.
		string outputPath = Path.Combine (buildBundlePath + BundleLoaderStrategy.EditorRoot, ApplicationHelper.platformFolder);
        /*if(Directory.Exists(outputPath))
        {
            Directory.Delete(outputPath, true);
            Thread.Sleep(50);
            Directory.CreateDirectory(outputPath);
        }
		else */if (!Directory.Exists (outputPath))
			Directory.CreateDirectory (outputPath);
#if ARCHIVE_AB
		BuildPipeline.BuildAssetBundles (outputPath, BuildAssetBundleOptions.ChunkBasedCompression, EditorUserBuildSettings.activeBuildTarget);
#else
		BuildPipeline.BuildAssetBundles (outputPath, BuildAssetBundleOptions.UncompressedAssetBundle, EditorUserBuildSettings.activeBuildTarget);
#endif
		RemoveAllUnusedBundles ();
		PrintCount ();
		// encrypt some bundles
		// EncryptFiles ();
		// AppendVerifyToFileEnd
        // AppendVerify();
		
		stopWatch.Stop();
		Debug.Log(string.Format("纯打包耗时{0}秒", stopWatch.Elapsed.TotalMilliseconds / 1000));
	}

	public static void RemoveAllUnusedBundles ()
	{
		string[] unusedBundles = AssetDatabase.GetUnusedAssetBundleNames ();
		string fileName = null;
		string dir = Path.Combine (Application.dataPath + "/" + BundleLoaderStrategy.EditorRoot, ApplicationHelper.platformFolder);
		string directory = null;
		SDictionary<string,string> removedFileDir = new SDictionary<string, string> ();
		for (int i = 0; i < unusedBundles.Length; i++) {
			fileName = Path.Combine (dir, unusedBundles [i]);
			//				Debug.Log (fileName);
			directory = Path.GetDirectoryName (fileName);
			removedFileDir [directory] = directory;
			DeleteFile (fileName);
			DeleteFile (fileName + ".meta");
			DeleteFile (fileName + ".manifest");
			DeleteFile (fileName + ".manifest.meta");
		}
		foreach (KeyValuePair<string,string> kvp in removedFileDir) {
			DeleteEmptyDirectory (kvp.Value);
		}
		removedFileDir.Clear ();
		removedFileDir = null;
		AssetDatabase.RemoveUnusedAssetBundleNames ();
	}

	static void EncryptFiles ()
	{
		AssetManageConfig config = AssetManageConfig.CreateByFile (EditorTool.AssetManagerConfigEditor.filePath);
		if (config != null) {
			foreach (AssetManageInfo info in config.infos) {
				RecurselyCheckConfig (info);
			}
		}
	}

	static void RecurselyCheckConfig (AssetManageInfo info)
	{
		if (info != null) {
			if (info.encryption != AssetEncryptMode.None) {
				Action<string> encryptFunc = null;
				switch (info.encryption) {
				case AssetEncryptMode.Encryption1:
					encryptFunc = EncryptEditor.AESEncrypt;
					break;
				}
				string bundleRoot = Path.Combine (buildBundlePath + BundleLoaderStrategy.EditorRoot, ApplicationHelper.platformFolder);
				string bundlesPath = Path.Combine (bundleRoot, info.path.ToLower ());
				if (encryptFunc != null) {
					// try filename
					encryptFunc (bundlesPath + ".unity3d");
					if (Directory.Exists (bundlesPath)) {
						foreach (string f in Directory.GetFiles(bundlesPath, "*", SearchOption.AllDirectories)) {
							if (Path.GetExtension (f) == ".unity3d") {
								encryptFunc (f);
							}
						}
					}
				}
			}
		}
		if (info.subs != null) {
			foreach (AssetManageInfo i in info.subs) {
				RecurselyCheckConfig (i);
			}
		}
	}

	public static void AppendVerify()
	{

	}

	public static void DeleteFile (string bundleName)
	{
		if (File.Exists (bundleName)) {
			File.Delete (bundleName);
		}
	}
		
	public static void DeleteEmptyDirectory (string directory)
	{
		if (Directory.Exists (directory)) {
			string[] files = Directory.GetFiles (directory, "*", SearchOption.AllDirectories);
			if (files.Length == 0) {
				Directory.Delete (directory);
			}
		}
	}

	[MenuItem("AssetBundle/Number of output bundles")]
	static void PrintCount ()
	{
		string outputPath = Path.Combine (Application.dataPath + "/" + BundleLoaderStrategy.EditorRoot, ApplicationHelper.platformFolder);
		outputPath = Path.Combine (outputPath, ApplicationHelper.platformFolder);
		Debug.Log (outputPath);
		AssetBundle ab = AssetBundle.LoadFromFile (outputPath);
		AssetBundleManifest am = ab.LoadAsset<AssetBundleManifest> ("AssetBundleManifest");
		string[] all = am.GetAllAssetBundles ();
		Debug.Log (string.Format ("一共有{0}个assetbundle包", all.Length));
		string[] arts = Array.FindAll (all, (p) => {
			return p.StartsWith ("art/");
		});
		Debug.Log (string.Format ("一共有{0}个art assetbundle包", arts.Length));
		ab.Unload (true);

	}
}
