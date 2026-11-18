using System;
using System.Windows.Forms;


namespace ProjectGasStation
{
    public partial class FormSellerEdit : Form
    {
        // Делаем свойство допускающим значение null (добавили знак ?)
        public Seller? Seller { get; private set; }

        public FormSellerEdit()
        {
            InitializeComponent();
            comboBoxSellerPost.DataSource = Enum.GetValues(typeof(SellerPost));
        }

        public FormSellerEdit(Seller seller) : this()
        {
            Seller = seller;
            textBoxFirstName.Text = seller.FirstName;
            textBoxLastName.Text = seller.LastName;
            comboBoxSellerPost.SelectedItem = seller.SellerPost;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) || string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("Пожалуйста, заполните имя и фамилию продавца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SellerPost post = (SellerPost)comboBoxSellerPost.SelectedItem;
            int id = Seller?.Id ?? new Random().Next(1, 1000);

            Seller = Seller.CreateEntity(id, textBoxFirstName.Text.Trim(), textBoxLastName.Text.Trim(), post);

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