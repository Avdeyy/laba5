using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLogic;
using Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba5
{
    public partial class Form1 : Form
    {
        public static bool flag = true;
        Logic logic { get; set; }
        public Form1()
        {
            InitializeComponent();
            logic = new Logic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.flag)
            {
                logic.Addpeople();
                textBox1.AppendText(logic.GetAllP());
                logic.GrowUp();
                Form1.flag = false;
            }
            else
            {
                textBox3.Clear();
                textBox1.AppendText(logic.GetAllP());
                logic.GrowUp();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            logic.FirstV();
            textBox3.AppendText(logic.StayZ());
            textBox3.AppendText(logic.StayF());
            textBox2.Clear();
            textBox2.AppendText(logic.SecondV());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.AppendText(logic.StayF());
            textBox1.AppendText(logic.StayZ());
            logic.GrowUpZ();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.AppendText(logic.StayZ());
            textBox1.AppendText(logic.StayF());
            logic.GrowUpF();
        }
    }
}
