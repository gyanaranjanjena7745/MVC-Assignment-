using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MachineTestProject.Models
{
    public abstract class BaseType
    {
        [Key]
        public int Id { get; set; }
    }
}
