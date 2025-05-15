using System;

namespace trading_calculator
{
    public partial class Default : System.Web.UI.Page
    {
        private bool isProfitMode
        {
            get
            {
                object o = ViewState["isProfitMode"];
                return (o == null) ? false : (bool)o;
            }
            set
            {
                ViewState["isProfitMode"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SetMode(false); // default mode: Target Price & Difference
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal a = decimal.Parse(txtPrice.Text);
                decimal b = decimal.Parse(txtProfit.Text);
                decimal c, d;

                if (!isProfitMode)
                {
                    // Calculation for Target Price and Difference
                    c = ((b * a) / 100) + a;
                    d = c - a;
                    txtTarget.Text = c.ToString("0.##");
                    txtDifference.Text = d.ToString("0.##");
                }
                else
                {
                    // Calculation for Percent Profit
                    c = ((b - a) / a) * 100;
                    txtTarget.Text = c.ToString("0.##");
                    txtDifference.Text = "N/A";
                }
            }
            catch
            {
                txtTarget.Text = "Invalid Input";
                txtDifference.Text = "Invalid Input";
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtPrice.Text = txtProfit.Text = txtTarget.Text = txtDifference.Text = string.Empty;
        }

        protected void btnSwitch_Click(object sender, EventArgs e)
        {
            isProfitMode = !isProfitMode;
            SetMode(isProfitMode);
            btnReset_Click(null, null);  // Clear inputs on switch
        }

        private void SetMode(bool profitMode)
        {
            if (profitMode)
            {
                lblTitle.Text = "Calculating Percent Profit";
                lbl1.Text = "Current Price:";
                lbl2.Text = "Target Price:";
                lbl3.Text = "Profit Percent:";
                txtTarget.ReadOnly = true;
                txtDifference.ReadOnly = true;
                btnSwitch.Text = "Switch to Target Price";
            }
            else
            {
                lblTitle.Text = "Calculating Target Price and Difference";
                lbl1.Text = "Current Price:";
                lbl2.Text = "Percent Profit:";
                lbl3.Text = "Target Price:";
                lbl4.Text = "Difference:";
                txtTarget.ReadOnly = true;
                txtDifference.ReadOnly = true;
                btnSwitch.Text = "Switch to Percent Profit";
            }
        }
    }
}
