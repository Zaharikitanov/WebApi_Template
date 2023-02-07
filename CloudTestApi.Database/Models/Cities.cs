using System.ComponentModel.DataAnnotations.Schema;

namespace CloudTestApi.Database.Models
{
    //TODO apply constraints from SQL file

    [Table("Cities", Schema = "dbo")]
    public class Cities
    {
        public Guid Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Country { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Province { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; }

        public int Population { get; set; }

        public bool IsCapital { get; set; }
    }
}
