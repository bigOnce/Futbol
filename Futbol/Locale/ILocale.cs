using System;

namespace ACE
{
	public interface ILocale
	{
		string GetCurrent(); // Get CurrentCulture
		void SetLocale(); // Set CurrentCulture
	}
}

