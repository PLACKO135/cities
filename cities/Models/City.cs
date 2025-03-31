using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cities.Models
{
    internal class City
    {
        private string? cITY_CODE;
        private string? cITY_NAME;
        private int? y2010;
        private int? y2020;
        private int? y2030;
        private int? y2040;
        private int? y2050;

        public string? CITY_CODE { get => cITY_CODE; set => cITY_CODE = value; }
        public string? CITY_NAME { get => cITY_NAME; set => cITY_NAME = value; }
        public int? Y2010 { get => y2010; set => y2010 = value; }
        public int? Y2020 { get => y2020; set => y2020 = value; }
        public int? Y2030 { get => y2030; set => y2030 = value; }
        public int? Y2040 { get => y2040; set => y2040 = value; }
        public int? Y2050 { get => y2050; set => y2050 = value; }
    }
}
