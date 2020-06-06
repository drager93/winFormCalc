using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorExample_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 생성자
            init();
        }

        public bool opFlag = false;
        public bool memFlag = false;
        public double savedValue;
        public char op;

        /// <summary>
        /// 생성자
        /// </summary>
        private void init()
        {
            //textboxt height resize
            this.txtResult.AutoSize = false;
            this.txtResult.Size = new System.Drawing.Size(142, 50);

            //초기값 설정
            this.txtResult.Text = "0";

            // 버튼 이벤트핸들러정의
            btnAc.Click += BtnAc_Click;
            btnClear.Click += BtnClear_Click;
            btnDel.Click += BtnDel_Click;
            btnDivision.Click += Btndivision_Click;
            btnMultiple.Click += BtnMultiple_Click;
            btnPlus.Click += BtnPlus_Click;
            btnMinus.Click += BtnMinus_Click;
            btnDot.Click += BtnDot_Click;
            btnEqual.Click += BtnEqual_Click; 

            txtResult.KeyPress += TxtResult_KeyPress;
        }

        private void TxtResult_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            //if (txtResult.Text == "0")
            if (txtResult.Text == "0" || opFlag == true || memFlag == true)
            {
                txtResult.Text = btn.Text;
                opFlag = false;
                memFlag = false;
            }
            else
            {
                txtResult.Text = txtResult.Text + btn.Text;
            }
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains("."))
                return;
            else
            {
                txtResult.Text += ".";
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            Double v = Double.Parse(txtResult.Text);
            switch (op)
            {
                case '+':
                    txtResult.Text = (savedValue + v).ToString();
                    break;
                case '-':
                    txtResult.Text = (savedValue - v).ToString();
                    break;
                case '*':
                    txtResult.Text = (savedValue * v).ToString();
                    break;
                case '/':
                    txtResult.Text = (savedValue / v).ToString();
                    break;
            }
            //txtResult.Text = "";
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtResult.Text = txtResult.Text + " + ";
            op = '+';
            opFlag = true;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtResult.Text = txtResult.Text + " - ";
            op = '-';
            opFlag = true;
        }

        private void BtnMultiple_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtResult.Text = txtResult.Text + " × ";
            op = '*';
            opFlag = true;
        }

        private void Btndivision_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(txtResult.Text);
            txtResult.Text = txtResult.Text + " ÷ ";
            op = '/';
            opFlag = true;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text.Length == 0)
                txtResult.Text = "0";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            savedValue = 0;
            op = '\0';
            opFlag = false;
        }

        private void BtnAc_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "0";
        }
    }
}
