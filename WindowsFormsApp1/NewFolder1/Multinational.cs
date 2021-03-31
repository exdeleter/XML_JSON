using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
//using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class Multinational
    {
		[XmlRoot(ElementName = "Occupation")]
		public class Occupation
		{
			[XmlElement(ElementName = "categories")]
			public string Categories { get; set; }
			[XmlElement(ElementName = "time")]
			public int Time { get; set; }
			[XmlElement(ElementName = "volume")]
			public decimal Volume { get; set; }
			[XmlElement(ElementName = "countryproduce")]
			public string Countryproduce { get; set; }
			[XmlAttribute(AttributeName = "id")]
			public int Id { get; set; }
		}

		[XmlRoot(ElementName = "Occupations")]
		public class Occupations
		{
			[XmlElement(ElementName = "Occupation")]
			public List<Occupation> Occupation { get; set; }
		}

		[XmlRoot(ElementName = "influence")]
		public class Influence
		{
			[XmlElement(ElementName = "idoccup")]
			public int Idoccup { get; set; }
			[XmlElement(ElementName = "procent")]
			public decimal Procent { get; set; }
			[XmlElement(ElementName = "volume")]
			public decimal Volume { get; set; }
		}

		[XmlRoot(ElementName = "Workers")]
		public class Workers
		{
			[XmlElement(ElementName = "headmen")]
			public string Headmen { get; set; }
			[XmlElement(ElementName = "maindeveloper")]
			public string Maindeveloper { get; set; }
			[XmlElement(ElementName = "PR-Agent")]
			public string PRAgent { get; set; }
		}

		[XmlRoot(ElementName = "CountryMarket")]
		public class CountryMarket
		{
			[XmlElement(ElementName = "namecountry")]
			public string Namecountry { get; set; }
			[XmlElement(ElementName = "influence")]
			public Influence Influence { get; set; }
			[XmlElement(ElementName = "Workers")]
			public Workers Workers { get; set; }
			[XmlAttribute(AttributeName = "id")]
			public int Id { get; set; }
		}

		[XmlRoot(ElementName = "CountryMarkets")]
		public class CountryMarkets
		{
			[XmlElement(ElementName = "CountryMarket")]
			public List<CountryMarket> CountryMarket { get; set; }
		}

		[XmlRoot(ElementName = "school")]
		public class School
		{
			[XmlAttribute(AttributeName = "code")]
			public int Code { get; set; }
			[XmlAttribute(AttributeName = "country")]
			public string Country { get; set; }
			[XmlAttribute(AttributeName = "city")]
			public string City { get; set; }
		}

		[XmlRoot(ElementName = "institute")]
		public class Institute
		{
			[XmlAttribute(AttributeName = "code")]
			public int Code { get; set; }
			[XmlAttribute(AttributeName = "country")]
			public string Country { get; set; }
			[XmlAttribute(AttributeName = "city")]
			public string City { get; set; }
		}

		[XmlRoot(ElementName = "education")]
		public class Education
		{
			[XmlElement(ElementName = "school")]
			public School School { get; set; }
			[XmlElement(ElementName = "institute")]
			public Institute Institute { get; set; }
		}

		[XmlRoot(ElementName = "information")]
		public class Information
		{
			[XmlElement(ElementName = "age")]
			public int Age { get; set; }
			[XmlElement(ElementName = "familyStatus")]
			public string FamilyStatus { get; set; }
			[XmlElement(ElementName = "EnterYear")]
			public int EnterYear { get; set; }
		}

		[XmlRoot(ElementName = "Staff")]
		public class Staff
		{
			[XmlElement(ElementName = "position")]
			public string Position { get; set; }
			[XmlElement(ElementName = "education")]
			public Education Education { get; set; }
			[XmlElement(ElementName = "information")]
			public Information Information { get; set; }
			[XmlElement(ElementName = "salary")]
			public string Salary { get; set; }
			[XmlElement(ElementName = "workingtime")]
			public int Workingtime { get; set; }
			[XmlAttribute(AttributeName = "id")]
			public int Id { get; set; }
		}

		[XmlRoot(ElementName = "Staffs")]
		public class Staffs
		{
			[XmlElement(ElementName = "Staff")]
			public List<Staff> Staff { get; set; }
		}

		[XmlRoot(ElementName = "MultinationalCorporation")]
		public class MultinationalCorporation
		{
			[XmlElement(ElementName = "Occupations")]
			public Occupations Occupations { get; set; }
			[XmlElement(ElementName = "CountryMarkets")]
			public CountryMarkets CountryMarkets { get; set; }
			[XmlElement(ElementName = "Staffs")]
			public Staffs Staffs { get; set; }
		}
	}
}
