using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

using Xamarin.Forms;

namespace Futbol
{
	public class APIRequest
	{

		public static string Get (string url) {
			return (GetAsync (url)).Result;
		}

		public static async Task<string> GetAsync (string url) {
			return await (new HttpClient ()).GetStringAsync (url);
		}
			
	}
}

