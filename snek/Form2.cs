using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snek
{
    public partial class Form2 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        int score;

        int maxWidth;
        int maxHeight;

        public Form1 gameForm;
        Random rand = new Random();

        public int X { get; private set; }
        public int Y { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void FalseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            gameForm.PoopFood();
        }

        private void CorrectButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            gameForm.EatFood();
            
        }
    }
}
