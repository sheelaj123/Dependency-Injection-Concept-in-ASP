using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Voda : IMobileServiceProvider
    {
        public void CallRates()
        {
            Console.WriteLine(value: "1 Paisa /sec");
        }
    }
}
