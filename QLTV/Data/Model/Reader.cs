using System;
using System.Collections.Generic;

namespace QLTV.Data.Model
{
    public partial class Reader
    {
        public Reader()
        {
            BorrowRequests = new HashSet<BorrowRequest>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string? ReaderAddress { get; set; }
        public string IdentityCard { get; set; } = null!;
        public DateTime StartDay { get; set; }
        public DateTime? EndDay { get; set; }
        public int? BooksBorrowed { get; set; }
        public int? BorrowedTime { get; set; }
        public decimal? Deposit { get; set; }
        public int? RoleId { get; set; }
        public int Deleted { get; set; }

        public virtual RoleReader? Role { get; set; }
        public virtual ICollection<BorrowRequest> BorrowRequests { get; set; }
    }
}
