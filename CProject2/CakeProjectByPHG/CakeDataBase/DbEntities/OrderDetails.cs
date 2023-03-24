using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeDatabase.DbEntities
{
    public class OrderDetails : BaseEntity
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string ClientName { get; set; }

        public string CakeName { get; set; }    

        public DateTime OrderRequest { get; set; }

        public DateTime OrderCheckout { get; set; }
    }
}
