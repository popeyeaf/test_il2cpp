using UnityEngine;
using System.Collections.Generic;
using System;

namespace RO
{
	[SLua.CustomLuaClassAttribute]
	public class InputGesture : MonoBehaviour
	{
		public Action zoomInAction;
		public Action zoomOutAction;
		float catchDistance = 0;

		void Update ()
		{
			if (Input.touches.Length == 2) {
				Touch point1 = Input.touches [0];
				Touch point2 = Input.touches [1];
				if (point1.phase == TouchPhase.Began || point2.phase == TouchPhase.Began) {
					catchDistance = Vector3.Distance (point1.position, point2.position);
				} else if (point1.phase == TouchPhase.Ended || point2.phase == TouchPhase.Ended) {
					float dis = Vector3.Distance (point1.position, point2.position);
					if (dis - catchDistance > 50) {
						if (null != zoomInAction) {
							zoomInAction ();
						}
					} else if (catchDistance - dis > 50) {
						if (null != zoomOutAction) {
							zoomOutAction ();
						}
					}
					catchDistance = 0;
				}
			}
		}
	}
} // namespace RO
