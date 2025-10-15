using SequorTest.Tile_User_Control;

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
            displayTilesPnlLayout.Padding = new Padding(10);
          
            for (int i = 0; i < 3; i++)
            {
                var tile = new OrdersTile();
                displayTilesPnlLayout.Controls.Add(tile);
            }
        }
    }
}

