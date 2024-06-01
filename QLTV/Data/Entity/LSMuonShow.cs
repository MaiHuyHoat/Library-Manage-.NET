using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Data.Entity
{
    internal class LSMuonShow
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string NameBook { get; set; }
        public string Price {  get; set; }
        public string NameReader { get; set; }
        public string IdentityCardReader { get; set; }
        public int ReturnStatus { get; set; }
        public DateTime ReturnDate { get; set; }

        public DateTime UpdatedAt { get; set; }
        public string FineAmount { get; set; }
        public int Deleted { get; set; }
    }
}
