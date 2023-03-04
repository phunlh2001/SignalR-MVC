using System.ComponentModel.DataAnnotations;

namespace Test_SignalR.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string ProdName { get; set; }
        public string Category { get; set; }
        public string UnitPrice { get; set; }
        public int StockQty { get; set; }
    }
}
