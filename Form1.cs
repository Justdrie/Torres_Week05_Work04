using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProductForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtbarcode_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void group_Load(object sender, EventArgs e)
        {
            cbcategory.Items.AddRange(new object[]
            {
                "Electronics",
                "Food",
                "Clothing",
                "Household",
                "Other"
            });

            chkactive.Checked = true;
        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbarcode.Text))
            {
                ShowValidationMessage("Barcode is required.", txtbarcode);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                ShowValidationMessage("Name is required.", txtname);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtdescription.Text))
            {
                ShowValidationMessage("Description is required.", txtdescription);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbcategory.Text))
            {
                ShowValidationMessage("Category is required.", cbcategory);
                return;
            }

            if (!rblocal.Checked && !rbabroad.Checked)
            {
                MessageBox.Show("Select an origin.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryParseNonNegative(txtcost.Text, out _))
            {
                ShowValidationMessage("Cost must be a non-negative number.", txtcost);
                return;
            }

            if (!TryParseNonNegative(txtprice.Text, out _))
            {
                ShowValidationMessage("Price must be a non-negative number.", txtprice);
                return;
            }

            if (!TryParseNonNegative(txtmarkup.Text, out _))
            {
                ShowValidationMessage("Markup must be a non-negative number.", txtmarkup);
                return;
            }

            MessageBox.Show("Product saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbarcode.Clear();
            txtname.Clear();
            txtdescription.Clear();
            cbcategory.SelectedIndex = -1;
            cbcategory.Text = string.Empty;
            rblocal.Checked = false;
            rbabroad.Checked = false;
            chkactive.Checked = true;
            txtcost.Clear();
            txtprice.Clear();
            txtmarkup.Clear();
            txtbarcode.Focus();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtcost_TextChanged(object sender, EventArgs e)
        {
            UpdateMarkup();
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            UpdateMarkup();
        }

        private void UpdateMarkup()
        {
            decimal cost;
            decimal price;

            if (TryParseNonNegative(txtcost.Text, out cost) &&
                TryParseNonNegative(txtprice.Text, out price) && cost > 0)
            {
                decimal markup = ((price - cost) / cost) * 100;
                txtmarkup.Text = markup.ToString("0.##", CultureInfo.CurrentCulture);
            }
            else
            {
                txtmarkup.Clear();
            }
        }

        private static bool TryParseNonNegative(string value, out decimal number)
        {
            return decimal.TryParse(value, NumberStyles.Number, CultureInfo.CurrentCulture, out number) && number >= 0;
        }

        private static void ShowValidationMessage(string message, Control control)
        {
            MessageBox.Show(message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private void lbldescription_Click(object sender, EventArgs e)
        {

        }

        private void txtmarkup_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
