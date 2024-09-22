using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;
using Ghost.Extensions;
public class TestAssetBundlName : MonoBehaviour {
	private static void DoGetDependenciesEach (SelectionMode mode)
	{
		var selectedAssets = Selection.GetFiltered (typeof(Object), mode);
		foreach (Object obj in selectedAssets) 
		{
			Debug.Log (string.Format("{0}\ndepends on:", AssetDatabase.GetAssetPath(obj)));	
			string[] depends = AssetDatabase.GetDependencies(new string[]{AssetDatabase.GetAssetPath(obj)});
			foreach(var Name in depends)
			{
				var Temp = AssetImporter.GetAtPath(Name);
				Temp.assetBundleName = "Test_Asset";
			}

			//DebugLogDependencies(depends);
		}
	}
	[MenuItem("Assets/GetInfo/SetAssetBundlName")]
	static void GetDependenciesEach () { DoGetDependenciesEach (SelectionMode.Assets); }
}
