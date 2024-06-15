using System;
using System.Collections.Generic;

namespace QLTV.Data.Model
{
    public partial class BorrowRequest
    {
        public BorrowRequest()
        {
            BorrowTracking = new HashSet<BorrowTracking>();
        }

        public int Id { get; set; }
        public int? ReaderId { get; set; }
        public int? BookId { get; set; }
        public DateTime DueDate { get; set; }
        public int Status { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Deleted { get; set; }

        public Book Book { get; set; }
        public Reader Reader { get; set; }
        public ICollection<BorrowTracking> BorrowTracking { get; set; }
    }
}
