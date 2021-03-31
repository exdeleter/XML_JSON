using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.JSON
{
    class MCJSON
    {
        public class Rootobject
        {
            public Multinationalcorporation MultinationalCorporation { get; set; }
        }

        public class Multinationalcorporation
        {
            public Occupations Occupations { get; set; }
            public Countrymarkets CountryMarkets { get; set; }
            public Staffs Staffs { get; set; }
        }

        public class Occupations
        {
            public Occupation[] Occupation { get; set; }
        }

        public class Occupation
        {
            public int id { get; set; }
            public string categories { get; set; }
            public int time { get; set; }
            public int volume { get; set; }
            public string countryproduce { get; set; }
        }

        public class Countrymarkets
        {
            public Countrymarket[] CountryMarket { get; set; }
        }

        public class Countrymarket
        {
            public int id { get; set; }
            public string namecountry { get; set; }
            public Influence influence { get; set; }
            public Workers Workers { get; set; }
        }

        public class Influence
        {
            public int idoccup { get; set; }
            public int procent { get; set; }
            public int volume { get; set; }
        }

        public class Workers
        {
            public string headmen { get; set; }
            public string maindeveloper { get; set; }
            public string PRAgent { get; set; }
        }

        public class Staffs
        {
            public Staff[] Staff { get; set; }
        }

        public class Staff
        {
            public int id { get; set; }
            public string position { get; set; }
            public Education education { get; set; }
            public Information information { get; set; }
            public decimal salary { get; set; }
            public int workingtime { get; set; }
        }

        public class Education
        {
            public School school { get; set; }
            public Institute institute { get; set; }
        }

        public class School
        {
            public int code { get; set; }
            public string country { get; set; }
            public string city { get; set; }
        }

        public class Institute
        {
            public int code { get; set; }
            public string country { get; set; }
            public string city { get; set; }
        }

        public class Information
        {
            public int age { get; set; }
            public string familyStatus { get; set; }
            public int EnterYear { get; set; }
        }

    }
}
