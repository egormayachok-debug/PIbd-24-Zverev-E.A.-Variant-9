using System;
using System.Windows.Forms;


namespace ProjectGasStation
{
    public partial class FormFuels : Form
    {
        private readonly IFuelRepository _fuelRepository;

        public FormFuels(IFuelRepository fuelRepository)
        {
            InitializeComponent();
            _fuelRepository = fuelRepository;
        }

        private void FormFuels_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Обновляем источник данных для DataGridView
            dataGridViewFuels.DataSource = null;
            dataGridViewFuels.DataSource = _fuelRepository.ReadFuels();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Открываем форму редактирования для создания новой записи
            var editForm = new FormFuelEdit();
            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                // Получаем созданный объект из формы редактирования и сохраняем через репозиторий
                var newFuel = editForm.Fuel;
                if (newFuel != null)
                {
                    _fuelRepository.CreateFuel(newFuel);
                    LoadData(); // Перезагружаем таблицу
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка в таблице
            if (dataGridViewFuels.SelectedRows.Count > 0)
            {
                var selectedFuel = dataGridViewFuels.SelectedRows[0].DataBoundItem as Fuel;
                if (selectedFuel != null)
                {
                    var editForm = new FormFuelEdit(selectedFuel);
                    if (editForm.ShowDialog(this) == DialogResult.OK)
                    {
                        _fuelRepository.UpdateFuel(editForm.Fuel);
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuels.SelectedRows.Count > 0)
            {
                var selectedFuel = dataGridViewFuels.SelectedRows[0].DataBoundItem as Fuel;
                if (selectedFuel != null)
                {
                    var result = MessageBox.Show($"Удалить топливо '{selectedFuel.Name}'?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _fuelRepository.DeleteFuel(selectedFuel.Id);
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}