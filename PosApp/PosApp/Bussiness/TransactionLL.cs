﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosApp.Bussiness
{
    class TransactionLL
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public int DealerCustomerId { get; set; }

        public decimal GrandTotal { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal Tax { get; set; }

        public decimal Discount { get; set; }

        public int AddedBy { get; set; }

        public DataTable TransactionDetails { get; set; }
    }
}
