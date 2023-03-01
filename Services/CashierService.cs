using csharpCashier.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpCashier.Services
{
    internal class CashierService
    {
        private static CashierService? _instance;
        public String currentItem = "";
        public float sum = 0;

        public Boolean commaPlaced = false;
        public List<String> items = new List<string>();
        public static CashierService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CashierService();
            }
            return _instance;
        }


        public bool ValidateResult(String result)
        {
            float intResult;
            bool isParsable = float.TryParse(result, out intResult);

            if (isParsable && result.Length > 0)
            {
                return true;
            }
            return false;
        }

        public void SetResult(String result)
        {
            this.currentItem = result;
            Receipts.CreateReceipt();
        }

        public String Submit()
        {
            String _currentItem = this.currentItem;
            this.commaPlaced = false;
            float currentItemValue = float.Parse(this.currentItem);
            sum += currentItemValue;
            if (items.Count() > 0)
            {
                _currentItem = "+ " + _currentItem;
            }
            items.Add(this.currentItem);
            this.currentItem = "";
            return _currentItem;
        }
        public void AddToResult(String code, Boolean isNumericValue)
        {
            if (isNumericValue)
            {
                this.SetResult(currentItem + code);
            }
            else
            {
                switch (code)
                {
                    case "back":
                        SetResult(currentItem.Remove(currentItem.Length - 1));
                        break;
                    case "clear":
                        // TODO: add FILO queue to handle history and back buttons
                        SetResult("");
                        break;
                    case "comma":
                        if (currentItem.Length > 0 && currentItem[currentItem.Length-1] != '.' && !commaPlaced)
                        {
                            SetResult(currentItem + ",");
                            commaPlaced = true;
                        }
                        break;
                }
            }
        }

    }
}
