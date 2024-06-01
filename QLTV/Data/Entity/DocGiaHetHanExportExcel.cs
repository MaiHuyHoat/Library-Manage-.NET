using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Data.Entity
{
    internal class DocGiaHetHanExportExcel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IdentityCard { get; set; }
        public string DateOfBirth { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Role { get; set; }
        public string BorrowRequestCount { get; set; }
        public string BookReturned { get; set; }
        public string BookNotReturned { get; set; }

        public DocGiaHetHanExportExcel(string id, string name, string identityCard, string dateOfBirth, string startDate, string endDate, string role, string borrowRequestCount, string bookReturned, string bookNotReturned)
        {
            Id = id;
            Name = name;
            IdentityCard = identityCard;
            DateOfBirth = dateOfBirth;
            StartDate = startDate;
            EndDate = endDate;
            Role = role;
            BorrowRequestCount = borrowRequestCount;
            BookReturned = bookReturned;
            BookNotReturned = bookNotReturned;
        }

        public DocGiaHetHanExportExcel()
        {
        }
    }
}
