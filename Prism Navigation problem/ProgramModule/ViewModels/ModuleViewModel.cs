using Prism;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramModule.ViewModels
{
    public class ModuleViewModel : BindableBase, IActiveAware
    {
        private bool isActive = false;
        private string tabHeader;

        public ModuleViewModel()
        {
            this.tabHeader = "ModuleView  " + this.GetHashCode();
        }

        public event EventHandler IsActiveChanged;

        public bool IsActive
        {
            get => isActive;
            set
            {
                isActive = value;
                this.RaisePropertyChanged(nameof(TabHeader));
            }
        }

        public string TabHeader
        {
            get
            {
                return this.isActive
                        ? this.tabHeader
                        : "Disabled " + this.tabHeader;
            }
        }
    }
}