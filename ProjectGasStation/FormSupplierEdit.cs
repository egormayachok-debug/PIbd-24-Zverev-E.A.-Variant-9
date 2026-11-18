using System;
using System.Windows.Forms;
using ProjectGasStation.Entities;

namespace ProjectGasStation
{
    public partial class FormSupplierEdit : Form
    {
        public Supplier? Supplier { get; private set; }

        public FormSupplierEdit()
        {
            InitializeComponent();
        }

        public FormSupplierEdit(Supplier supplier) : this()
        {
            Supplier = supplier;
            textBoxName.Text = supplier.Name;
            textBoxAddress.Text = supplier.Address;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Пожалуйста, введите название поставщика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Supplier?.Id ?? new Random().Next(1, 1000);

            // Создаем или обновляем сущность через фабричный метод
            Supplier = Supplier.CreateEntity(id, textBoxName.Text.Trim(), textBoxAddress.Text.Trim());

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