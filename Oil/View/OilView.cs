using Oil.Model;
using Oil.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oil
{
    public partial class OilView : Form, IMainView
    {
        public OilView()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> SelectionChange { get; set; }
        public EventHandler<EventArgs> LoadMain { get; set; }
        public EventHandler<EventArgs> MoneyChange { get; set; }
        public EventHandler<EventArgs> LiterChange { get; set; }

        public OilClass SelectedOil
        {
            get
            {
                return oilCombobox.SelectedItem as OilClass;
            }
        }

        public List<OilClass> Oils
        {
            set
            {
                oilCombobox.DataSource = null;
                oilCombobox.DataSource = value;
            }
        }
        public string PriceText { get => priceLbl.Text; set => priceLbl.Text = value; }
        public string MoneyText { get => moneyTxtb.Text; set => moneyTxtb.Text = value; }
        public string LiterText { get => literTxtb.Text; set => literTxtb.Text = value; }
        public string TotalAmountText { get => amountLbl.Text; set => amountLbl.Text = value; }

        public bool Money { get; set; } = false;
        public bool Liter { get; set; } = false;

        private void oilCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionChange.Invoke(sender, e);
        }

        private void moneyTxtb_TextChanged(object sender, EventArgs e)
        {
            MoneyChange.Invoke(sender, e);
        }

        private void priceLbl_TextChanged(object sender, EventArgs e)
        {
            LiterChange.Invoke(sender, e);
        }

        private void literTxtb_TextChanged(object sender, EventArgs e)
        {
            LiterChange.Invoke(sender, e);
        }

        private void moneyRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!Money)
            {
                moneyTxtb.Enabled = true;
            }
            else
            {
                moneyTxtb.Enabled = false;
            }
            Money = !Money;
        }

        private void literRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!Liter)
            {
                literTxtb.Enabled = true;
            }
            else
            {
                literTxtb.Enabled = false;
            }
            Liter = !Liter;
        }
    }
}
