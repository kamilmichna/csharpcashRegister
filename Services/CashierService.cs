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
        public String currentResult = "";
        public Boolean commaPlaced = false;
        public static CashierService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CashierService();
            }
            return _instance;
        }

        public void SetResult(String result)
        {
            // Do some validation here
            this.currentResult = result;
        }

        public String SubmitResult()
        {
            String _currentResult = this.currentResult;
            this.currentResult = "";
            this.commaPlaced = false;
            return _currentResult;
        }
        public void AddToResult(String code, Boolean isNumericValue)
        {
            if (isNumericValue)
            {
                this.SetResult(currentResult + code);
            }
            else
            {
                switch (code)
                {
                    case "back":
                        SetResult(currentResult.Remove(currentResult.Length - 1));
                        break;
                    case "clear":
                        // TODO: add FILO queue to handle history and back buttons
                        SetResult("");
                        break;
                    case "comma":
                        if (currentResult.Length > 0 && currentResult[currentResult.Length-1] != '.' && !commaPlaced)
                        {
                            SetResult(currentResult + ".");
                            commaPlaced = true;
                        }
                        break;
                }
            }
        }

    }
}
