using System;
using System.Collections.Generic;

namespace QLTV.Data.Model
{
    public partial class BorrowTracking
    {
        public int Id { get; set; }
        public int? RequestId { get; set; }
        public DateTime ReturnDate { get; set; }
        public int? ReturnStatus { get; set; }
        public decimal? FineAmound { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Deleted { get; set; }

        public virtual BorrowRequest? Request { get; set; }
    }
}
