using System.Collections.Generic;
using ProjectGasStation.Entities;

namespace ProjectGasStation
{
    public interface ISaleRepository
    {
        IEnumerable<Sale> ReadSales();
        void CreateSale(Sale sale);
        void DeleteSale(int id);
    }

    public class SaleRepository : ISaleRepository
    {
        private readonly List<Sale> _sales = new List<Sale>();

        public IEnumerable<Sale> ReadSales() => _sales;

        public void CreateSale(Sale sale)
        {
            _sales.Add(sale);
        }

        public void DeleteSale(int id)
        {
            var sale = _sales.Find(s => s.Id == id);
            if (sale != null) _sales.Remove(sale);
        }
    }
}