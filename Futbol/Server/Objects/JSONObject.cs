using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Futbol
{
	public class JSONObject : Object
	{

		private IDictionary<String, Object> iDictionary = new Dictionary <String, Object> (); ///? eo hieu tai sao phai chuyen tu Dic sang Idic

		public JSONObject () : base () {
		}

		// convert JObject to JSONObject
		public JSONObject (JObject obj) : base () {

			// tao dic
			IDictionary<String, Object> dic = obj.ToObject<Dictionary<String, Object>> ();

			// doi chieu tung phan tu trong JObject -> hop thuc hoa cac item trong JObject thanh item trong JSONObject 
			foreach (var item in dic) {
				Object value = item.Value;

				if (value is JArray) {
					iDictionary [item.Key] = new JSONArray ((JArray)value);
				} else if (value is JObject) {
					iDictionary [item.Key] = new JSONObject ((JObject)value);
				} else {
					iDictionary [item.Key] = value;
				}

			}

			// end

		}



	}
}

