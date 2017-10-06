using Common;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using ProgramModule.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramModule
{
    public class ProgramModule : IModule
    {
        private readonly IUnityContainer container;
        private readonly IRegionManager regionManager;

        public ProgramModule(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            this.regionManager.RegisterViewWithRegion(RegionNames.Body, typeof(ModuleViewModel));
            //this.regionManager.RegisterViewWithRegion(RegionNames.ProgramContent, typeof(ProgramsViewModel));
            //this.regionManager.RegisterViewWithRegion(RegionNames.ProgramContent, typeof(EditProgramViewModel));
            this.regionManager.RegisterViewWithRegion(RegionNames.ProgramContent,
                () => this.container.Resolve<ProgramsViewModel>());
            this.regionManager.RegisterViewWithRegion(RegionNames.ProgramContent,
                    () => this.container.Resolve<EditProgramViewModel>());
        }
    }
}