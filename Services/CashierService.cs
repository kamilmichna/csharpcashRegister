using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpCashier.Services
{
    internal class CashierService
    {
        private static CashierService _instance;
        public String result = "";

        public static CashierService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CashierService();
            }
            return _instance;
        }

        public void setResult(String result)
        {
            // Do some validation here
            this.result = result;
        }

    }
}
