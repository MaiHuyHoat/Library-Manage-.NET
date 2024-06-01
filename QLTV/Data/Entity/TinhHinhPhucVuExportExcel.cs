using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Data.Entity
{
    public class TinhHinhPhucVuExportExcel
    {
        public String id;

        public String nameBook;
        public String amountBook;
        public String countServed;
        public String countBorrow;
        public String returnGood;
        public String returnBad;
        public String returnVeryBad;
        public String totalFineAmount;

        public TinhHinhPhucVuExportExcel(String id, String nameBook, String amountBook, String countServed, String countBorrow, String returnGood, String returnBad, String returnVeryBad, String totalFineAmount)
        {
            this.id = id;
            this.nameBook = nameBook;
            this.amountBook = amountBook;
            this.countServed = countServed;
            this.countBorrow = countBorrow;
            this.returnGood = returnGood;
            this.returnBad = returnBad;
            this.returnVeryBad = returnVeryBad;
            this.totalFineAmount = totalFineAmount;
        }
    }
}
