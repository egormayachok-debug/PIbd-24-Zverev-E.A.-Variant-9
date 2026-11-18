using System;
using System.Windows.Forms;
using ProjectGasStation.Entities;

namespace ProjectGasStation
{
    public partial class FormSaleEdit : Form
    {
        public Sale? Sale { get; private set; }

        private readonly IFuelRepository _fuelRepository;
        private readonly ISellerRepository _sellerRepository;

        public FormSaleEdit(IFuelRepository fuelRepository, ISellerRepository sellerRepository)
        {
            InitializeComponent();
            _fuelRepository = fuelRepository;
            _sellerRepository = sellerRepository;

            // Заполняем выпадающие списки данными из репозиториев справочников
            comboBoxFuels.DataSource = _fuelRepository.ReadFuels();
            comboBoxFuels.DisplayMember = "Name";
            comboBoxFuels.ValueMember = "Id";

            comboBoxSellers.DataSource = _sellerRepository.ReadSellers();
            comboBoxSellers.DisplayMember = "LastName";
            comboBoxSellers.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBoxLiters.Text, out decimal liters) || liters <= 0)
            {
                MessageBox.Show("Введите корректное количество литров.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedFuel = comboBoxFuels.SelectedItem as Fuel;
            var selectedSeller = comboBoxSellers.SelectedItem as Seller;

            if (selectedFuel == null || selectedSeller == null)
            {
                MessageBox.Show("Выберите топливо и продавца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalPrice = liters * selectedFuel.Price;
            int id = new Random().Next(1, 1000);

            Sale = Entities.Sale.CreateEntity(id, selectedFuel.Id, selectedSeller.Id, liters, totalPrice, DateTime.Now);

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