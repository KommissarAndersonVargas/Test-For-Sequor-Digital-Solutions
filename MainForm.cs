using MetroFramework.Controls;
using SequorTest.BaseClasses;
using SequorTest.Controls_Actions;
using SequorTest.Tile_User_Control;
using static MetroFramework.Drawing.MetroPaint.ForeColor;

namespace SequorTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void SendInfoButton_Click(object sender, EventArgs e)
        {
            /*
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

                displayTilesPnlLayout.Controls.Add(tile); // adds the tile insede of the panel layout
            }
           
            tile.Click += OrdersTile_Click; // Defines a method when the tile is clicked
            CreateInterface(backPanel);
            */

            ControlsActions.SendInfoForButton(displayTilesPnlLayout, backPanel);

        }
        public static void OrdersTile_Click(object sender, EventArgs e) // SE DER ERRO TIRAR O STATIC
        {
            /*
            if (sender is OrdersTile tile && tile.Tag is MaterialInfo info)
            {
           
                lblProductionOrder.Text = $"PRODUCTION ORDER: {info.Ordem}";
                lblMaterialCode.Text = $"MATERIAL CODE: {info.Codigo}";
                lblMaterialDescription.Text = $"MATERIAL DESCRIPTION: {info.Descricao}";
               // CreateInterface(backPanel);
            */

            ControlsActions.ShowSelectedTileInfo(sender);
        }

        public static void BtnAddControls_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("This is a test");
        }
    }
}


