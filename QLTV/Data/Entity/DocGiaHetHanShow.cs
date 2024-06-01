using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Data.Entity
{
    internal class DocGiaHetHanShow
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string IdentityCard { get; set; }    
        public string DateOfBirth { get; set; }
        public string  StartDate { get; set; }  
        public string EndDate { get; set; }
        public string Role { get; set; }
        public int BorrowRequestCount { get; set; } 
        public int BookReturned { get; set; }
        public int BookNotReturned { get; set; }    

    }
}
