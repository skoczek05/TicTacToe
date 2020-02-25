using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KolkoKrzyzyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dodawanie akcji do przyciskow w panel2
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Click += new System.EventHandler(btn_click);
                }
            }
        }

        int XorO = 0;
        //tworzenie akcji przycisku
        public void btn_click(object sender, EventArgs e)
        {
            //wyswietlanie X lub O
            Button btn = (Button) sender;
            if (btn.Text.Equals("")) // usune text x przyciskow pozniej
            {
                if (XorO % 2 == 0)
                {
                    btn.Text = "X";
                    btn.ForeColor = Color.Red;
                    label1.Text = "'O' twoja kolej";
                    getTheWinner();
                }
                else
                {
                    btn.Text = "O";
                    btn.ForeColor = Color.Blue;
                    label1.Text = "'X' twoja kolej";
                    getTheWinner();
                }

                XorO++;
            }
        }

        bool win = false;

        public void getTheWinner()
        {
            if (!button1.Text.Equals("") && button1.Text.Equals(button2.Text) && button1.Text.Equals(button3.Text))
            {
                winEffect(button1, button2, button3);
                win = true;
            }
            if (!button4.Text.Equals("") && button4.Text.Equals(button5.Text) && button4.Text.Equals(button6.Text))
            {
                winEffect(button4, button5, button6);
                win = true;
            }
            if (!button7.Text.Equals("") && button7.Text.Equals(button8.Text) && button7.Text.Equals(button9.Text))
            {
                winEffect(button7, button8, button9);
                win = true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button4.Text) && button1.Text.Equals(button7.Text))
            {
                winEffect(button1, button4, button7);
                win = true;
            }
            if (!button2.Text.Equals("") && button2.Text.Equals(button5.Text) && button2.Text.Equals(button8.Text))
            {
                winEffect(button2, button5, button8);
                win = true;
            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button6.Text) && button3.Text.Equals(button9.Text))
            {
                winEffect(button3, button6, button9);
                win = true;
            }
            if (!button1.Text.Equals("") && button1.Text.Equals(button5.Text) && button1.Text.Equals(button9.Text))
            {
                winEffect(button1, button5, button9);
                win = true;
            }
            if (!button3.Text.Equals("") && button3.Text.Equals(button5.Text) && button3.Text.Equals(button7.Text))
            {
                winEffect(button3, button5, button7);
                win = true;
            }

            //jesli nikt nie wygrał
            // jeśli wszystkie przyciski sa zajęte
            //
            if (AllBtnLenght() == 9 && win == false)
            {
                label1.Text = "Brak Zwycięzcy";
            }

        }

        public int AllBtnLenght()
        {
            int allTextButtonsLenght = 0;
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    allTextButtonsLenght += c.Text.Length;
                }
            }

            return allTextButtonsLenght;
        }

        public void winEffect(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.Green;
            b2.BackColor = Color.Green;
            b3.BackColor = Color.Green;

            b1.ForeColor = Color.White;
            b2.ForeColor = Color.White;
            b3.ForeColor = Color.White;

            label1.Text = b1.Text + " Wygrał";


        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            XorO = 0;
            win = false;
            label1.Text = "Graj!";
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                    c.BackColor = Color.White;
                }
            }
        }


    }
}
