using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Data.Entity
{
    internal class SachItSuDungExportExcel
    {
        public string Id { get; set; }

        public string Name { get; set; }

 
        public string BorrowRequestCount { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }

        public SachItSuDungExportExcel(string id, string name,  string category, string author, string borrowRequestCount)
        {
            Id = id;
       
            Name = name;
            BorrowRequestCount = borrowRequestCount;
            Category = category;
            Author = author;
        }
    }
}
