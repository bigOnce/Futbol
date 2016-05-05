using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Futbol
{
	public class JSONArray : Object
	{
		private IList<Object> iList = new List<Object> ();

		public JSONArray () : base () {
		}

		public JSONArray  (JArray src) : base () {

			// hop thuc hoas cac phan tu co trong JArray thanh cac phan tu JSONArray
			foreach (var item in src) {
				if (item is JArray) {
					iList.Add (new JSONArray ((JArray)item));
				}else if (item is JObject) {
					iList.Add (new JSONObject ((JObject)item));
				}else {
					iList.Add (item);
				}
			}

			// end

		}


	}
}

