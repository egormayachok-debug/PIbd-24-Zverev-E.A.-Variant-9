using System;
using System.Windows.Forms;
using ProjectGasStation.Entities;

namespace ProjectGasStation
{
    public partial class FormSales : Form
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IFuelRepository _fuelRepository;
        private readonly ISellerRepository _sellerRepository;

        public FormSales(ISaleRepository saleRepository, IFuelRepository fuelRepository, ISellerRepository sellerRepository)
        {
            InitializeComponent();
            _saleRepository = saleRepository;
            _fuelRepository = fuelRepository;
            _sellerRepository = sellerRepository;
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridViewSales.DataSource = null;
            dataGridViewSales.DataSource = _saleRepository.ReadSales();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var editForm = new FormSaleEdit(_fuelRepository, _sellerRepository);
            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                var newSale = editForm.Sale;
                if (newSale != null)
                {
                    _saleRepository.CreateSale(newSale);
                    LoadData();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSales.SelectedRows.Count > 0)
            {
                var selectedSale = dataGridViewSales.SelectedRows[0].DataBoundItem as Sale;
                if (selectedSale != null)
                {
                    _saleRepository.DeleteSale(selectedSale.Id);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите запись о продаже для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}