using Microsoft.EntityFrameworkCore;
using Test_SignalR.Models;

namespace Test_SignalR.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    ProdName = "Name1",
                    Category = "Caterory",
                    StockQty = 100,
                    UnitPrice = "bag"
                },
                new Product
                {
                    ID = 2,
                    ProdName = "Name2",
                    Category = "Caterory",
                    StockQty = 100,
                    UnitPrice = "bag"
                },
                new Product
                {
                    ID = 3,
                    ProdName = "Name3",
                    Category = "Caterory",
                    StockQty = 100,
                    UnitPrice = "bag"
                }
            );
        }
    }
}
