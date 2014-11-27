using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private double total1 = 0;
        private double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;
        Button btn = new Button();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
            //this.btnOne.Click += new EventHandler(btnOne_Click);
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.C)
            {
                btnAC.Focus();
                btnAC.PerformClick();
            }
            if (e.KeyCode == Keys.D1) {
                btnOne.Focus();
                btnOne.PerformClick();
            }
            if (e.KeyCode == Keys.D2) {
                btnTwo.Focus();
                btnTwo.PerformClick();
            }
            if (e.KeyCode == Keys.D3) {
                btnThree.Focus();
                btnThree.PerformClick();
            }
            if (e.KeyCode == Keys.D4) {
                btnFour.Focus();
                btnFour.PerformClick();
            }
            if (e.KeyCode == Keys.D5) {
                btnFive.Focus();
                btnFive.PerformClick();
            }
            if (e.KeyCode == Keys.D6) {
                btnSix.Focus();
                btnSix.PerformClick();
            }
            if (e.KeyCode == Keys.D7) {
                btnSev.Focus();
                btnSev.PerformClick();
            }
            if (e.KeyCode == Keys.D8) {
                btnEight.Focus();
                btnEight.PerformClick();
            }
            if (e.KeyCode == Keys.D9) {
                btnNine.Focus();
                btnNine.PerformClick();
            }
            if (e.KeyCode == Keys.D0) {
                btnZero.Focus();
                btnZero.PerformClick();
            }
            if (e.KeyCode == Keys.Add) {
                btnPlus.Focus();
                btnPlus.PerformClick();
            }
            if (e.KeyCode == Keys.Back)
            {
                btnDel.Focus();
                btnDel.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnEqu.Focus();
                btnEqu.PerformClick();
            }
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" || display.Text== " ") {
                display.Clear();
            }
            Button btn = (Button)sender;
            display.Text += btn.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btnDot.Text;
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked == true) {
                total2 = total1 + double.Parse(display.Text);
            }
            else if (minusButtonClicked == true) {
                total2 = total1 - double.Parse(display.Text);
            }
            else if (multiplyButtonClicked == true) {
                total2 = total1 * double.Parse(display.Text);
            }
            else if (divideButtonClicked == true)
            {
                total2 = total1 / double.Parse(display.Text);
            }
            else {
                total2 = total1;
            }
            display.Text = total2.ToString();
            //total1 = 0;
        }

        private void btnplmi_Click(object sender, EventArgs e)
        {
            //total1 = total1 + double.Parse(display.Text);
            display.Clear();
            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(display.Text);
            display.Clear();
            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(display.Text);
            display.Clear();
            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;

        }

        private void btnMins_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(display.Text);
            display.Clear();
            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 1)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1, 1);
            }
            else {
                display.Text= "0";
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(display.Text);
            display.Clear();
            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonClicked = false;
        }
        private void btnAC_Click(object sender, EventArgs e)
        {
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
            display.Clear();
            display.Text = "0";
        }

    }
}
