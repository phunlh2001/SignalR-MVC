using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_SignalR.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public string Category { get; set; }
        public string UnitPrice { get; set; }
        public int StockQty { get; set; }
    }
}
