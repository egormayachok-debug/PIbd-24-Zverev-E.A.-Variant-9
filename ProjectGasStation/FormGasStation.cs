using System;
using System.Windows.Forms;
using ProjectGasStation.Entities;

namespace ProjectGasStation
{
    public partial class FormGasStation : Form
    {
        private readonly IFuelRepository _fuelRepository;
        private readonly ISellerRepository _sellerRepository;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IFuelSaleRepository _fuelSaleRepository;
        private readonly IFuelSupplyRepository _fuelSupplyRepository;
        private readonly ISaleRepository _saleRepository;

        // Конструктор, в который Unity автоматически внедрит зависимости
        public FormGasStation(
            IFuelRepository fuelRepository,
            ISellerRepository sellerRepository,
            ISupplierRepository supplierRepository,
            IFuelSaleRepository fuelSaleRepository,
            IFuelSupplyRepository fuelSupplyRepository,
            ISaleRepository saleRepository)
        {
            InitializeComponent();

            _fuelRepository = fuelRepository;
            _sellerRepository = sellerRepository;
            _supplierRepository = supplierRepository;
            _fuelSaleRepository = fuelSaleRepository;
            _fuelSupplyRepository = fuelSupplyRepository;
            _saleRepository = saleRepository;
        }

        private void FormGasStation_Load(object sender, EventArgs e)
        {
            // Здесь в будущем мы настроим открытие дочерних форм или списков
        }

        private void топливоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Передаем репозиторий в конструктор формы списка топлива
            var form = new FormFuels(_fuelRepository);
            form.ShowDialog(this);
        }

        private void продавцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем форму, передавая ей внедренный через Unity репозиторий продавцов
            var form = new FormSellers(_sellerRepository);
            form.ShowDialog(this); // Открываем как модальное окно поверх главного
        }

        private void продажиТопливаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormSales(_saleRepository, _fuelRepository, _sellerRepository);
            form.ShowDialog(this);
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormSuppliers(_supplierRepository);
            form.ShowDialog(this);
        }

        private void поставкиТопливаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormFuelSupplies(_fuelSupplyRepository, _fuelRepository, _supplierRepository);
            form.ShowDialog(this);
        }
    }
}