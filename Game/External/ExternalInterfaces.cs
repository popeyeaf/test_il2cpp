using UnityEngine;
using System.Runtime.InteropServices;

namespace RO
{
    [SLua.CustomLuaClassAttribute]
    public static class ExternalInterfaces
    {
        public static object androidSavePic;

        #region Save Photo

        public static void RO_SavePhoto(string readAddr)
        {
            // ไม่ต้องทำอะไรสำหรับ Android
            Debug.Log("RO_SavePhoto is not implemented on Android.");
        }

        private static AndroidJavaClass androidSavePicClass;
        private static AndroidJavaObject currentActivity;

        private static void InitializeAndroidSavePic()
        {
            if (androidSavePic == null)
            {
                androidSavePic = new AndroidJavaClass("com.xindong.RODevelop.UnitySavePicActivity");
            }
            if (androidSavePicClass == null)
            {
                androidSavePicClass = (AndroidJavaClass)androidSavePic;
            }

            if (currentActivity == null)
            {
                AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                currentActivity = jc.GetStatic<AndroidJavaObject>("currentActivity");
            }
        }

        public static bool AndroidSavePic(string srcPath)
        {
            InitializeAndroidSavePic();

            if (androidSavePic != null)
            {
                return ((AndroidJavaClass)androidSavePic).CallStatic<bool>("savePictureFileToDCIM", srcPath);
            }
            return false;
        }

        public static bool SavePicToDCIM(string srcPath)
        {
#if UNITY_EDITOR
            Debug.Log("EDITOR MODE srcPath:" + srcPath);
            return true;
#elif UNITY_ANDROID
            return AndroidSavePic(srcPath);
#else
            return false;
#endif
        }

        #endregion

        #region Speech Recognizer

        private static AndroidJavaObject jc;
        private static AndroidJavaObject jo;

        private static void InitializeAndroidRecognizer()
        {
            if (jc == null)
            {
                jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            }
            if (jo == null)
            {
                jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
            }
        }

        public static void InitRecognizer(string name)
        {
            RO.LoggerUnused.Log("InitRecognizer");
#if UNITY_EDITOR
            // Editor mode
#elif UNITY_ANDROID
            InitializeAndroidRecognizer();
            jo.Call("InitSpeechRecognizer", FileDirectoryHandler.GetAbsolutePath(name));
#endif
        }

        public static void StartRecognizer()
        {
            RO.LoggerUnused.Log("StartRecognizer");
#if UNITY_EDITOR
            // Editor mode
#elif UNITY_ANDROID
            InitializeAndroidRecognizer();
            jo.Call("startRecognizerHandler");
#endif
        }

        public static void StopRecognizer()
        {
            RO.LoggerUnused.Log("StopRecognizer");
#if UNITY_EDITOR
            // Editor mode
#elif UNITY_ANDROID
            InitializeAndroidRecognizer();
            jo.Call("stopRecognizerHandler");
#endif
        }

        #endregion

        #region Battery Information

        public static int getDeviceBatteryPct()
        {
            // สำหรับ Android
            return GetSysBatteryPct();
        }

        public static bool getDeviceBatteryCharging()
        {
            // สำหรับ Android
            return GetSysBatteryIsCharge();
        }

        public static int GetSysBatteryPct()
        {
#if UNITY_EDITOR
            return 100; // ค่าเริ่มต้นใน Editor
#elif UNITY_ANDROID
            if (androidSavePic == null)
            {
                androidSavePic = new AndroidJavaClass("com.xindong.RODevelop.UnitySavePicActivity");
            }
            return ((AndroidJavaClass)androidSavePic).CallStatic<int>("GetSysBatteryPct");
#else
            return 100;
#endif
        }

        public static bool GetSysBatteryIsCharge()
        {
#if UNITY_EDITOR
            return false; // ค่าเริ่มต้นใน Editor
#elif UNITY_ANDROID
            if (androidSavePic == null)
            {
                androidSavePic = new AndroidJavaClass("com.xindong.RODevelop.UnitySavePicActivity");
            }
            return ((AndroidJavaClass)androidSavePic).CallStatic<bool>("GetSysBatteryIsCharge");
#else
            return false;
#endif
        }

        #endregion

        #region Package Name

        public static string GetPackageName()
        {
#if UNITY_ANDROID
            if (androidSavePic == null)
            {
                androidSavePic = new AndroidJavaClass("com.xindong.RODevelop.UnitySavePicActivity");
            }
            return ((AndroidJavaClass)androidSavePic).CallStatic<string>("GetPackageName");
#else
            return "";
#endif
        }

        #endregion

        #region Screen Brightness

        public static void setScreenBrightness(float value)
        {
            SetScreenBrightness(value);
        }

        public static void SetScreenBrightness(float value)
        {
#if UNITY_EDITOR
            // Editor mode
#elif UNITY_ANDROID
            if (jc == null)
            {
                jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            }
            if (jo == null)
            {
                jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
            }
            jo.Call("SetCurrentBrightness", value);
#endif
        }

        public static float getSysScreenBrightness()
        {
            return GetSysScreenBrightness();
        }

        public static float GetSysScreenBrightness()
        {
#if UNITY_EDITOR
            return 0.5f; // ค่าเริ่มต้นใน Editor
#elif UNITY_ANDROID
            if (jc == null)
            {
                jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            }
            if (jo == null)
            {
                jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
            }
            return jo.Call<float>("GetSysScreenBrightness");
#else
            return 0.5f;
#endif
        }

        #endregion

        #region Open Settings

        public static void OpenWifiSet()
        {
#if UNITY_EDITOR
            // Editor mode
#elif UNITY_ANDROID
            if (currentActivity == null)
            {
                AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                currentActivity = jc.GetStatic<AndroidJavaObject>("currentActivity");
            }
            currentActivity.Call("OpenWifiSetting");
#endif
        }

        public static void OpenAppSet()
        {
#if UNITY_EDITOR
            // Editor mode
#elif UNITY_ANDROID
            if (currentActivity == null)
            {
                AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                currentActivity = jc.GetStatic<AndroidJavaObject>("currentActivity");
            }
            currentActivity.Call("OpenAppSetting");
#endif
        }

        public static float GetSysVer()
        {
#if UNITY_EDITOR
            return 0.0f; // ค่าเริ่มต้นใน Editor
#elif UNITY_ANDROID
            string osVersion = SystemInfo.operatingSystem.Replace("Android ", "").Split(' ')[0];
            if (float.TryParse(osVersion, out float version))
            {
                return version;
            }
            else
            {
                return 0.0f;
            }
#else
            return 0.0f;
#endif
        }

        #endregion

        #region SDK Debug Message

        private static void sdk_debug_msg(string msg)
        {
            // Implement SDK debug message if needed
            Debug.Log("SDK Debug Message: " + msg);
        }

        #endregion

        #region Rate and Review App

        public static void RateReviewApp(string appid)
        {
            // ไม่ทำอะไรบน Android
            Debug.Log("RateReviewApp is not implemented on Android.");
        }

        public static void storeReviewCall(string appid)
        {
            // ไม่ทำอะไรบน Android
            Debug.Log("storeReviewCall is not implemented on Android.");
        }

        #endregion

        #region Get iOS Version

        public static string GetIOSVersion()
        {
            // สำหรับ Android ให้คืนค่าเริ่มต้นหรือว่างเปล่า
            return "10.0.0"; // หรือค่าเริ่มต้นอื่น ๆ
        }

        #endregion

        #region User Notification Enable

        public static bool isUserNotificationEnable()
        {
            // ค่าเริ่มต้นสำหรับ Android
            return false;
        }

        public static void ShowHintOpenPushView(string title, string message, string cancelButtonTitle, string otherButtonTitles)
        {
            // ไม่ทำอะไรบน Android
            Debug.Log("ShowHintOpenPushView is not implemented on Android.");
        }

        #endregion
    }
}
    // namespace RO
