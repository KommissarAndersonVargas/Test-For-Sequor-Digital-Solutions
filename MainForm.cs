using SequorTest.Tile_User_Control;

namespace SequorTest
{
    public partial class Form1 : Form
    {
        private Label lblProductionOrder;
        private Label lblMaterialCode;
        private Label lblMaterialDescription;
        public Form1()
        {
            InitializeComponent();
            //CreateInterface();
        }
        private void CreateInterface()
        {
            lblProductionOrder = CreateLabelInfo("PRODUCTION ORDER:");
            lblMaterialCode = CreateLabelInfo("MATERIAL CODE:");
            lblMaterialDescription = CreateLabelInfo("MATERIAL DESCRIPTION:");

            lblProductionOrder.Location = new Point(600, 40);
            lblMaterialCode.Location = new Point(600, 80);
            lblMaterialDescription.Location = new Point(600, 120);

            backPanel.Controls.Add(lblProductionOrder);
            backPanel.Controls.Add(lblMaterialCode);
            backPanel.Controls.Add(lblMaterialDescription);
        }

        private Label CreateLabelInfo(string texto)
        {
            return new Label()
            {
                Text = texto,
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                AutoSize = true,
                ForeColor = Color.Black
            };
        }
        private void SendInfoButton_Click(object sender, EventArgs e)
        {
            displayTilesPnlLayout.Padding = new Padding(10);
          
            for (int i = 0; i < 3; i++)
            {
                var tile = new OrdersTile();
                displayTilesPnlLayout.Controls.Add(tile);
            }

            this.CreateInterface();
        }
    }
}

