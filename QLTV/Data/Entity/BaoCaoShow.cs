using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Data.Entity
{
    internal class BaoCaoShow
    {
        public int Id { get; set; }
        public string PathImage { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int CountServed { get; set; }
        public int Borrow {  get; set; }
        public int ReturnGood { get; set; }
        public int ReturnBad { get; set; }
        public int ReturnVeryBad { get; set; }
        public int TotalFineAmount { get; set; }
    }
}
