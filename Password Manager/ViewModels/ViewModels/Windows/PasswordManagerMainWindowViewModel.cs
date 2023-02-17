#region Dependencies
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace ViewModels.ViewModels.Windows
{
    public class PasswordManagerMainWindowViewModel : ObservableRecipient
    {
        #region Fields
        private Version _version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        #endregion

        #region Properties
        public Version Version 
        { 
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
            }
        }
        #endregion

        #region Constructor
        public PasswordManagerMainWindowViewModel() 
        {

        }
        #endregion
    }
}
