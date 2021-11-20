using System;
using Microsoft.Maui.Controls;
using org.mariuszgromada.math.mxparser;

namespace AP.M2.CalculatorApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Display.Text = string.Empty;
        }

        void OnBtnBackspaceClicked(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Remove(Display.Text.Length - 1);
            }
        }
        void OnBtnDivideClicked(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0 && !CheckIfSymbolIsLast(Display.Text))
            {
                Display.Text += "/";
            }

        }
        void OnBtnClearClicked(object sender, EventArgs e)
        {

            Display.Text = string.Empty;
            Result.Text = "result: ";
            Expression.Text = "expression: ";

        }

        bool CheckIfSymbolIsLast(string text)
        {
            if (text.EndsWith("/") ||
                text.EndsWith("*") ||
                text.EndsWith(",") ||
                text.EndsWith(".") ||
                text.EndsWith("-") ||
                text.EndsWith("+"))
            {
                return true;
            }

            return false;
        }

        void OnBtnMultiplyClicked(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0 && !CheckIfSymbolIsLast(Display.Text))
            {
                Display.Text += "*";

            }
        }
        void OnBtnSubstractClicked(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0 && !CheckIfSymbolIsLast(Display.Text))
            {

                Display.Text += "-";
            }
        }
        void OnBtn7Clicked(object sender, EventArgs e)
        {
            Display.Text += "7";
        }
        void OnBtn8Clicked(object sender, EventArgs e)
        {
            Display.Text += "8";
        }
        void OnBtn9Clicked(object sender, EventArgs e)
        {
            Display.Text += "9";
        }
        void OnBtnAddClicked(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0 && !CheckIfSymbolIsLast(Display.Text))
            {
                Display.Text += "+";

            }
        }
        void OnBtn4Clicked(object sender, EventArgs e)
        {
            Display.Text += "4";
        }
        void OnBtn5Clicked(object sender, EventArgs e)
        {
            Display.Text += "5";
        }
        void OnBtn6Clicked(object sender, EventArgs e)
        {
            Display.Text += "6";
        }
        void OnBtn1Clicked(object sender, EventArgs e)
        {
            Display.Text += "1";
        }
        void OnBtn2Clicked(object sender, EventArgs e)
        {
            Display.Text += "2";
        }
        void OnBtn3Clicked(object sender, EventArgs e)
        {
            Display.Text += "3";
        }
        void OnBtnEqualsClicked(object sender, EventArgs e)
        {
            var expression = Display.Text;
            if (CheckIfSymbolIsLast(expression))
            {
                expression = expression.Remove(expression.Length - 1);
            }


            var mathExpression = new Expression(expression);

            Result.Text = $"result: {mathExpression.calculate().ToString()}";
            Expression.Text = $"expression: {expression}";
            Display.Text = string.Empty;
        }
        void OnBtn0Clicked(object sender, EventArgs e)
        {
            Display.Text += "0";
        }
        void OnBtnCommaClicked(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0 && !CheckIfSymbolIsLast(Display.Text) && !CheckIfExpressionHaveComa(Display.Text))
            {

                Display.Text += ".";
            }
        }

        bool CheckIfExpressionHaveComa(string text)
        {
            char[] separators = new char[4] { '/', '*', '-', '+' };
            var splitedText = text.Split(separators);
            var element = splitedText[splitedText.Length - 1];

            if (element.Contains('.')) { return true; }


            return false;
        }
    }
}
