using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeDataBase.DBEntities.Base
{   
    [Key]

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public class BaseEntity
    {
       public int Id { get; set; }
       public bool Status { get; set; }
       public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
