using Abaco.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Abaco.Views;

namespace Abaco.Infrastructure
{
    
   public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
