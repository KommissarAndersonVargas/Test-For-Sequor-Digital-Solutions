using SequorTest.BaseClasses;
using SequorTest.Tile_User_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SequorTest.Controls_Actions
{
    public static class ControlsActions
    {
        public static System.Windows.Forms.Label ?lblProductionOrder;

        public static System.Windows.Forms.Label ?lblMaterialCode;

        public static System.Windows.Forms.Label ?lblMaterialDescription;

        public static System.Windows.Forms.Label? lblTimerProduction;

        public static System.Windows.Forms.Label? lblMutableProductedOrders;

        public static void CreateInterface(Panel backPanel)
        {
            AddsLabelInformation(backPanel);
            AddsOrderPictureBox(backPanel);
            AddsProductionButton(backPanel);
            AddsTimerLabel(backPanel);
            AddsClockPictureBox(backPanel);
            AddsContOrdersProcuedLbl(backPanel);
        }

        private static void AddsLabelInformation(Panel backPanel)
        {
            lblProductionOrder = CreateLabelInfo("");
            lblMaterialCode = CreateLabelInfo("");
            lblMaterialDescription = CreateLabelInfo("");

            lblProductionOrder.Location = new Point(600, 40);
            lblMaterialCode.Location = new Point(600, 80);
            lblMaterialDescription.Location = new Point(600, 120);

            backPanel.Controls.Add(lblProductionOrder);
            backPanel.Controls.Add(lblMaterialCode);
            backPanel.Controls.Add(lblMaterialDescription);
        }

        private static void AddsOrderPictureBox(Panel backPanel)
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
        private static void AddsProductionButton(Panel backPanel)
        {
            Font font = new Font("Segoe UI", 11, FontStyle.Regular);
            Button btnProduction = new Button();
            btnProduction.Name = "OrderPicBox";
            btnProduction.Text = "BUILD";
            btnProduction.Font = font;
            btnProduction.FlatStyle = FlatStyle.Flat;
            btnProduction.FlatAppearance.BorderSize = 2;
            btnProduction.Size = new Size(100, 40);
            btnProduction.Location = new Point(1260, 250);
            btnProduction.Click += Form1.BtnAddControls_Click;

            backPanel.Controls.Add(btnProduction);
        }
        private static void AddsTimerLabel(Panel backPanel)
        {
            lblTimerProduction = CreateLabelInfo("00:00:00");
            lblTimerProduction.Location = new Point(1190, 256);

            backPanel.Controls.Add(lblTimerProduction);
        }
        private static void AddsClockPictureBox(Panel backPanel)
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
        private static void AddsContOrdersProcuedLbl(Panel backPanel)
        {
            lblMutableProductedOrders = CreateLabelInfo("0/0");
            lblMutableProductedOrders.Location = new Point(1315, 300);

            backPanel.Controls.Add(lblMutableProductedOrders);
        }
        public static void SendInfoForButton(FlowLayoutPanel displayTilesPnlLayout, Panel backPanel)
        {
            displayTilesPnlLayout.Padding = new Padding(10);
            var tile = new OrdersTile();

            for (int i = 0; i < 3; i++)
            {
                var info = new MaterialInfo()
                {
                    Ordem = $"{tile.MaterialCode}",
                    Codigo = $"{tile.MaterialName}",
                    Descricao = $"{tile.Description}"
                };

                tile.Tag = info;
                tile.Click += Form1.OrdersTile_Click; // SE ERRO TIRAR O STATIC
                displayTilesPnlLayout.Controls.Add(tile); // adds the tile insede of the panel layout
            }

            CreateInterface(backPanel);
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

                lblProductionOrder.Text = $"PRODUCTION ORDER: {info.Ordem}";
                lblMaterialCode.Text = $"MATERIAL CODE: {info.Codigo}";
                lblMaterialDescription.Text = $"MATERIAL DESCRIPTION: {info.Descricao}";
                // CreateInterface(backPanel);
            }
        }
    }
}
