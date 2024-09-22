using UnityEngine;
using System.Collections.Generic;
using System;

namespace RO
{
	[SLua.CustomLuaClassAttribute]
	public class HttpWWWSeveralRequests
	{

		bool _started = false;
		bool _successGetResponse = false;
		List<HttpWWWRequestOrder> _orders;
		List<HttpWWWRequestOrder> _failures;
		Action<HttpWWWResponse> _successCall;
		Action<HttpWWWRequestOrder> _failedCall;

		public void AddOrder (HttpWWWRequestOrder order)
		{
			if (_started == false) {
				if (_orders == null) {
					_orders = new List<HttpWWWRequestOrder> ();
					RO.LoggerUnused.LogFormat("new orders");
				}
				if (_orders.Contains (order) == false) {
					order.SetCallBacks (SuccessRequested, OrderOverTime, OrderError);
					_orders.Add (order);
					RO.LoggerUnused.LogFormat("contain orders");
				}
			}
		}

		protected void OrderError (HttpWWWRequestOrder order)
		{
			if (_failures == null) {
				_failures = new List<HttpWWWRequestOrder> ();
				RO.LoggerUnused.LogFormat("no orders");
			}
			if (_failures.Contains (order) == false) {
				_failures.Add (order);
				RO.LoggerUnused.LogFormat("no orders");
			}
			if (_failures.Count == _orders.Count) {
				FailureCall (order);
				RO.LoggerUnused.LogFormat("no orders");
			}
		}

		protected void SuccessRequested (HttpWWWResponse response)
		{
			SuccessCall (response);
			RO.LoggerUnused.LogFormat("successcall");
		}

		protected void OrderOverTime (HttpWWWRequestOrder order)
		{
			OrderError (order);
		}

		protected void SuccessCall (HttpWWWResponse response)
		{
			if (_successCall != null && _successGetResponse == false) {
				_successGetResponse = true;
				_successCall (response);
				RO.LoggerUnused.LogFormat("successcall");
			}
		}

		protected void FailureCall (HttpWWWRequestOrder order)
		{
			if (_failedCall != null) {
				_failedCall (order);
				RO.LoggerUnused.LogFormat("fail");
			}
		}

		public void SetCallBacks (Action<HttpWWWResponse> successCall, Action<HttpWWWRequestOrder> failedCall)
		{
			this._successCall = successCall;
			this._failedCall = failedCall;
		}
	
		public void StartRequest ()
		{
			if (_started == false) {
				if (_orders != null && _orders.Count > 0) {
					if (HttpWWWRequest.Me != null) {
						_started = true;
						for (int i=0; i<_orders.Count; i++) {
							Debug.LogFormat ("request {0}", _orders [i].url);
							HttpWWWRequest.Me.RequestByOrder (_orders [i]);
						}
					} else {
						RO.LoggerUnused.LogFormat ("HttpWWWSeveralRequests wanted to StartRequest,but no HttpWWWRequest Instance");
					}
				} else {
					RO.LoggerUnused.LogFormat ("HttpWWWSeveralRequests wanted to StartRequest,but no orders");
				}
			}
		}

		public void Dispose ()
		{
			_successCall = null;
			_failedCall = null;
			RO.LoggerUnused.LogFormat("dispose");
		}
	}
} // namespace RO
