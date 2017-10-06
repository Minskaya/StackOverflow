using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNavigation.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        public ViewAViewModel()
        {
            this.TabHeader = "View A " + this.GetHashCode();
        }

        public string TabHeader { get; private set; }
    }
}