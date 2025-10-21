using SequorTest.AdditinalForms;
using SequorTest.APIs;
using SequorTest.BaseClasses;
using SequorTest.Factories;
using SequorTest.Tile_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SequorTest.Controls_Actions
{
    public class ControlsActions
    {
        public static System.Windows.Forms.Label? lblProductionOrder;

        public static System.Windows.Forms.Label? lblMaterialCode;

        public static System.Windows.Forms.Label? lblMaterialDescription;

        public static System.Windows.Forms.Label? lblTimerProduction;

        public static System.Windows.Forms.Label? lblMutableProductedOrders;

        public static bool emailStatus;

        public static string receivedEmail;

        public static double initalTimeFromFile = 0;

        public static double fillingTime = 0; // the last recorded time registered by counterForBuildTime 

        public static int counterSecounds = 0;

        public static string productionRelation;

        public static void CreateProdcutionInterface(Panel backPanel)
        {
            AddsLabelInformation(backPanel);
            AddsOrderPictureBox(backPanel);
            AddsProductionButton(backPanel);
            AddsTimerLabel(backPanel);
            AddsClockPictureBox(backPanel);
            AddsContOrdersProcuedLbl(backPanel);
        }
        public static void UpdateTimerLabel()
        {
            lblTimerProduction.Text = counterSecounds.ToString() + " s";
        }
        public static void GetProducedPieces(object sender)
        {
            if (sender is OrdersTile tile && tile.Tag is MaterialInfo info)
            {
                var lblValue = tile.lblCount.Text.ToString();
                Random random = new Random();
                productionRelation = String.Concat(random.Next(50, 300).ToString(), "/", lblValue);
            }
        }
        public static void SetLblProductionTimeDefaultConfig()
        {
            if (!lblMutableProductedOrders.Text.Equals("0/0"))
            {
                lblMutableProductedOrders.Text = "0/0";
            }
            else
            {
                return;
            }
        }
        private static void AddsLabelInformation(Panel backPanel)
        {
            if (backPanel.Controls.ContainsKey("DesciptionLbl"))
            {
                return;
            }
            else
            {
                lblProductionOrder = CreateLabelInfo("");
                lblProductionOrder.Name = "ProductionOrderLbl";
                lblMaterialCode = CreateLabelInfo("");
                lblMaterialCode.Name = "MaterialCodeLbl";
                lblMaterialDescription = CreateLabelInfo("");
                lblMaterialDescription.Name = "DesciptionLbl";

                lblProductionOrder.Location = new Point(600, 40);
                lblMaterialCode.Location = new Point(600, 80);
                lblMaterialDescription.Location = new Point(600, 120);

                backPanel.Controls.Add(lblProductionOrder);
                backPanel.Controls.Add(lblMaterialCode);
                backPanel.Controls.Add(lblMaterialDescription);
            }
        }
        private static void AddsOrderPictureBox(Panel backPanel)
        {
            if (backPanel.Controls.ContainsKey("OrderPicBox"))
            {
                return;
            }
            else
            {
                PictureBox picBox = new PictureBox();
                picBox.Name = "OrderPicBox";
                picBox.Size = new Size(200, 200);
                picBox.Location = new Point(1160, 40);
                picBox.BorderStyle = BorderStyle.FixedSingle;
                picBox.BackColor = Color.LightGray;
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;

                backPanel.Controls.Add(picBox);
            }
        }
        private static void AddsProductionButton(Panel backPanel)
        {
            if (backPanel.Controls.ContainsKey("btnBuild"))
            {
                return;
            }
            else
            {
                Font font = new Font("Segoe UI", 11, FontStyle.Regular);
                Button btnProduction = new Button();
                btnProduction.Name = "btnBuild";
                btnProduction.Text = "BUILD";
                btnProduction.Font = font;
                btnProduction.FlatStyle = FlatStyle.Flat;
                btnProduction.FlatAppearance.BorderSize = 2;
                btnProduction.Size = new Size(100, 40);
                btnProduction.Location = new Point(1260, 250);
                btnProduction.Click += Form1.BtnBuildProduction_Click;

                backPanel.Controls.Add(btnProduction);
            }
        }
        private static void AddsTimerLabel(Panel backPanel)
        {
            if (backPanel.Controls.ContainsKey("TimerLbl"))
            {
                return;
            }
            else
            {
                lblTimerProduction = CreateLabelInfo("00:00:00");
                lblTimerProduction.Name = "TimerLbl";
                lblTimerProduction.Location = new Point(1190, 256);

                backPanel.Controls.Add(lblTimerProduction);
            }
        }
        private static void AddsClockPictureBox(Panel backPanel)
        {
            if (backPanel.Controls.ContainsKey("ClockPicBox"))
            {
                return;
            }

            else
            {
                PictureBox picBox = new PictureBox();
                picBox.Name = "ClockPicBox";
                picBox.Size = new Size(27, 27);
                picBox.Location = new Point(1160, 252);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.BackColor = Color.White;
                picBox.Image = Properties.Resources.alarm_clock_bell_time;
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;

                backPanel.Controls.Add(picBox);
            }
        }
        private static void AddsContOrdersProcuedLbl(Panel backPanel)
        {
            if (backPanel.Controls.ContainsKey("OrdersQuantiLbl"))
            {
                return;
            }
            else
            {
                lblMutableProductedOrders = CreateLabelInfo("0/0");
                lblMutableProductedOrders.Name = "OrdersQuantiLbl";
                lblMutableProductedOrders.Location = new Point(1305, 300);

                backPanel.Controls.Add(lblMutableProductedOrders);
            }
        }
        public static void SendInfoForButton(FlowLayoutPanel displayTilesPnlLayout, Panel backPanel, string email)
        {
            try
            {
                displayTilesPnlLayout.Padding = new Padding(10);
                SetTilesValuesForForm(Orders.GetOrdersList(), displayTilesPnlLayout);
                CreateProdcutionInterface(backPanel); //Enable the Build Interface
            }
               
            catch(Exception)
            {
                MessageBox.Show("Email null or not authorized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool ValidateEmail(string email)
        {
            if (email.Contains("sequor".ToUpper()) || email.Contains("sequor".ToLower()))
            {
                emailStatus = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        private static async void SetTilesValuesForForm(List<Order> Orders, FlowLayoutPanel displayTilesPnlLayout)
        {
            foreach (var order in Orders)
            {
                var tile = UserControlFactorycs.UserControlFactory();
                tile.lblMaterialCode.Text = String.Concat("Material code: ",order.productCode);
                tile.lblMaterialName.Text = String.Concat("Order: ", order.order);
                tile.lblDescription.Text = String.Concat("Description: ",order.productDescription);
                tile.lblTime.Text = order.cycleTime.ToString();
                tile.lblCount.Text = String.Concat("Count: ", order.quantity.ToString());
                
                var info =BaseClasesFactory.MaterialInfoFactory(
                    $"{tile.lblMaterialName.Text}",
                    $"{tile.lblMaterialCode.Text}", 
                    $"{tile.lblDescription.Text}",
                    $"{tile.lblCount.Text}");
               
                tile.Tag = info;
                tile.Click += Form1.OrdersTile_Click;
                displayTilesPnlLayout.Controls.Add(tile); // adds the tile insede of the panel layout
            }
        }
        private static System.Windows.Forms.Label CreateLabelInfo(string texto)
        {
            return new System.Windows.Forms.Label()
            {
                Text = texto,
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                AutoSize = true,
                ForeColor = Color.Black
            };
        }
        public static void ShowSelectedTileInfo(object sender) // SE DER ERRO TIRAR O STATIC
        {
            if (sender is OrdersTile tile && tile.Tag is MaterialInfo info)
            {
                lblProductionOrder.Text = $"PRODUCTION ORDER: {info.Ordem.Replace("Order: ","")}";
                lblMaterialCode.Text = $"MATERIAL CODE: {info.Name.Replace("Material code: ", "")}";
                lblMaterialDescription.Text = $"MATERIAL DESCRIPTION: {info.Descricao.Replace("Description: ", "")}";
            }
        }
        public static void GetFileProductionTime(object sender)
        {
            if (sender is OrdersTile tile && tile.Tag is MaterialInfo info)
            {
                initalTimeFromFile = double.Parse(tile.lblTime.Text.ToString());
            }
        }
        public static bool BuildProductionTimeFromApp(string email)
        {
            fillingTime = counterSecounds;
            if (fillingTime >= initalTimeFromFile)
            {
                receivedEmail = email;
                SetProd setProd = new SetProd(receivedEmail);
                setProd.Show();
                MessageBox.Show("Cycle Time was sucessfully registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMutableProductedOrders.Text = productionRelation.Replace("Count: ", "");
                return true;
            }
            else
            {
                MessageBox.Show("Production Time Invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static void SetToUpdateTimerLabel()
        {
            lblTimerProduction.Text = String.Concat(counterSecounds.ToString(), " s");
        }
        public static void ReStartTimer()
        {
            if (counterSecounds > 0)
            {
                counterSecounds = 0;
            }
            else
            {
                return;
            }
        }
        public static void CalculateProductionTime(System.Windows.Forms.Timer productionTimer, string email)
        {
            if (BuildProductionTimeFromApp(email))
            {
                ReStartTimer();
                productionTimer.Stop();
            }
        }
    }
}
