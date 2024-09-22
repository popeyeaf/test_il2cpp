using UnityEngine;
using System.Collections.Generic;
using Ghost.Utils;
using System.Xml.Serialization;
using System.IO;
using System.Text;

#if UNITY_EDITOR || UNITY_EDITOR_OSX
using System.Linq;
#endif

namespace RO
{
	[SLua.CustomLuaClassAttribute]
	public class ResourceID
	{
		public const string ResFolder = "Assets/Resources/";
		public const string LuaFolder = "Script/";
		static PathId2Name _pathData;

		public string IDStr{ get; private set; }

		public List<object> parts;

		public static PathId2Name pathData {
			get {
				return _pathData;
			}
		}

		private ResourceID ()
		{
		}

		public static bool CheckFileIsRecorded (string file)
		{
			if (string.IsNullOrEmpty (file) || pathData == null) {
				return false;
			}
			return pathData.fileToFull.ContainsKey (file);
		}

		public static void ReMap (string config,bool force = false)
		{
			XmlSerializer serializer = 
				new XmlSerializer (typeof(PathId2Name));
			#if RESOURCE_LOAD && (UNITY_EDITOR_OSX || UNITY_EDITOR)
			MakeAndReadFromResource(serializer);
			#else
			if (force || (_pathData == null && config != null)) {
				StringReader sr = new StringReader (config);
				_pathData = null;
				System.GC.Collect();
				_pathData = (PathId2Name)serializer.Deserialize (sr);
				_pathData.MapFullPath ();
				sr.Close ();
			}
			#endif
		}

		public static void MakeAndReadFromResource (XmlSerializer serializer)
		{
			#if UNITY_EDITOR_OSX || UNITY_EDITOR
			if (serializer == null)
				serializer = new XmlSerializer (typeof(PathId2Name));
			_pathData = new PathId2Name ();
			string path = ResStrategy.holderAssetPath + "pathIdMap";
			if (!Directory.Exists (ResStrategy.holderAssetPath)) {
				Directory.CreateDirectory (ResStrategy.holderAssetPath);
			}
			//使用 holder 建立名为 dataHolder.asset 的资源
			TextWriter writer = new StreamWriter (path + ".xml");
			string[] files = Directory.GetFiles (ResourceID.ResFolder, "*.*", SearchOption.AllDirectories).Where (
				s => (!s.EndsWith (".meta") && s.Contains("Resources/Script"))
			).ToArray ();
			for (int i=0; i<files.Length; i++) {
				_pathData.MakeScriptFullPath(files[i]);
			}
			serializer.Serialize (writer, _pathData);
			_pathData.MapFullPath();
			writer.Close ();
			#endif
		}
	}
} // namespace RO
