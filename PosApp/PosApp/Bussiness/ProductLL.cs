using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosApp.Bussiness
{
    class ProductLL
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Category { get; set; }

        public string description { get; set; }

        public decimal rate { get; set; }

        public decimal qty { get; set; }

        public DateTime addedDate { get; set; }

        public int addedBy { get; set; }

    }
}
