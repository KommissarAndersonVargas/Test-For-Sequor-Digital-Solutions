using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SequorTest.Tile_User_Control
{
    public partial class OrdersTile : UserControl
    {
        Label lblMaterialCode;
        Label lblMaterialName;
        Label lblDescription;
        Label lblTime;
        Label lblCount;
        public string MaterialCode => lblMaterialCode.Text;
        public string MaterialName => lblMaterialName.Text;
        public string Description => lblDescription.Text;
        public string Time => lblTime.Text;
        public string Count => lblCount.Text;

        private Random random = new Random();

        public Color GenerateRandomColor()
        {
            int r = random.Next(80, 255);
            int g = random.Next(150, 256);
            int b = random.Next(150, 255);

            return Color.FromArgb(r, g, b);
        }

        public OrdersTile()
        {
            InitializeComponent();
            this.Size = new Size(300, 100);
            this.BackColor = GenerateRandomColor();
            this.BorderStyle = BorderStyle.FixedSingle;

            // code label
            lblMaterialCode = new Label()
            {
                Text = String.Concat("1000043675", random.Next(101).ToString()),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Location = new Point(10, 8),
                AutoSize = true
            };

            // short material name
            lblMaterialName = new Label()
            {
                Text = "MATERIAL01234",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(10, 28),
                AutoSize = true
            };

            // description label
            lblDescription = new Label()
            {
                Text = "Essa é a descrição completa de um material",
                Font = new Font("Segoe UI", 8, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(10, 48),
                AutoSize = true
            };

            // time label
            lblTime = new Label()
            {
                Text = "00:00:50",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(10, 70),
                AutoSize = true
            };

            // count label
            lblCount = new Label()
            {
                Text = "0/10",
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

