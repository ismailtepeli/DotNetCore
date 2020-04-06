using IT.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT.Entity.Concrete
{
    public class Category: IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool isActive { get; set; }

        public string AddedBy { get; set; }

        public DateTime AddedDate { get; set; }
    }
}
