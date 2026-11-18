using System;
using System.Windows.Forms;
using ProjectGasStation.Entities;

namespace ProjectGasStation
{
    public partial class FormSuppliers : Form
    {
        private readonly ISupplierRepository _supplierRepository;

        public FormSuppliers(ISupplierRepository supplierRepository)
        {
            InitializeComponent();
            _supplierRepository = supplierRepository;
        }

        private void FormSuppliers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridViewSuppliers.DataSource = null;
            dataGridViewSuppliers.DataSource = _supplierRepository.ReadSuppliers();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var editForm = new FormSupplierEdit();
            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                var newSupplier = editForm.Supplier;
                if (newSupplier != null)
                {
                    _supplierRepository.CreateSupplier(newSupplier);
                    LoadData();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                var selected = dataGridViewSuppliers.SelectedRows[0].DataBoundItem as Supplier;
                if (selected != null)
                {
                    var editForm = new FormSupplierEdit(selected);
                    if (editForm.ShowDialog(this) == DialogResult.OK)
                    {
                        _supplierRepository.UpdateSupplier(editForm.Supplier);
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите поставщика для редактирования!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                var selected = dataGridViewSuppliers.SelectedRows[0].DataBoundItem as Supplier;
                if (selected != null)
                {
                    _supplierRepository.DeleteSupplier(selected.Id);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите поставщика для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}