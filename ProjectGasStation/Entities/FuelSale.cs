public class FuelSale
{
    public int Id { get; private set; }
    public int FuelId { get; private set; }
    public int SellerId { get; private set; }
    public DateTime SaleDate { get; private set; }
    public int Count { get; private set; }
    public decimal TotalSum { get; private set; }

    public static FuelSale CreateOperation(int id, int fuelId, int sellerId, int count, decimal totalSum)
    {
        return new FuelSale
        {
            Id = id,
            FuelId = fuelId,
            SellerId = sellerId,
            SaleDate = DateTime.Now,
            Count = count,
            TotalSum = totalSum
        };
    }
}