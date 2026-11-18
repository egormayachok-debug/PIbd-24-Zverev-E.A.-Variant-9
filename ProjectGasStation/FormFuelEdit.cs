using System;
using System.Windows.Forms;


namespace ProjectGasStation
{
    public partial class FormFuelEdit : Form
    {
        public Fuel Fuel { get; private set; }

        // Конструктор для добавления нового топлива
        public FormFuelEdit()
        {
            InitializeComponent();
            // Заполняем ComboBox значениями из нашего перечисления FuelType
            comboBoxFuelType.DataSource = Enum.GetValues(typeof(FuelType));
        }

        // Конструктор для редактирования существующего топлива
        public FormFuelEdit(Fuel fuel) : this()
        {
            Fuel = fuel;
            // Заполняем поля текущими значениями
            textBoxName.Text = fuel.Name;
            textBoxPrice.Text = fuel.Price.ToString();
            textBoxDescription.Text = fuel.Description;
            comboBoxFuelType.SelectedItem = fuel.FuelType;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Простейшая валидация введенных данных
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || !decimal.TryParse(textBoxPrice.Text, out decimal price))
            {
                MessageBox.Show("Пожалуйста, проверьте правильность заполнения полей (цена должна быть числом).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FuelType fuelType = (FuelType)comboBoxFuelType.SelectedItem;
            int id = Fuel?.Id ?? new Random().Next(1, 1000); // Временная генерация ID для заглушки

            // Создаем сущность с помощью фабричного метода CreateEntity
            Fuel = Fuel.CreateEntity(id, fuelType, textBoxName.Text.Trim(), price, textBoxDescription.Text.Trim());

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