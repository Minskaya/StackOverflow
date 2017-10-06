using Common;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramModule.ViewModels
{
    public class ProgramsViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;

        public ProgramsViewModel(IRegionManager regionaManager)
        {
            this.regionManager = regionaManager;
            this.Title = "ProgramsViewModel " + GetHashCode();
            this.NavigateCommand = new DelegateCommand(NavigateExecute);
        }

        public DelegateCommand NavigateCommand { get; private set; }
        public string Title { get; private set; }

        private void NavigateExecute()
        {
            this.regionManager.RequestNavigate(
                RegionNames.ProgramContent,
                typeof(EditProgramViewModel).Name);
        }
    }
}