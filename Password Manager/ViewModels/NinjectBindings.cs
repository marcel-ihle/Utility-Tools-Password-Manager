using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.ViewModels.Windows;

namespace ViewModels
{
    public class NinjectBindings
    {
        #region Fields
        private IKernel _kernel = GlobalClasses.NinjectHub.Kernel;
        #endregion

        #region Constructor
        public NinjectBindings() 
        { 
            _kernel.Bind<PasswordManagerMainWindowViewModel>().To<PasswordManagerMainWindowViewModel>().InSingletonScope();        
        }
        #endregion
    }
}
