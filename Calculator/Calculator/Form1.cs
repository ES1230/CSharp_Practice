using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //숫자버튼 클릭처리 함수
        private void NumButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // 클릭한 버튼의 숫자를 가져옴
                string buttonText = button.Text;

                // 현재 텍스트를 가져옴
                string currentText = ResultDisplay.Text;

                // 현재 텍스트가 "0"일 때는 새로 입력된 숫자로 대체
                if (currentText == "0")
                {
                    ResultDisplay.Text = buttonText;
                }
                else
                {
                    // 현재 텍스트에 새로 입력된 숫자를 추가
                    ResultDisplay.Text += buttonText;
                }
            }
        }


        //각 숫자버튼 클릭 이벤트 핸들러
        private void Button0_Click(object sender, EventArgs e)
        {
            NumButton_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NumButton_Click(sender, e);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            NumButton_Click(sender, e);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            NumButton_Click(sender, e);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            NumButton_Click(sender, e);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            NumButton_Click(sender, e);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            NumButton_Click(sender, e);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            NumButton_Click(sender, e);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            NumButton_Click(sender, e);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            NumButton_Click(sender, e);
        }

        //소수점버튼
        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            if (!ResultDisplay.Text.Contains("."))
            {
                ResultDisplay.Text += ".";
            }
        }

        // 클리어버튼
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ResultDisplay.Text = "0";
        }


        // 결과버튼 
        private void ButtonResult_Click(object sender, EventArgs e)
        {

        }

        // 연산자버튼
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
