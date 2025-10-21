using SequorTest.APIs;
using SequorTest.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SequorTest.AdditinalForms
{
    public partial class SetProd : Form
    {
        public SetProd(string email)
        {
            InitializeComponent();
            txbEmail.Text = email;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new ProductionFromAPI();
                double quantity;
                double.TryParse(txbQuantity.Text, out quantity);
                double ciclyTime;
                double.TryParse(txbQuantity.Text, out ciclyTime);

                model.Email = txbEmail.Text;
                model.Order = txbOrder.Text;
                model.ProductionDate = pickerProdDate.Text;
                model.ProductionTime = txtProdTime.Text;
                model.Quantity = quantity;
                model.MaterialCode = txbMaterialCode.Text;
                model.CycleTime = ciclyTime;


                ManagementProctionsAPI.SendProductionSync(model);

                if (ManagementProctionsAPI.IsAPiWorking)
                {
                    txbEmail.Clear();
                    txbOrder.Clear();
                    txtProdTime.Clear();
                    txbQuantity.Clear();
                    txbMaterialCode.Clear();
                    txbCycleTime.Clear();

                    txbEmail.Focus();
                    txbOrder.Focus();
                    txtProdTime.Focus();
                    txbQuantity.Focus();
                    txbMaterialCode.Focus();
                    txbCycleTime.Focus();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
