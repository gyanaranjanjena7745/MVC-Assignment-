using System.ComponentModel.DataAnnotations.Schema;

namespace MachineTestProject.Models
{
    [Table("tbl_Category")]
    public class Category : BaseType
    {
        public string CategoryName { get; set; }
    }
}
