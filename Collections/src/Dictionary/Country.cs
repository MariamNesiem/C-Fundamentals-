using System;


namespace Dictionary
{
	class Country
	{
		public string Name { get; }
		public string Code { get; }
		public string Region { get; }
		public int Population { get; }

		public Country(string name, string code, string region)
		{
			this.Name = name;
			this.Code = code;
			this.Region = region;

		}
	}

}
