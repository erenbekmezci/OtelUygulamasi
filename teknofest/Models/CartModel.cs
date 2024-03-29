﻿namespace teknofest.Models
{
    public class CartModel
    {
        public int CartId { get; set; }
        public List<CartItemModel> CartItems { get; set; }

        public int TotalPrice()
        {
            return CartItems.Sum(i => i.Price * i.Quantity);
        }
    }

    public class CartItemModel
    {
        public int CartItemId { get; set; }
        public int FoodId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
    }
}
