using System;

namespace Mini_Order_System
{
    public class OrderEventArgs : EventArgs
    {
        public string ProductName { get; }
        public int ProductQuantity { get; }
        public decimal UnitPrice { get; }
        public decimal Totalprice { get; }
        public DateTime Timestamp { get; }

        public OrderEventArgs(string ProductName, int ProductQuantity, decimal UnitPrice, decimal TotalPrice)
        {
            this.ProductName = ProductName;
            this.ProductQuantity = ProductQuantity;
            this.UnitPrice = UnitPrice;
            Totalprice = TotalPrice;
            Timestamp = DateTime.Now;
        }


    }
}
