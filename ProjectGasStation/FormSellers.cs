using System;
using System.Windows.Forms;


namespace ProjectGasStation
{
    public partial class FormSellers : Form
    {
        private readonly ISellerRepository _sellerRepository;

        public FormSellers(ISellerRepository sellerRepository)
        {
            InitializeComponent();
            _sellerRepository = sellerRepository;
        }

        private void FormSellers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridViewSellers.DataSource = null;
            dataGridViewSellers.DataSource = _sellerRepository.ReadSellers();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var editForm = new FormSellerEdit();
            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                var newSeller = editForm.Seller;
                if (newSeller != null)
                {
                    _sellerRepository.CreateSeller(newSeller);
                    LoadData();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSellers.SelectedRows.Count > 0)
            {
                var selectedSeller = dataGridViewSellers.SelectedRows[0].DataBoundItem as Seller;
                if (selectedSeller != null)
                {
                    var editForm = new FormSellerEdit(selectedSeller);
                    if (editForm.ShowDialog(this) == DialogResult.OK)
                    {
                        _sellerRepository.UpdateSeller(editForm.Seller);
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите продавца для редактирования!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSellers.SelectedRows.Count > 0)
            {
                var selectedSeller = dataGridViewSellers.SelectedRows[0].DataBoundItem as Seller;
                if (selectedSeller != null)
                {
                    var result = MessageBox.Show($"Удалить продавца {selectedSeller.FirstName} {selectedSeller.LastName}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _sellerRepository.DeleteSeller(selectedSeller.Id);
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите продавца для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}