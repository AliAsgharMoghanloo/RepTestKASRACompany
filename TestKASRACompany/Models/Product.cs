using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace TestKASRACompany.Models
{
    public class Product
    {
        [Display(Name = "کد کالا")]
        [Key]
        public int Id { get; set; }
       
        [Display(Name =  "نام کالا")]
        [MaxLength(200) ]
        public string Name { get; set; }
      
        [Display(Name = "تعداد  ")]
        public int CountP { get; set; }
      
        [Display(Name = "قیمت  ")]
        [Column(TypeName = "decimal(18,0)")]
        [DisplayFormat(DataFormatString = "{0.0}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }
      
     



    }
}
