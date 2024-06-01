using QLTV.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Data.Entity
{
    public class MuonSachShow 
    {
        public int Id { get; set; } 
        public string Image { get; set; }
        public string NameBook { get; set; }
        public string NameReader { get; set; }
        public string IdentityCardReader { get; set; }
        public DateTime BorrowDate { get; set; } 

        public DateTime DueDate { get; set; }
    }
}
