using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LN_InventoryApp
{
    public partial class LNInventoryForm : Form
    {
        static int ID = 10000;
        Item item;
        public LNInventoryForm()
        {
            InitializeComponent();
        }

        private void ln_btnCreate_Click(object sender, EventArgs e)
        {
            int quantity;
            bool valid = true;

            if (int.TryParse(ln_txtBxQuantity.Text, out quantity) == false || quantity <= 0)
            {
                ln_lblError.Visible = true;
                ln_lblError.Text = "Quantity must be a positive value!";
                ln_txtBxQuantity.Focus();
                valid = false;
            }

            if (ln_txtBxName.Text == null || ln_txtBxName.Text == "")
            {
                MessageBox.Show("Item name should not be null");
                ln_txtBxName.Focus();
                valid = false;
            }

            if (valid)
            {
                ln_lblError.Text = "";
                ln_lblError.Visible = false;

                string name = ln_txtBxName.Text;
                int number = getItemID();

                item = new Item(name, number, quantity);
                setVisible(item, true);
            }
        }

        private void ln_btnUpdate_Click(object sender, EventArgs e)
        {
            int receivedQuantity;
            int issuedQuantity;

            bool valid = true;

            if (int.TryParse(ln_txtBxReceive.Text, out receivedQuantity) == false || receivedQuantity <= 0)
            {
                MessageBox.Show("Received quantity should be a positive value!");
                ln_txtBxReceive.Focus();
                valid = false;
            }

            if (int.TryParse(ln_txtBxIssue.Text, out issuedQuantity) == false || issuedQuantity <= 0)
            {
                MessageBox.Show("Issued quantity should be a positive value!");
                ln_txtBxIssue.Focus();
                valid = false;
            }

            if (item.ItemQuantity + receivedQuantity - issuedQuantity < 0)
            {
                MessageBox.Show("Issued quantity can not larger than quantity on-hand plus received quantity!");
                valid = false;
            }

            if (valid)
            { 
                item.Receive(receivedQuantity);
                item.Issue(issuedQuantity);

                ln_txtBxReceive.Text = "";
                ln_txtBxIssue.Text = "";
                ln_txtBxQuantity.Text = item.ItemQuantity.ToString("F0");

                ln_txtBxReceive.Focus();
            }
        }

        private void setVisible(Item item, bool visible)
        {
            ln_lblAccountNo.Visible = visible;
            ln_txtBxAccountNo.Visible = visible;
            ln_txtBxAccountNo.Text = item.ItemNumber.ToString();

            ln_lblReceive.Visible = visible;
            ln_txtBxReceive.Visible = visible;

            ln_lblIssue.Visible = visible;
            ln_txtBxIssue.Visible = visible;

            ln_btnCreate.Visible = !visible;
            ln_btnUpdate.Visible = visible;
        }

        private int getItemID()
        {
            ID += 1;
            return ID;
        }
    }
}
