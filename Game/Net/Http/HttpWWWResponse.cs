using UnityEngine;
using System.Collections.Generic;
using LitJson;

namespace RO
{
	[SLua.CustomLuaClassAttribute]
	public class HttpWWWResponse
	{
		public string wwwError;   //www的错误
		
		public string resString;
		public int Status;    //返回的状态（0 表示OK)
		public string  message;          //异常信息
		private JsonData origindata;    //解析过后的数据
		public JsonData resData {
			set {
				if (value != null) {
					if (value.Keys.Contains ("status")) {
						Status = int.Parse (value ["status"].ToString ());
					}
					
					if (value.Keys.Contains ("message")) {
						RO.LoggerUnused.Log ("Some Wrong Msg：" + value ["message"].ToString ());
						//return;  //出错，暂时返回跳出
						message = value ["message"].ToString ();
//						if (Status == 1)
//							UTTools.CreatTips (message);
					}
				}
				origindata = value;
			}
			
			get {
				return origindata;
			}
		}
	}
} // namespace RO
