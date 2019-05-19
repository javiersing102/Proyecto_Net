

namespace proyecto_Net.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;
    class LoginViewModel
    {
        #region Properties
        public String Email
        {
            get;
            set;
        }

        public String Password
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        #endregion
        #region Constructors

        public LoginViewModel()
        {
            this.IsRemembered = true;
        }

        #endregion


        #region commands
        public ICommand LoginCommand
        {
            get;
            set;
        }
        public ICommand RegisterCommand
        {
            get;
            set;
        }



        #endregion
    }
}
