﻿namespace WebShopApp.Models.Order
{
    public class OrderIndexVM
    {
        public int Id { get; set; }
        public string OrderDate { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string User {  get; set; } = null!;
        public int ProductId { get; set; }
        public string Product { get; set; } = null!;
        public string Picture { get; set; } = null!;

        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
