namespace SequorTest.Tile_User_Control
{
    public partial class OrdersTile : UserControl
    {
        public Label lblMaterialCode;
        public Label lblMaterialName;
        public Label lblDescription;
        public Label lblTime;
        public Label lblCount;

        private Random random = new Random();

        public Color GenerateColor()
        {
            return Color.AliceBlue;
        }

        public OrdersTile()
        {
            InitializeComponent();
            this.Size = new Size(300, 100);
            this.BackColor = GenerateColor();
            this.BorderStyle = BorderStyle.FixedSingle;

            // code label
            lblMaterialCode = new Label()
            {
                Text = "1000043675TESTE", //Default
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Location = new Point(10, 8),
                AutoSize = true
            };

            // short material name
            lblMaterialName = new Label()
            {
                Text = "MATERIAL01234TESTE", //Default
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(10, 28),
                AutoSize = true
            };

            // description label
            lblDescription = new Label()
            {
                Text = "Essa é a descrição completa de um material TESTE", //Default
                Font = new Font("Segoe UI", 8, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(10, 48),
                AutoSize = true
            };

            // time label
            lblTime = new Label()
            {
                Text = "00:00:00", //Default
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(10, 70),
                AutoSize = true
            };

            // count label
            lblCount = new Label()
            {
                Text = "0/0", //Default
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Location = new Point(250, 70),
                AutoSize = true
            };

            this.SetControlProperties();
        }

        public void SetControlProperties()
        {
            this.Controls.Add(lblMaterialCode);
            this.Controls.Add(lblMaterialName);
            this.Controls.Add(lblDescription);
            this.Controls.Add(lblTime);
            this.Controls.Add(lblCount);
        }
    }
}

