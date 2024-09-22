using UnityEditor;
using UnityEngine;
using SLua;
using System.IO;
using System.Collections.Generic;
using System.Text;
namespace EditorTool
{
    public class LuaEncrypt
    {
        static string resourcesRoot = Application.dataPath + "/Resources/";

        [MenuItem("Lua/Encrypt/Test")]
        public static void EncryptTest()
        {
            string sLuaRequire = @"
		    return function(path)
			    require(path)
		    end
		    ";
            #region testPB
            LuaSvrForEditor.Me.Dispose();
            LuaSvrForEditor.Me.init();
            LuaDLL.luaS_openextlibs(LuaSvrForEditor.Me.luaState.L);
            LuaSvr.doBind(LuaSvrForEditor.Me.luaState.L);
            LuaFunction oLuaFunction = LuaSvrForEditor.Me.DoString(sLuaRequire) as LuaFunction;
            oLuaFunction.call("Script/Net/NewProtoBuf/test");

            #endregion
            #region test
            //TextAsset asset = (TextAsset)Resources.Load("Script2/Refactory/Game/GameLauncher");
            //byte[] b = asset.bytes;


            //if (0 == LuaDLL.ecode_IsDesCode(b, (uint)b.Length))//已经加密
            //    return;

            //uint lenth = LuaDLL.ecode_GetBufferSize((uint)b.Length);

            //byte[] c = new byte[lenth];

            //LuaDLL.ecode_buffer(b, (uint)b.Length, c);

            //TextAsset asset2 = (TextAsset)Resources.Load("Script2/Refactory/Game/GameLauncher222",typeof(byte));
            //byte[] b2 = asset2.bytes;

            //FileStream fsA = new FileStream(resourcesRoot + "Script2/Refactory/Game/GameLauncher222.bytes", FileMode.Open, FileAccess.Read);
            //byte[] buffur = new byte[fsA.Length];

            //fsA.Read(buffur, 0, buffur.Length);
            //fsA.Close();

            //FileStream fs = new FileStream(resourcesRoot + "Script/Refactory/Game/GameLauncher222.bytes", FileMode.OpenOrCreate);
            ////存储时时二进制,所以这里需要把我们的字符串转成二进制
            ////string gg = Encoding.UTF8.GetString(c);
            ////byte[] nb = System.Text.Encoding.UTF8.GetBytes(gg);
            //fs.Write(c, 0, c.Length);
            ////每次读取文件后都要记得关闭文件
            //fs.Close();

            ////保存c

            ////////////////////////////////
            ////////////////////////////////
            // LuaSvrForEditor.Me.Dispose();
            // LuaSvrForEditor.Me.init();

            ////读取你的保存文件
            // int a =  LuaDLL.luaL_loadbuffer(LuaSvrForEditor.Me.luaState.L, b2, b2.Length, "AAAAA");
            ////int ccc = 3;
            #endregion
        }

        //[MenuItem("Lua/Encrypt/Tobyte")]
        public static void EncryptTobyte()
        {
            string src = Application.dataPath + "/Resources/Script/";
            string dest = Application.dataPath + "/Resources/Script2/";

            if (Directory.Exists(dest))
            {

                /* DirectoryInfo[] dirs = dirInfo.GetDirectories();
                 for (int i = 0, max = dirs.Length; i < max; ++i)
                 {
                     if (false == dirs[i].FullName.Contains("PBBytes"))
                         Directory.Delete(dirs[i].FullName, true);
                 }*/
                DirectoryInfo dirInfo = new DirectoryInfo(dest);
                FileInfo[] files = dirInfo.GetFiles("*.bytes", SearchOption.AllDirectories);
                for (int i = 0, max = files.Length; i < max; ++i)
                {
                    File.Delete(files[i].FullName);
                }
            }




            DirectoryInfo sourceInfo = new DirectoryInfo(src);
            CopyFilesToBytes(sourceInfo, Directory.CreateDirectory(dest));

            AssetDatabase.Refresh();
        }

        // [MenuItem("Lua/Encrypt/Do")]
        public static void EncryptDo()
        {
            List<string> dirList = GetEncryptDirectoryList();
            for (int i = 0; i < dirList.Count; i++)
            {
                DirectoryInfo directory = new DirectoryInfo(resourcesRoot + dirList[i]);
                GetAllFiles(directory);
            }

            for (int i = 0; i < FileList.Count; i++)
            {
                EncryptFile(FileList[i]);
            }

            AssetDatabase.Refresh();
            FileList.Clear();
        }


        [MenuItem("Lua/Encrypt/T&&D")]
        public static void EncryptTD()
        {
            EncryptTobyte();
            EncryptDo();
        }

        public static List<string> GetEncryptDirectoryList()
        {
            List<string> dirList = new List<string>();
            //dirList.Add("Script/Config");
            //dirList.Add("Script/Config_Adventure_ChengJiu_MaoXian");
            dirList.Add("Script2");
            return dirList;
        }

        public static void EncryptFile(string path)
        {
            Debug.Log(path);
            TextAsset asset = (TextAsset)Resources.Load(path);
            byte[] b = asset.bytes;
            if (b.Length < 1)
                return;
            if (0 == LuaDLL.ecode_IsDesCode(b, (uint)b.Length))//已经加密
                return;

            uint lenth = LuaDLL.ecode_GetBufferSize((uint)b.Length);

            byte[] c = new byte[lenth];

            LuaDLL.ecode_buffer(b, (uint)b.Length, c);

            //保存c
            FileStream fs = new FileStream(resourcesRoot + path + ".bytes", FileMode.OpenOrCreate);
            fs.Write(c, 0, c.Length);
            fs.Close();

            Debug.Log("<color=#9400D3>" + "Encrypt Success!!" + "</color>");
        }

        static public void CopyFilesToBytes(DirectoryInfo sourceInfo, DirectoryInfo tarInfo)
        {
            FileInfo[] files = sourceInfo.GetFiles("*.txt", SearchOption.TopDirectoryOnly);
            for (int i = 0, max = files.Length; i < max; ++i)
            {
                string oldFile = (sourceInfo.FullName + '/' + files[i].Name);
                string newFile = (tarInfo.FullName + '/' + files[i].Name).Replace(".txt", ".bytes");
                FileStream fsA = new FileStream(oldFile, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[fsA.Length];
                fsA.Read(buffer, 0, buffer.Length);
                fsA.Close();
                if (buffer.Length > 2)
                {
                    if (buffer[0] == 0xef
                        && buffer[1] == 0xbb
                        && buffer[2] == 0xbf)
                    {
                        string f = new UTF8Encoding(false).GetString(buffer, 3, buffer.Length - 3);
                        byte[] b = System.Text.Encoding.UTF8.GetBytes(f);

                        FileStream fs = new FileStream(newFile, FileMode.OpenOrCreate);
                        fs.Write(b, 0, b.Length);
                        fs.Close();
                    }
                    else
                        files[i].CopyTo(newFile, true);
                }
                else
                    files[i].CopyTo(newFile, true);
            }
            DirectoryInfo[] dirs = sourceInfo.GetDirectories();
            for (int i = 0, max = dirs.Length; i < max; ++i)
            {
                DirectoryInfo dirInfo = Directory.CreateDirectory(tarInfo.FullName + '/' + dirs[i].Name);
                CopyFilesToBytes(dirs[i], dirInfo);
            }
        }

        static List<string> FileList = new List<string>();
        public static List<string> GetAllFiles(DirectoryInfo dir)
        {
            FileInfo[] allFile = dir.GetFiles();
            foreach (FileInfo fi in allFile)
            {
                if (fi.FullName.EndsWith(".bytes"))
                {
                    FileList.Add(fi.FullName.Replace("\\", "/").Replace(Application.dataPath + "/Resources/", "").Replace(".bytes", ""));
                }
            }
            DirectoryInfo[] allDir = dir.GetDirectories();
            foreach (DirectoryInfo d in allDir)
            {
                GetAllFiles(d);
            }
            return FileList;
        }
    }
}
