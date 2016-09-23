using Microsoft.Practices.Unity;
using Prism.Unity;
using FirstModuleExample.Views;
using System.Windows;

namespace FirstModuleExample
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            System.Type module = typeof(ModuleA.ModuleAModule);
            ModuleCatalog.AddModule(
            new Prism.Modularity.ModuleInfo()
            {
                ModuleName = module.Name,
                ModuleType = module.AssemblyQualifiedName,
            });
        }
    }
}
