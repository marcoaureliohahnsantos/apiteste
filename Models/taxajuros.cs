using System.ComponentModel.DataAnnotations.Schema;
namespace WebApiJuros1.Models
{
    public class taxajuros
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public double juros { get; set; }
    }
}
