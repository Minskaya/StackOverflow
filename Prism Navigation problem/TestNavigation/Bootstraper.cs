using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using System.Windows;
using Prism.Modularity;
using Prism.Regions;
using Common;
using TestNavigation.ViewModels;

namespace TestNavigation
{
    public class Bootstraper : UnityBootstrapper
    {
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            this.Container.RegisterType<Shell>();
        }

        /// <summary>
        /// Configure le Prism.Modularity.IModuleCatalog de Prism.
        /// </summary>
        protected override IModuleCatalog CreateModuleCatalog()
        {
            ModuleCatalog catalog = new ModuleCatalog();
            catalog.AddModule(typeof(ProgramModule.ProgramModule));
            return catalog;
        }

        protected override DependencyObject CreateShell()
        {
            return this.Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            var regionManager = this.Container.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.Toolbar, typeof(ToolbarViewModel));
            regionManager.RegisterViewWithRegion(RegionNames.Body, typeof(ViewAViewModel));

            Application.Current.MainWindow = (Shell)this.Shell; ;
            Application.Current.MainWindow.Show();
        }
    }
}