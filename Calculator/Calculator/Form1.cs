using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //숫자버튼 클릭

        private void Button0_Click(object sender, EventArgs e)
        {
            Display.Text += "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Display.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Display.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Display.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Display.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Display.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Display.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Display.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Display.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Display.Text += "9";
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }


        // 결과이벤트 
        private void ButtonResult_Click(object sender, EventArgs e)
        {

        }

        // 연산자버튼 이벤트
     

        private void Button_divde_Click(object sender, EventArgs e)
        {

        }

        private void Button_multiply_Click(object sender, EventArgs e)
        {

        }

        private void Button_minus_Click(object sender, EventArgs e)
        {

        }

        private void Button_plus_Click(object sender, EventArgs e)
        {

        }

    }
}
