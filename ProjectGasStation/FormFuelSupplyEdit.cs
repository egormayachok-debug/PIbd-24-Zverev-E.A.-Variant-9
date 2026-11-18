using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectGasStation.Entities;

namespace ProjectGasStation
{
    public partial class FormFuelSupplyEdit : Form
    {
        public FuelSupply? FuelSupply { get; private set; }

        private readonly IFuelRepository _fuelRepository;
        private readonly ISupplierRepository _supplierRepository;

        public FormFuelSupplyEdit(IFuelRepository fuelRepository, ISupplierRepository supplierRepository)
        {
            InitializeComponent();
            _fuelRepository = fuelRepository;
            _supplierRepository = supplierRepository;

            comboBoxSuppliers.DataSource = _supplierRepository.ReadSuppliers();
            comboBoxSuppliers.DisplayMember = "Name";
            comboBoxSuppliers.ValueMember = "Id";

            comboBoxFuels.DataSource = _fuelRepository.ReadFuels();
            comboBoxFuels.DisplayMember = "Name";
            comboBoxFuels.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxLiters.Text, out int count) || count <= 0)
            {
                MessageBox.Show("Введите корректное количество.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedSupplier = comboBoxSuppliers.SelectedItem as Supplier;
            var selectedFuel = comboBoxFuels.SelectedItem as Fuel;

            if (selectedSupplier == null || selectedFuel == null)
            {
                MessageBox.Show("Выберите поставщика и топливо.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = new Random().Next(1, 1000);
            int itemId = new Random().Next(1, 1000);

            var item = FuelSupplyItem.CreateElement(
                itemId,
                selectedFuel.Id,
                count,
                selectedFuel.Price
            );

            var itemsList = new List<FuelSupplyItem> { item };

            FuelSupply = FuelSupply.CreateOperation(id, selectedSupplier.Id, itemsList);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}