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
        private static int segundos = 0;
        private bool executando = false;
        private static System.Windows.Forms.Timer ?productionTimer;
        public Form1()
        {
            productionTimer = new System.Windows.Forms.Timer();
            productionTimer.Interval = 1000; // 1000ms = 1 segundo
            productionTimer.Tick += Timer_Tick;
            InitializeComponent();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            segundos++;
            AtualizarLabel();
        }

        private void AtualizarLabel()
        {

            ControlsActions.lblTimerProduction.Text = segundos.ToString() + " s";
        }

        private void SendInfoButton_Click(object sender, EventArgs e)
        {
        }
        public static void OrdersTile_Click(object sender, EventArgs e) // SE DER ERRO TIRAR O STATIC
        {
            productionTimer.Start();
            ControlsActions.ShowSelectedTileInfo(sender, segundos);
        }

        public static void BtnAddControls_Click(object sender, EventArgs e)
        {
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ControlsActions.SendInfoForButton(displayTilesPnlLayout, backPanel, SearchTxtBox.Text.ToString());
        }
    }
}


