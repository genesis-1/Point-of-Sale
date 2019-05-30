using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosApp.Bussiness
{
    class CategoryLL
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
