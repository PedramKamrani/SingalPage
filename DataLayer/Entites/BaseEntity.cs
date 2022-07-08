using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entites
{
    public class BaseEntity
    {
        public BaseEntity()
        {
              CreationDate = DateTime.UtcNow;
        }
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateCreation { get; set; }
    }
}
