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
    public class EditProgramViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;

        public EditProgramViewModel(IRegionManager regionaManager)
        {
            this.regionManager = regionaManager;

            this.Title = "EditProgramViewModel " + GetHashCode();
            this.NavigateCommand = new DelegateCommand(NavigateExecute);
        }

        public DelegateCommand NavigateCommand { get; private set; }
        public string Title { get; private set; }

        private void NavigateExecute()
        {
            this.regionManager.RequestNavigate(
                RegionNames.ProgramContent,
                typeof(ProgramsViewModel).Name);
        }
    }
}