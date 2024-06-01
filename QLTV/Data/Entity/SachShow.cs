using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Data.Entity
{
    public class SachShow
    {
        public int Id { get; set; }
        public string PathImage { get; set; }
        public string Name { get; set; }

        public int Amount { get; set; }  
        public string Category { get; set; }  
        public string Author { get; set; }

        public string Price { get; set; }
        public String CreatedDate { get; set; }
       
    }
}
