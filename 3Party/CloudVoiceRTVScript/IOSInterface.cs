using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

namespace CloudVoiceVideoTroops
{
    public class PlatformInterface
    {
        #region 实时语音部份 (Real-time Voice Section)

        // Initialization
        public static void ChatSDKInitWithEnvironment(int environment, string appId, string observer)
        {
#if UNITY_IOS && !UNITY_EDITOR
            ChatSDKInitWithEnvironment_iOS(environment, appId, observer);
#elif UNITY_ANDROID && !UNITY_EDITOR
            ChatSDKInitWithEnvironment_Android(environment, appId, observer);
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void ChatSDKInitWithEnvironment_iOS(int environment, string appId, string observer);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void ChatSDKInitWithEnvironment_Android(int environment, string appId, string observer)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.ChatSDK");
                sdkClass.CallStatic("init", environment, appId, observer);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error initializing Chat SDK on Android: " + e.Message);
            }
        }
#endif

        // Login
        public static void ChatSDKLogin(string userId, string roomId)
        {
#if UNITY_IOS && !UNITY_EDITOR
            ChatSDKLogin_iOS(userId, roomId);
#elif UNITY_ANDROID && !UNITY_EDITOR
            ChatSDKLogin_Android(userId, roomId);
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void ChatSDKLogin_iOS(string userId, string roomId);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void ChatSDKLogin_Android(string userId, string roomId)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.ChatSDK");
                sdkClass.CallStatic("login", userId, roomId);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error logging into Chat SDK on Android: " + e.Message);
            }
        }
#endif

        // Logout
        public static void Logout()
        {
#if UNITY_IOS && !UNITY_EDITOR
            Logout_iOS();
#elif UNITY_ANDROID && !UNITY_EDITOR
            Logout_Android();
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void Logout_iOS();
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void Logout_Android()
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.ChatSDK");
                sdkClass.CallStatic("logout");
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error logging out of Chat SDK on Android: " + e.Message);
            }
        }
#endif

        // Release Resources
        public static void ReleaseResource()
        {
#if UNITY_IOS && !UNITY_EDITOR
            ReleaseResource_iOS();
#elif UNITY_ANDROID && !UNITY_EDITOR
            ReleaseResource_Android();
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void ReleaseResource_iOS();
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void ReleaseResource_Android()
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.ChatSDK");
                sdkClass.CallStatic("releaseResource");
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error releasing resources on Android: " + e.Message);
            }
        }
#endif

        // Microphone Control
        public static void ChatMic(bool onOff, int timeLimit)
        {
#if UNITY_IOS && !UNITY_EDITOR
            ChatMic_iOS(onOff, timeLimit);
#elif UNITY_ANDROID && !UNITY_EDITOR
            ChatMic_Android(onOff, timeLimit);
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void ChatMic_iOS(bool onOff, int timeLimit);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void ChatMic_Android(bool onOff, int timeLimit)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.ChatSDK");
                sdkClass.CallStatic("chatMic", onOff, timeLimit);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error controlling microphone on Android: " + e.Message);
            }
        }
#endif

        // Pause/Resume Real Audio
        public static void SetPausePlayRealAudio(bool isPause)
        {
#if UNITY_IOS && !UNITY_EDITOR
            SetPausePlayRealAudio_iOS(isPause);
#elif UNITY_ANDROID && !UNITY_EDITOR
            SetPausePlayRealAudio_Android(isPause);
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void SetPausePlayRealAudio_iOS(bool isPause);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void SetPausePlayRealAudio_Android(bool isPause)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.ChatSDK");
                sdkClass.CallStatic("setPausePlayRealAudio", isPause);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error setting pause play real audio on Android: " + e.Message);
            }
        }
#endif

        // Set Log Level
        public static void SetLogLevel(int logLevel)
        {
#if UNITY_IOS && !UNITY_EDITOR
            SetLogLevel_iOS(logLevel);
#elif UNITY_ANDROID && !UNITY_EDITOR
            SetLogLevel_Android(logLevel);
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void SetLogLevel_iOS(int logLevel);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void SetLogLevel_Android(int logLevel)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.ChatSDK");
                sdkClass.CallStatic("setLogLevel", logLevel);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error setting log level on Android: " + e.Message);
            }
        }
#endif

        // Get Current Mic State
        public static bool GetCurrentMicState()
        {
#if UNITY_IOS && !UNITY_EDITOR
            return GetCurrentMicState_iOS();
#elif UNITY_ANDROID && !UNITY_EDITOR
            return GetCurrentMicState_Android();
#else
            return false;
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern bool GetCurrentMicState_iOS();
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static bool GetCurrentMicState_Android()
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.ChatSDK");
                return sdkClass.CallStatic<bool>("getCurrentMicState");
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error getting mic state on Android: " + e.Message);
                return false;
            }
        }
#endif

        // Set Metering Enabled
        public static void SetMeteringEnabled(bool enabled)
        {
#if UNITY_IOS && !UNITY_EDITOR
            SetMeteringEnabled_iOS(enabled);
#elif UNITY_ANDROID && !UNITY_EDITOR
            SetMeteringEnabled_Android(enabled);
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void SetMeteringEnabled_iOS(bool enabled);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void SetMeteringEnabled_Android(bool enabled)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.ChatSDK");
                sdkClass.CallStatic("setMeteringEnabled", enabled);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error setting metering enabled on Android: " + e.Message);
            }
        }
#endif

        #endregion

        #region 发送消息接口部份 (Message Sending Section)

        // Send Message
        public static void SendMessageWithType(int type, string text, string voiceUrl, int voiceDuration, string expand)
        {
#if UNITY_IOS && !UNITY_EDITOR
            SendMessageWithType_iOS(type, text, voiceUrl, voiceDuration, expand);
#elif UNITY_ANDROID && !UNITY_EDITOR
            SendMessageWithType_Android(type, text, voiceUrl, voiceDuration, expand);
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void SendMessageWithType_iOS(int type, string text, string voiceUrl, int voiceDuration, string expand);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void SendMessageWithType_Android(int type, string text, string voiceUrl, int voiceDuration, string expand)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.ChatSDK");
                sdkClass.CallStatic("sendMessage", type, text, voiceUrl, voiceDuration, expand);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error sending message on Android: " + e.Message);
            }
        }
#endif

        #endregion

        #region Speech Recognition Section

        // Speech Discern By URL
        public static void SpeechDiscernByUrl(int recognizeLanguage, int outputTextLanguageType, string urlFilePath, string expand)
        {
#if UNITY_IOS && !UNITY_EDITOR
            SpeechDiscernByUrl_iOS(recognizeLanguage, outputTextLanguageType, urlFilePath, expand);
#elif UNITY_ANDROID && !UNITY_EDITOR
            SpeechDiscernByUrl_Android(recognizeLanguage, outputTextLanguageType, urlFilePath, expand);
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void SpeechDiscernByUrl_iOS(int recognizeLanguage, int outputTextLanguageType, string urlFilePath, string expand);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void SpeechDiscernByUrl_Android(int recognizeLanguage, int outputTextLanguageType, string urlFilePath, string expand)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.ChatSDK");
                sdkClass.CallStatic("speechDiscernByUrl", recognizeLanguage, outputTextLanguageType, urlFilePath, expand);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error in speech discern by URL on Android: " + e.Message);
            }
        }
#endif

        #endregion

        #region Audio Tools

        // Audio Tools Initialization
        public static void AudioTools_Init(string observer)
        {
#if UNITY_IOS && !UNITY_EDITOR
            AudioTools_Init_iOS(observer);
#elif UNITY_ANDROID && !UNITY_EDITOR
            AudioTools_Init_Android(observer);
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void AudioTools_Init_iOS(string observer);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void AudioTools_Init_Android(string observer)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.AudioTools");
                sdkClass.CallStatic("init", observer);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error initializing audio tools on Android: " + e.Message);
            }
        }
#endif

        // Start Recording
        public static void AudioTools_StartRecord(int minMilliseconds, int maxMilliseconds, bool isRecognize, int language)
        {
#if UNITY_IOS && !UNITY_EDITOR
            AudioTools_StartRecord_iOS(minMilliseconds, maxMilliseconds, isRecognize, language);
#elif UNITY_ANDROID && !UNITY_EDITOR
            AudioTools_StartRecord_Android(minMilliseconds, maxMilliseconds, isRecognize, language);
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void AudioTools_StartRecord_iOS(int minMilliseconds, int maxMilliseconds, bool isRecognize, int language);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void AudioTools_StartRecord_Android(int minMilliseconds, int maxMilliseconds, bool isRecognize, int language)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.AudioTools");
                sdkClass.CallStatic("startRecord", minMilliseconds, maxMilliseconds, isRecognize, language);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error starting recording on Android: " + e.Message);
            }
        }
#endif

        // Stop Recording
        public static void AudioTools_StopRecord()
        {
#if UNITY_IOS && !UNITY_EDITOR
            AudioTools_StopRecord_iOS();
#elif UNITY_ANDROID && !UNITY_EDITOR
            AudioTools_StopRecord_Android();
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void AudioTools_StopRecord_iOS();
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void AudioTools_StopRecord_Android()
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.AudioTools");
                sdkClass.CallStatic("stopRecord");
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error stopping recording on Android: " + e.Message);
            }
        }
#endif

        // Is Recording
        public static bool AudioTools_IsRecording()
        {
#if UNITY_IOS && !UNITY_EDITOR
            return AudioTools_IsRecording_iOS();
#elif UNITY_ANDROID && !UNITY_EDITOR
            return AudioTools_IsRecording_Android();
#else
            return false;
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern bool AudioTools_IsRecording_iOS();
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static bool AudioTools_IsRecording_Android()
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.AudioTools");
                return sdkClass.CallStatic<bool>("isRecording");
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error checking if recording on Android: " + e.Message);
                return false;
            }
        }
#endif

        // Play Audio
        public static int AudioTools_PlayAudio(string filePath)
        {
#if UNITY_IOS && !UNITY_EDITOR
            return AudioTools_PlayAudio_iOS(filePath);
#elif UNITY_ANDROID && !UNITY_EDITOR
            return AudioTools_PlayAudio_Android(filePath);
#else
            return -1;
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern int AudioTools_PlayAudio_iOS(string filePath);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static int AudioTools_PlayAudio_Android(string filePath)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.AudioTools");
                return sdkClass.CallStatic<int>("playAudio", filePath);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error playing audio on Android: " + e.Message);
                return -1;
            }
        }
#endif

        // Play Online Audio
        public static int AudioTools_PlayOnlineAudio(string fileUrl)
        {
#if UNITY_IOS && !UNITY_EDITOR
            return AudioTools_PlayOnlineAudio_iOS(fileUrl);
#elif UNITY_ANDROID && !UNITY_EDITOR
            return AudioTools_PlayOnlineAudio_Android(fileUrl);
#else
            return -1;
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern int AudioTools_PlayOnlineAudio_iOS(string fileUrl);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static int AudioTools_PlayOnlineAudio_Android(string fileUrl)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.AudioTools");
                return sdkClass.CallStatic<int>("playOnlineAudio", fileUrl);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error playing online audio on Android: " + e.Message);
                return -1;
            }
        }
#endif

        // Stop Play Audio
        public static void AudioTools_StopPlayAudio()
        {
#if UNITY_IOS && !UNITY_EDITOR
            AudioTools_StopPlayAudio_iOS();
#elif UNITY_ANDROID && !UNITY_EDITOR
            AudioTools_StopPlayAudio_Android();
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void AudioTools_StopPlayAudio_iOS();
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void AudioTools_StopPlayAudio_Android()
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.AudioTools");
                sdkClass.CallStatic("stopPlayAudio");
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error stopping audio playback on Android: " + e.Message);
            }
        }
#endif

        // Is Playing
        public static bool AudioTools_IsPlaying()
        {
#if UNITY_IOS && !UNITY_EDITOR
            return AudioTools_IsPlaying_iOS();
#elif UNITY_ANDROID && !UNITY_EDITOR
            return AudioTools_IsPlaying_Android();
#else
            return false;
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern bool AudioTools_IsPlaying_iOS();
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static bool AudioTools_IsPlaying_Android()
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.AudioTools");
                return sdkClass.CallStatic<bool>("isPlaying");
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error checking if audio is playing on Android: " + e.Message);
                return false;
            }
        }
#endif

        // Delete File
        public static bool AudioTools_DeleteFile(string filePath)
        {
#if UNITY_IOS && !UNITY_EDITOR
            return AudioTools_DeleteFile_iOS(filePath);
#elif UNITY_ANDROID && !UNITY_EDITOR
            return AudioTools_DeleteFile_Android(filePath);
#else
            return false;
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern bool AudioTools_DeleteFile_iOS(string filePath);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static bool AudioTools_DeleteFile_Android(string filePath)
        {
            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                    return true;
                }
                else
                {
                    Debug.LogWarning("File not found: " + filePath);
                    return false;
                }
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error deleting file on Android: " + e.Message);
                return false;
            }
        }
#endif

        // Set Metering Enabled
        public static void AudioTools_SetMeteringEnabled(bool enabled)
        {
#if UNITY_IOS && !UNITY_EDITOR
            AudioTools_SetMeteringEnabled_iOS(enabled);
#elif UNITY_ANDROID && !UNITY_EDITOR
            AudioTools_SetMeteringEnabled_Android(enabled);
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void AudioTools_SetMeteringEnabled_iOS(bool enabled);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static void AudioTools_SetMeteringEnabled_Android(bool enabled)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.AudioTools");
                sdkClass.CallStatic("setMeteringEnabled", enabled);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error setting metering enabled on Android: " + e.Message);
            }
        }
#endif

        // Add Shield
        public static int AddShieldWithUserId(string userId)
        {
#if UNITY_IOS && !UNITY_EDITOR
            return AddShieldWithUserId_iOS(userId);
#elif UNITY_ANDROID && !UNITY_EDITOR
            return AddShieldWithUserId_Android(userId);
#else
            return -1;
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern int AddShieldWithUserId_iOS(string userId);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static int AddShieldWithUserId_Android(string userId)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.ChatSDK");
                return sdkClass.CallStatic<int>("addShieldWithUserId", userId);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error adding shield with user ID on Android: " + e.Message);
                return -1;
            }
        }
#endif

        // Remove Shield
        public static int RemoveShieldWithUserId(string userId)
        {
#if UNITY_IOS && !UNITY_EDITOR
            return RemoveShieldWithUserId_iOS(userId);
#elif UNITY_ANDROID && !UNITY_EDITOR
            return RemoveShieldWithUserId_Android(userId);
#else
            return -1;
#endif
        }

#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern int RemoveShieldWithUserId_iOS(string userId);
#endif

#if UNITY_ANDROID && !UNITY_EDITOR
        private static int RemoveShieldWithUserId_Android(string userId)
        {
            try
            {
                AndroidJavaClass sdkClass = new AndroidJavaClass("com.yourcompany.yoursdk.ChatSDK");
                return sdkClass.CallStatic<int>("removeShieldWithUserId", userId);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error removing shield with user ID on Android: " + e.Message);
                return -1;
            }
        }
#endif

        #endregion
    }
}
