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
        private static int buildCounterClkedBtn = 0 ;
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
            MessageBox.Show($"{ControlsActions.counterForBuildTimer}");
        }
        public static void OrdersTile_Click(object sender, EventArgs e) // SE DER ERRO TIRAR O STATIC
        {
            ControlsActions.ReStartTimer();
            productionTimer.Start();
            ControlsActions.ShowSelectedTileInfo(sender);
        }
        
        public static void BtnBuildProduction_Click(object sender, EventArgs e)
        {
            if(buildCounterClkedBtn.Equals(0))
            {
                ControlsActions.buildTimer = new System.Windows.Forms.Timer();
                ControlsActions.buildTimer.Interval = 1000;
                ControlsActions.buildTimer.Tick += BuildTimer_Tick;
                ControlsActions.buildTimer.Start();
            }
            else
            {
                ControlsActions.counterForBuildTimer = 0;
            }
            
        }
        //TEST FOR build TIMER 
        private static void BuildTimer_Tick(object sender, EventArgs e)
        {
            ControlsActions.counterForBuildTimer++;
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            ControlsActions.SendInfoForButton(displayTilesPnlLayout, backPanel, SearchTxtBox.Text.ToString());
        }
    }
}


