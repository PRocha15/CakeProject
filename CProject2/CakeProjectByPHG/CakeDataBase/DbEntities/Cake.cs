using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeDatabase.DbEntities
{
    public class Cake : BaseEntity

    {
        public string CakeName { get; set; }

        public string CakeDescription { get; set; }

        public DateTime CakeConfeccion { get; set; }

        public ICollection<Resources> Resources { get; set; }

    }
}
