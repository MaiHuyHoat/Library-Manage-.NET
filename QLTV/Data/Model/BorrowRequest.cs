using System;
using System.Collections.Generic;

namespace QLTV.Data.Model
{
    public partial class BorrowRequest
    {
        public BorrowRequest()
        {
            BorrowTrackings = new HashSet<BorrowTracking>();
        }

        public int Id { get; set; }
        public int? ReaderId { get; set; }
        public int? BookId { get; set; }
        public DateTime DueDate { get; set; }
        public int Status { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Deleted { get; set; }

        public virtual Book? Book { get; set; }
        public virtual Reader? Reader { get; set; }
        public virtual ICollection<BorrowTracking> BorrowTrackings { get; set; }
    }
}
