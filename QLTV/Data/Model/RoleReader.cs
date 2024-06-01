using System;
using System.Collections.Generic;

namespace QLTV.Data.Model
{
    public partial class RoleReader
    {
        public RoleReader()
        {
            Readers = new HashSet<Reader>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Deleted { get; set; }

        public virtual ICollection<Reader> Readers { get; set; }
    }
}
