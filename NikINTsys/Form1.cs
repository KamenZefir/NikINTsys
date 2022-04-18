using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NikINTsys
{
    public partial class Form1 : Form
    {
        int RockOil = 0;
        int Equit = 0;
        int[,] Choice = new int[3, 3];
        public Form1()
        {

            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Choice[i, j] = -1;



        }

        private bool button1WasClicked = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random(Environment.TickCount);
            RockOil = rnd.Next(3);
            Equit   = rnd.Next(3);

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            switch (RockOil)
            {
                case 0:
                    label3.ForeColor = Color.Red;
                    label3.Text = "Падает";
                    break;

                case 1:
                    label3.ForeColor = Color.Blue;
                    label3.Text = "Стабильна";
                    break;

                case 2:
                    label3.ForeColor = Color.Green;
                    label3.Text = "Растёт";
                    break;
            }

            switch (Equit)
            {
                case 0:
                    label4.ForeColor = Color.Red;
                    label4.Text = "Падают";
                    break;

                case 1:
                    label4.ForeColor = Color.Blue;
                    label4.Text = "Стабильны";
                    break;

                case 2:
                    label4.ForeColor = Color.Green;
                    label4.Text = "Растут";
                    break;
            }

            if (button1WasClicked == true)
                if (Choice[RockOil, Equit] == -1)
                {
                    timer1.Enabled = false;
                    label5.Text = "Я не знаю что делать\nВыберите действие";
                }

            if (Choice[RockOil, Equit] == 0)
            {
                radioButton1.Checked = true;
            }

            if (Choice[RockOil, Equit] == 1)
            {
                radioButton2.Checked = true;
            }

            if (Choice[RockOil, Equit] == 2)
            {
                radioButton3.Checked = true;
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Choice[RockOil, Equit] = 0;
                timer1.Enabled = true;
                label5.Text = "";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Choice[RockOil, Equit] = 1;
                timer1.Enabled = true;
                label5.Text = "";
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Choice[RockOil, Equit] = 2;
                timer1.Enabled = true;
                label5.Text = "";
            }
        }
    }
}
