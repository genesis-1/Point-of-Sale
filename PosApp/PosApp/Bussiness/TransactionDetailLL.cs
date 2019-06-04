using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosApp.Bussiness
{
    class TransactionDetailLL
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal Rate { get; set; }
        public decimal Qty { get; set; }
        public decimal Total { get; set; }

        public int DealerCustomerId { get; set; }

        public DateTime AddedDate { get; set; }

        public int AddedBy { get; set; }

    }
}
