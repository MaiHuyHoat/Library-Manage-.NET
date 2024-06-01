using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Data.Entity
{
    internal class DocGiaShow
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string DateOfBirth { get; set; }
        public string IdentityCard { get; set; } = null!;
        public string Role { get; set; }
        public string StartDay { get; set; }
        public string ReaderAddress { get; set; }

        public string EndDay { get; set; }
        public int BooksBorrowed { get; set; }
        public int BorrowedTime { get; set; }
        public decimal Deposit { get; set; }    }
}
