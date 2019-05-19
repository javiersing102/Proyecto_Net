using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_Net.Infrastructure
{
    using ViewModels;
    class InstanceLocator
    {
        #region properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion
        #region constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
