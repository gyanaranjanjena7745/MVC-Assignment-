using System.ComponentModel.DataAnnotations.Schema;

namespace MachineTestProject.Models
{
    [Table("tbl_Product")]
    public class Product : BaseType 
    {
        public string Name { get;set; }
        public int CategoryId { get;set; }
        public virtual Category Category { get; set; }
    }
}
