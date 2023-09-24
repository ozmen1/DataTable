using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DataTable.Models
{
    public class Product
    {
        [Required]
        [StringLength(50)]
        [DisplayName("Ürün kodu")]
        public string Code { get; set; }

        [Required]
        [StringLength(150)]
        [DisplayName("Ürün adı")]
        public string Name { get; set; }

        [DisplayName("Barkod")]
        public string BarcodeId { get; set; }

    }
}
