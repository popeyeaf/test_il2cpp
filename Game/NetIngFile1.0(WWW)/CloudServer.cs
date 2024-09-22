﻿[SLua.CustomLuaClassAttribute]
public class CloudServer
{
	public const string VISIT_DOMAIN = "http://192.168.137.1";
	public const string UPLOAD_BLOCKS_DOMAIN = "http://192.168.137.1/ro-xdcdn/";
	public const string AUTH_KEY = "Authorization";
	public static string AUTH_VALUE = "";
}

namespace CloudFile
{
	[SLua.CustomLuaClassAttribute]
	public class UpYunServer
	{
#if UNITY_EDITOR
		public const string DOWNLOAD_DOMAIN = "http://192.168.137.1/ro-xdcdn";
		public const string UPLOAD_NORMAL_DOMAIN = "http://192.168.137.1/ro-xdcdn";
		public const string UPLOAD_BLOCKS_DOMAIN = "http://192.168.137.1/ro-xdcdn";
#elif UNITY_ANDROID
		public const string DOWNLOAD_DOMAIN = "http://192.168.137.1/ro-xdcdn";
		public const string UPLOAD_NORMAL_DOMAIN = "http://192.168.137.1/ro-xdcdn";
		public const string UPLOAD_BLOCKS_DOMAIN = "http://192.168.137.1/ro-xdcdn";
#else
		public const string DOWNLOAD_DOMAIN = "http://192.168.137.1/ro-xdcdn";
		public const string UPLOAD_NORMAL_DOMAIN = "http://192.168.137.1/ro-xdcdn";
		public const string UPLOAD_BLOCKS_DOMAIN = "http://192.168.137.1/ro-xdcdn";
#endif
		public const string AUTH_KEY = "Authorization";
		public static string AUTH_VALUE = "";
	}
}