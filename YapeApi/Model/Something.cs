using System.ComponentModel.DataAnnotations.Schema;

namespace YapeApi.Model
{
    [Table("Something")]
    public class Something
    {
        public int Id { get; set; }

        public int? Value { get; set; }

    }
}