using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.Data.Entity
{
    internal class SachItSuDungShow
    {
        public int Id { get; set; }
        public string PathImage { get; set; }
        public string Name { get; set; }

        public int BorrowRequestCount { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }

        public SachItSuDungShow(int id, string pathImage, string name, int borrowRequestCount, string category, string author)
        {
            Id = id;
            PathImage = pathImage;
            Name = name;
            BorrowRequestCount = borrowRequestCount;
            Category = category;
            Author = author;
        }
    }
}
