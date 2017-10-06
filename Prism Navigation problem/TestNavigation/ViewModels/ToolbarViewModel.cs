using Common;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNavigation.ViewModels
{
    public class ToolbarViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;

        public ToolbarViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;

            this.SwitchCommand = new DelegateCommand<string>(this.SwitchExecute);
        }

        public DelegateCommand<string> SwitchCommand { get; private set; }

        private void SwitchExecute(string target)
        {
            this.regionManager.RequestNavigate(
                RegionNames.Body,
                target);
        }
    }
}