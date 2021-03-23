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
    public partial class Form1 : Form
    {
        public Form FormToShowOnClosing { get; set; }
        Form2 _playForm = new Form2();
        Random rng = new Random();
        int[] _small = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };
        int[] _large = new int[] { 25, 50, 75, 100 };
        int[] _numbers = new int[6];
        string _choice;
        int _selected;
        public Form1()
        {
            InitializeComponent();

        }
        private void _selectedClick(object sender, EventArgs e)
        {
            _choice = (sender as Button).Text;
            if (_choice == _buttNoneLarge.Text)
            {
                _selected = 0;
            }
            else if (_choice == _buttOneLage.Text)
            {
                _selected = 1;
            }
            else if (_choice == _buttTwoLarge.Text)
            {
                _selected = 2;
            }
            else if (_choice == _buttThreeLarge.Text)
            {
                _selected = 3;
            }
            else if (_choice == _buttFourLarge.Text)
            {
                _selected = 4;
            }
        }

        private void _buttPlay_Click(object sender, EventArgs e)
        {
            if (_choice != null)
            {
                _generator(_selected);
                _playForm.Show();
                _playForm._passArray(_numbers);
            }
        }
        private void _generator(int _largeNumbers)
        {
            int index = 0;
            if (_largeNumbers == 0)
            {
                for (index = 0; index < _numbers.Length; index++)
                {
                    _numbers[index] = _small[rng.Next(0, 10)];
                }
            }
            if (_largeNumbers == 1)
            {
                for (index = 0; index < _numbers.Length - 1; index++)
                {
                    _numbers[index] = (_small[rng.Next(0, 10)]);
                }
                while (index < _numbers.Length)
                {
                    _numbers[index] = _large[rng.Next(0, 4)];
                    index++;
                }
            }
            if (_largeNumbers == 2)
            {
                for (index = 0; index < _numbers.Length - 2; index++)
                {
                    _numbers[index] = _small[rng.Next(0, 10)];
                }
                while (index < _numbers.Length)
                {
                    _numbers[index] = _large[rng.Next(0, 4)];
                    index++;
                }
            }
            if (_largeNumbers == 3)
            {
                for (index = 0; index < _numbers.Length - 3; index++)
                {
                    _numbers[index] = _small[rng.Next(0, 10)];
                }
                while (index < _numbers.Length)
                {
                    _numbers[index] = _large[rng.Next(0, 4)];
                    index++;
                }
            }
            if (_largeNumbers == 4)
            {
                for (index = 0; index < _numbers.Length - 4; index++)
                {
                    _numbers[index] = _small[rng.Next(0, 10)];
                }
                while (index < _numbers.Length)
                {
                    _numbers[index] = _large[rng.Next(0, 4)];
                    index++;
                }
            }
        }
    }
}
