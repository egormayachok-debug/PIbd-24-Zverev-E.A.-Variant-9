using ProjectGasStation;
using Unity;
using Unity.Lifetime;

internal static class Program
{
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main()
    {
        
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(CreateContainer().Resolve<FormGasStation>());
    }

    private static IUnityContainer CreateContainer()
    {
        var container = new UnityContainer();

        // Регистрируем зависимости (интерфейс -> класс-реализация) с Transient-временем жизни
        container.RegisterType<IFuelRepository, FuelRepository>(new TransientLifetimeManager());
        container.RegisterType<ISellerRepository, SellerRepository>(new TransientLifetimeManager());
        container.RegisterType<ISupplierRepository, SupplierRepository>(new TransientLifetimeManager());
        container.RegisterType<IFuelSaleRepository, FuelSaleRepository>(new TransientLifetimeManager());
        container.RegisterType<IFuelSupplyRepository, FuelSupplyRepository>(new TransientLifetimeManager());
        container.RegisterType<ISaleRepository, SaleRepository>(new ContainerControlledLifetimeManager());
        return container;
    }


}