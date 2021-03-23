using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers_Countdown
{
    public partial class Form2 : Form
    {
        Random rng = new Random();
        int[] _numbers = new int[6];
		int bestSoFar = 0;
		double secondsTaken = 0;
		int thisTotal = 0;
		double _firstNumber;
		double _ans;
		string _op;
		public Form2()
        {
            InitializeComponent();
            _labTarget.Text = Convert.ToString(rng.Next(100, 999));
			_labBest.Hide();
			_labSolution.Hide();
		}


        public void _passArray(int[] array)
        {
            //1. or to pass to some control:   
            for (int i = 0; i < array.Length; i++)
            {
                _numbers[i] = array[i];
            }
			_buttNum1.Text = _numbers[0].ToString();
			_buttNum2.Text = _numbers[1].ToString();
			_buttNum3.Text = _numbers[2].ToString();
			_buttNum4.Text = _numbers[3].ToString();
			_buttNum5.Text = _numbers[4].ToString();
			_buttNum6.Text = _numbers[5].ToString();
			_BruteforceResolver(_numbers, Convert.ToInt32(_labTarget.Text));
		}
        public void _BruteforceResolver(int[] array, int target)
        {
			var startTime = DateTime.Now;
			while (thisTotal != target)
			{
				secondsTaken = (DateTime.Now - startTime).TotalSeconds;
				if (secondsTaken >= 10) break;
				
				var numIndex = rng.Next(6);
				var temp = array[numIndex];
				array[numIndex] = array[0];
				array[0] = temp;
				thisTotal = array[0];
				var solution = thisTotal.ToString();

				for (int i = 1; i < 6; i++)
				{
					var operation = rng.Next(4);
					if (operation == 0)
					{
						thisTotal += array[i];
						solution += $" + {array[i]}";
					}
					else if (operation == 1)
					{
						thisTotal -= array[i];
						solution += $" - {array[i]}";
					}
					else if (operation == 2)
					{
						thisTotal *= array[i];
						solution += $" x {array[i]}";
					}
					else
					{
						if (thisTotal % array[i] != 0) continue;
						thisTotal /= array[i];
						solution += $" ÷ {array[i]}";
					}
					if (Math.Abs(target - thisTotal) < Math.Abs(target - bestSoFar))
					{
						bestSoFar = thisTotal;
						Console.WriteLine($"{solution} = {thisTotal}");
					}
					if (thisTotal == target) break;
				}
                _labBest.Text = bestSoFar.ToString();
				_labSolution.Text = solution;
			}
		}
        private void _buttNum1_Click(object sender, EventArgs e)
        {
			if (_tbOutput.Text == "")
			{
				_tbOutput.Text = _buttNum1.Text;
				_buttNum1.Enabled = false;
			}
		}

        private void _buttNum2_Click(object sender, EventArgs e)
        {
			if (_tbOutput.Text == "")
			{
				_tbOutput.Text = _buttNum2.Text;
				_buttNum2.Enabled = false;
			}
		}

        private void _buttNum3_Click(object sender, EventArgs e)
        {
			if (_tbOutput.Text == "")
			{
				_tbOutput.Text = _buttNum3.Text;
				_buttNum3.Enabled = false;
			}
		}

        private void _buttNum4_Click(object sender, EventArgs e)
        {
			if (_tbOutput.Text == "")
			{
				_tbOutput.Text = _buttNum4.Text;
				_buttNum4.Enabled = false;
			}
		}

        private void _buttNum5_Click(object sender, EventArgs e)
        {
			if (_tbOutput.Text == "")
			{
				_tbOutput.Text = _buttNum5.Text;
				_buttNum5.Enabled = false;
			}
		}

        private void _buttNum6_Click(object sender, EventArgs e)
        {
			if (_tbOutput.Text == "")
			{
				_tbOutput.Text = _buttNum6.Text;
				_buttNum6.Enabled = false;
			}
		}
		private void _buttAns_Click(object sender, EventArgs e)
		{
			if (_tbOutput.Text == "")
			{
				_tbOutput.Text = _buttAns.Text;
				_buttAns.Enabled = false;
			}
		}

		private void _buttAdd_Click(object sender, EventArgs e)
        {
			try { _firstNumber = Convert.ToDouble(_tbOutput.Text);
			_tbOutput.Text = "";
			_op = "+";
			_buttAdd.Enabled = false;
			_buttMinus.Enabled = false;
			_buttMultiply.Enabled = false;
			_buttDivide.Enabled = false;
			}
			catch
			{

			}
		}

        private void _buttMinus_Click(object sender, EventArgs e)
        {
			try { _firstNumber = Convert.ToDouble(_tbOutput.Text);
			_tbOutput.Text = "";
			_op = "-";
			_buttAdd.Enabled = false;
			_buttMinus.Enabled = false;
			_buttMultiply.Enabled = false;
			_buttDivide.Enabled = false;
			}
			catch
			{

			}
		}

		private void _buttMultiply_Click(object sender, EventArgs e)
        {
			try { _firstNumber = Convert.ToDouble(_tbOutput.Text);
			_tbOutput.Text = "";
			_op = "*";
			_buttAdd.Enabled = false;
			_buttMinus.Enabled = false;
			_buttMultiply.Enabled = false;
			_buttDivide.Enabled = false;
			}
			catch
			{

			}
		}

        private void _buttDivide_Click(object sender, EventArgs e)
        {
			try { _firstNumber = Convert.ToDouble(_tbOutput.Text);
			_tbOutput.Text = "";
			_op = "/";
			_buttAdd.Enabled = false;
			_buttMinus.Enabled = false;
			_buttMultiply.Enabled = false;
			_buttDivide.Enabled = false;
			}
			catch 
			{ 
			
			}
		}

		private void _buttEquals_Click(object sender, EventArgs e)
		{
			double _secondNumber;
			double Result;

			try { _secondNumber = Convert.ToDouble(_tbOutput.Text);

				if (_op == "+")
				{
					Result = (_firstNumber + _secondNumber);
					_tbOutput.Text = "";
					_buttAns.Text = Convert.ToString(Result);
					_ans = Result;
				}
				if (_op == "-")
				{
					Result = (_firstNumber - _secondNumber);
					_tbOutput.Text = "";
					_buttAns.Text = Convert.ToString(Result);
					_ans = Result;
				}
				if (_op == "*")
				{
					Result = (_firstNumber * _secondNumber);
					_tbOutput.Text = "";
					_buttAns.Text = Convert.ToString(Result);
					_ans = Result;
				}
				if (_op == "/")
				{
					if (_secondNumber == 0)
					{
						MessageBox.Show("Cannot divide by zero");
						_tbOutput.Text = "";
					}
					else
					{
						Result = (_firstNumber / _secondNumber);
						_tbOutput.Text = "";
						_buttAns.Text = Convert.ToString(Result);
						_ans = Result;
					}
				}
				_buttAdd.Enabled = true;
				_buttMinus.Enabled = true;
				_buttMultiply.Enabled = true;
				_buttDivide.Enabled = true;
				_buttAns.Enabled = true;
			}
			catch
            {

            }
		}
        private void _buttSubmit_Click(object sender, EventArgs e)
        {
			_labAns.Text = _tbOutput.Text;
			_labBest.Show();
			_labSolution.Show();
        }
    }
}
