using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label.Text = $"X {e.Location.X}  Y {e.Location.Y}";
            label.ForeColor = Color.Chocolate;
            label.Font = new Font("Comic Sans MS", e.Location.X / 15, FontStyle.Italic);
            Control control = new Button();
            control.Location = e.Location;
            control.Width = 100;
            control.Height = 100;
            control.Text = "Hakuna";
            control.Click += Control_Click;
            control.Location = e.Location;
            control.Size = new Size(100, 100);
            this.Controls.Add(control);
        }
        private void Control_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Dispose();
        }
    }
}
