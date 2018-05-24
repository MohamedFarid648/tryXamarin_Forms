using System;
using System.Collections.Generic;
using System.Text;

namespace EApp3.Models
{
    public class Company
    {
        public int Id { get; set; }

        public int ReutersCode { get; set; }
        public string Name { get; set; }

        public string Sector { get; set; }

        public string Industry { get; set; }

        public string Currency { get; set; }



        public string Description { get; set; }


        public string ReportPrice { get; set; }

        public string ImageURL { get; set; }
    }
}
