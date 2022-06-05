using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WWProfileMaker.Domain.VirtualEntities
{
    public abstract class BaseEntity     {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key] 
        public Guid id { get; set; }
    }
}