using System;

namespace ProjectGasStation.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public int FuelId { get; set; }
        public int SellerId { get; set; }
        public decimal Liters { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }

        // Фабричный метод для создания сущности
        public static Sale CreateEntity(int id, int fuelId, int sellerId, decimal liters, decimal totalPrice, DateTime saleDate)
        {
            return new Sale
            {
                Id = id,
                FuelId = fuelId,
                SellerId = sellerId,
                Liters = liters,
                TotalPrice = totalPrice,
                SaleDate = saleDate
            };
        }
    }
}