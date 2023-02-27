using csharpCashier.Services;

namespace csharpCashier
{
    public partial class MainForm : Form
    {
        CashierService cashierService = CashierService.GetInstance();
        public MainForm()
        {
            InitializeComponent();
        }


        private void addNumberToResult(String code, Boolean isNumericValue)
        {
            if (isNumericValue)
            {
                cashierService.setResult(cashierService.result + code);
            }
            else
            {
                switch (code)
                {
                    case "back":
                        cashierService.setResult(cashierService.result.Remove(cashierService.result.Length - 1));
                        break;
                    case "clear":
                        // TODO: add FILO queue to handle history and back buttons
                        cashierService.setResult("");
                        break;
                }
            }

            this.resultBox.Text = cashierService.result;
        }

        private void click1(object sender, EventArgs e)
        {
            this.addNumberToResult("1", true);
        }
        private void click2(object sender, EventArgs e)
        {
            this.addNumberToResult("2", true);
        }
        private void click3(object sender, EventArgs e)
        {
            this.addNumberToResult("3", true);
        }
        private void click4(object sender, EventArgs e)
        {
            this.addNumberToResult("4", true);
        }
        private void click5(object sender, EventArgs e)
        {
            this.addNumberToResult("5", true);
        }
        private void click6(object sender, EventArgs e)
        {
            this.addNumberToResult("6", true);
        }
        private void click7(object sender, EventArgs e)
        {
            this.addNumberToResult("7", true);
        }
        private void click8(object sender, EventArgs e)
        {
            this.addNumberToResult("8", true);
        }
        private void click9(object sender, EventArgs e)
        {
            this.addNumberToResult("9", true);
        }
        private void click0(object sender, EventArgs e)
        {
            this.addNumberToResult("0", true);
        }
        private void clickBack(object sender, EventArgs e)
        {
            this.addNumberToResult("back", false);
        }
        private void clickClear(object sender, EventArgs e)
        {
            this.addNumberToResult("clear", false);
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }
    }
}