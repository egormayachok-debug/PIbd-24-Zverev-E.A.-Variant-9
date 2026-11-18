
public interface IFuelSaleRepository
{
    IEnumerable<FuelSale> ReadFuelSales(DateTime? dateFrom = null, DateTime? dateTo = null, int? fuelId = null, int? sellerId = null);
    void CreateFuelSale(FuelSale fuelSale);
}