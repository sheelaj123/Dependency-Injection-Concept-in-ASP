using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class ClientApp
    {
        private IMobileServiceProvider _mobileServiceProvider;
        public ClientApp(IMobileServiceProvider mobileServiceProvider)
        {
            _mobileServiceProvider = mobileServiceProvider;
        }
        public void GetCallrates()
        {
            _mobileServiceProvider.CallRates();
        }
    }
}
