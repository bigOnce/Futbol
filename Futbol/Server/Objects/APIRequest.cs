using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

using Xamarin.Forms;

namespace Futbol
{
	public class APIRequest
	{

		public static String Get (String url) {
			return (GetAsync (url)).Result;
		}

		public static async Task<String> GetAsync (String url) {
			return await (new HttpClient ()).GetStringAsync (url);
		}
			
	}
}

