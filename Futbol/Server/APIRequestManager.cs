using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace Futbol
{
	public class APIRequestManager
	{

		public static readonly String HostName = "http://112.78.11.31:8080/api/";
		private static readonly String SubPath = "news/publishers";

		public APIRequestManager ()
		{
		}

		public static void TestGetJSONRequest () {
			String RequestUrl = HostName + SubPath;

			String respond = APIRequest.Get (RequestUrl);
			Debug.WriteLine ("abc xyz" + respond);
		}
	}
}

