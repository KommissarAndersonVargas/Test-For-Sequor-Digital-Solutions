using MetroFramework.Controls;
using SequorTest.APIs;
using SequorTest.BaseClasses;
using SequorTest.Controls_Actions;
using SequorTest.Tile_User_Control;
using static MetroFramework.Drawing.MetroPaint.ForeColor;

namespace SequorTest
{ 
    public partial class Form1 : Form
    {
        private static System.Windows.Forms.Timer ?productionTimer;

        public Form1()
        {
            productionTimer = new System.Windows.Forms.Timer();
            productionTimer.Interval = 1000; 
            productionTimer.Tick += Timer_Tick;
            InitializeComponent();
        }
        private static void Timer_Tick(object sender, EventArgs e)
        {
            ControlsActions.counterSecounds++;
            ControlsActions.UpdateTimerLabel();
        }

        private void SendInfoButton_Click(object sender, EventArgs e)
        {
            ControlsActions.CalculateProductionTime(productionTimer, SearchTxtBox.Text.ToString());
        }
        public static void OrdersTile_Click(object sender, EventArgs e) // SE DER ERRO TIRAR O STATIC
        {
            ControlsActions.ShowSelectedTileInfo(sender);
            ControlsActions.GetFileProductionTime(sender);
            ControlsActions.GetProducedPieces(sender);
            ControlsActions.SetLblProductionTimeDefaultConfig();
        }
        
        public static void BtnBuildProduction_Click(object sender, EventArgs e)
        {
            productionTimer.Start();
            ControlsActions.SetToUpdateTimerLabel();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ControlsActions.SendInfoForButton(displayTilesPnlLayout, backPanel, SearchTxtBox.Text.ToString());
        }
    }
}


