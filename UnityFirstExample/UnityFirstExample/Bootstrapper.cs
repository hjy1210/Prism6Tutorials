using Microsoft.Practices.Unity;
using Prism.Unity;
using UnityFirstExample.Views;
using System.Windows;

namespace UnityFirstExample
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
    }
}
