using System;
using System.Windows.Forms;
using ProjectGasStation.Entities;

namespace ProjectGasStation
{
    public partial class FormFuelSupplies : Form
    {
        private readonly IFuelSupplyRepository _fuelSupplyRepository;
        private readonly IFuelRepository _fuelRepository;
        private readonly ISupplierRepository _supplierRepository;

        public FormFuelSupplies(IFuelSupplyRepository fuelSupplyRepository, IFuelRepository fuelRepository, ISupplierRepository supplierRepository)
        {
            InitializeComponent();
            _fuelSupplyRepository = fuelSupplyRepository;
            _fuelRepository = fuelRepository;
            _supplierRepository = supplierRepository;
        }

        private void FormFuelSupplies_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridViewSupplies.DataSource = null;
            // Используем ваш метод из интерфейса (без параметров передаст все поставки)
            dataGridViewSupplies.DataSource = _fuelSupplyRepository.ReadFuelSupplies();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var editForm = new FormFuelSupplyEdit(_fuelRepository, _supplierRepository);
            if (editForm.ShowDialog(this) == DialogResult.OK && editForm.FuelSupply != null)
            {
                // Используем правильный метод создания поставки из вашего интерфейса
                _fuelSupplyRepository.CreateFuelSupply(editForm.FuelSupply);
                LoadData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSupplies.SelectedRows.Count > 0 && dataGridViewSupplies.SelectedRows[0].DataBoundItem is FuelSupply selected)
            {
                // Используем правильный метод удаления по ID из вашего интерфейса
                _fuelSupplyRepository.DeleteFuelSupply(selected.Id);
                LoadData();
            }
            else
            {
                MessageBox.Show("Выберите поставку для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}