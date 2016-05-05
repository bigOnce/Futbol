using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace Futbol
{
	public class APIRequestManager
	{

		public static readonly string HostName = "http://112.78.11.31:8080/api/";
		private static readonly string SubPath = "news/publishers";

		public APIRequestManager ()
		{
		}

		public static void TestGetJSONRequest () {
			string RequestUrl = HostName + SubPath;

			string respond = APIRequest.Get (RequestUrl);
			Debug.WriteLine ("abc xyz" + respond);
		}
	}
}

