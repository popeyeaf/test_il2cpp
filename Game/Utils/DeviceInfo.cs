using UnityEngine;
using System.Collections;
using System.IO;
#if UNITY_ANDROID && !UNITY_EDITOR
using UnityEngine.Android;
#endif

[SLua.CustomLuaClassAttribute]
public class DeviceInfo
{
    public static string GetModel()
    {
        return SystemInfo.deviceModel;
    }

    public static string GetName()
    {
        return SystemInfo.deviceName;
    }

    public static string GetID()
    {
        return SystemInfo.deviceUniqueIdentifier;
    }

    public static int GetScreenWidth()
    {
        return Screen.width;
    }

    public static int GetScreenHeight()
    {
        return Screen.height;
    }

    public static string GetCPUName()
    {
        return SystemInfo.processorType;
    }

    public static int GetCPUCoresCount()
    {
        return SystemInfo.processorCount;
    }

    public static int GetSizeOfRAM()
    {
        return SystemInfo.systemMemorySize;
    }

    public static long GetSizeOfMemory()
    {
        long size = 0;
#if UNITY_EDITOR
        DriveInfo[] drives = DriveInfo.GetDrives();
        foreach (DriveInfo drive in drives)
        {
            if (drive.IsReady)
                size += drive.TotalSize;
        }
#elif UNITY_ANDROID && !UNITY_EDITOR
        // ใช้พื้นที่ภายในและภายนอก
        size = GetSizeOfInternalMemory() + GetSizeOfExternalMemory();
#endif
        return size;
    }

    public static long GetSizeOfValidMemory()
    {
        long size = 0;
#if UNITY_EDITOR
        size = long.MaxValue;
#elif UNITY_ANDROID && !UNITY_EDITOR
        size = GetSizeOfValidInternalMemory() + GetSizeOfValidExternalMemory();
#endif
        return size;
    }

#if UNITY_ANDROID && !UNITY_EDITOR
    // เมธอดช่วยสำหรับการดึงข้อมูลพื้นที่จัดเก็บ
    private static long GetStorageSize(string path)
    {
        try
        {
            AndroidJavaObject statFs = new AndroidJavaObject("android.os.StatFs", path);
            long blockSize = statFs.Call<long>("getBlockSizeLong");
            long totalBlocks = statFs.Call<long>("getBlockCountLong");
            return blockSize * totalBlocks;
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error getting storage size for path " + path + ": " + e.Message);
            return 0;
        }
    }

    private static long GetAvailableStorageSize(string path)
    {
        try
        {
            AndroidJavaObject statFs = new AndroidJavaObject("android.os.StatFs", path);
            long blockSize = statFs.Call<long>("getBlockSizeLong");
            long availableBlocks = statFs.Call<long>("getAvailableBlocksLong");
            return blockSize * availableBlocks;
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error getting available storage size for path " + path + ": " + e.Message);
            return 0;
        }
    }
#endif

    public static long GetSizeOfInternalMemory()
    {
        long size = 0;
#if UNITY_EDITOR
        // ใน Editor จำลองขนาดพื้นที่ภายใน
        size = 64L * 1024L * 1024L * 1024L; // 64GB
#elif UNITY_ANDROID && !UNITY_EDITOR
        string internalPath = Application.persistentDataPath;
        size = GetStorageSize(internalPath);
#endif
        return size;
    }

    public static long GetSizeOfValidInternalMemory()
    {
        long size = 0;
#if UNITY_EDITOR
        // ใน Editor จำลองพื้นที่ภายในที่ว่าง
        size = 32L * 1024L * 1024L * 1024L; // 32GB
#elif UNITY_ANDROID && !UNITY_EDITOR
        string internalPath = Application.persistentDataPath;
        size = GetAvailableStorageSize(internalPath);
#endif
        return size;
    }

    public static long GetSizeOfFreeInternalMemory()
    {
        // สำหรับ Android สมัยใหม่ พื้นที่ที่ว่างจะเท่ากับพื้นที่ที่ใช้งานได้
        return GetSizeOfValidInternalMemory();
    }

    public static long GetSizeOfExternalMemory()
    {
        long size = 0;
#if UNITY_EDITOR
        // ใน Editor จำลองขนาดพื้นที่ภายนอก
        size = 128L * 1024L * 1024L * 1024L; // 128GB
#elif UNITY_ANDROID && !UNITY_EDITOR
        // บน Android 10+ การเข้าถึงพื้นที่ภายนอกถูกจำกัด
        // คุณอาจต้องขออนุญาตเพิ่มเติมหรือใช้ Storage Access Framework
        string externalPath = "/storage/emulated/0";
        if (Directory.Exists(externalPath))
        {
            size = GetStorageSize(externalPath);
        }
        else
        {
            Debug.LogWarning("External storage path not found or inaccessible.");
        }
#endif
        return size;
    }

    public static long GetSizeOfValidExternalMemory()
    {
        long size = 0;
#if UNITY_EDITOR
        // ใน Editor จำลองพื้นที่ภายนอกที่ว่าง
        size = 64L * 1024L * 1024L * 1024L; // 64GB
#elif UNITY_ANDROID && !UNITY_EDITOR
        string externalPath = "/storage/emulated/0";
        if (Directory.Exists(externalPath))
        {
            size = GetAvailableStorageSize(externalPath);
        }
        else
        {
            Debug.LogWarning("External storage path not found or inaccessible.");
        }
#endif
        return size;
    }

    public static long GetSizeOfFreeExternalMemory()
    {
        // สำหรับ Android สมัยใหม่ พื้นที่ที่ว่างจะเท่ากับพื้นที่ที่ใช้งานได้
        return GetSizeOfValidExternalMemory();
    }

    public static long GetSizeOfDataMemory()
    {
        // ในบริบทนี้ เราสามารถถือว่าพื้นที่ Data เป็นพื้นที่ภายใน
        return GetSizeOfInternalMemory();
    }

    public static long GetSizeOfValidDataMemory()
    {
        return GetSizeOfValidInternalMemory();
    }

    public static long GetSizeOfFreeDataMemory()
    {
        return GetSizeOfFreeInternalMemory();
    }

    public static void ExternalStorageState()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        try
        {
            AndroidJavaClass environment = new AndroidJavaClass("android.os.Environment");
            string state = environment.CallStatic<string>("getExternalStorageState");
            Debug.Log("External storage state: " + state);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error getting external storage state: " + e.Message);
        }
#endif
    }

    public static string GetGPUName()
    {
        return SystemInfo.graphicsDeviceName;
    }

    public static string GetGPUType()
    {
        return SystemInfo.graphicsDeviceType.ToString();
    }

    public static string GetUserIp()
    {
        string ipAddress = "";
        try
        {
            var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ipAddress = ip.ToString();
                    break;
                }
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error getting user IP: " + e.Message);
        }
        return ipAddress;
    }
}
