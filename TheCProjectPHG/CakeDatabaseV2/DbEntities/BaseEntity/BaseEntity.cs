using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CakeDatabase.DbEntities
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool Statuts { get; set; }

        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
