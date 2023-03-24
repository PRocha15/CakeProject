using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeDatabase.DbEntities
{
    public class  Resources : BaseEntity
    {
        public byte[] FileBytes { get; set; }

        public string Description { get; set; }

        public int FileExtension { get; set; }

        public string? FileChecksum { get; set; }

        [ForeignKey("Cake")]

        public int CakeId { get; set; }
      public virtual Cake Cake { get; set; }
    }
}
