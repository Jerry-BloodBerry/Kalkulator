using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Kalkulator
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public MainPageViewModel()
        {
            Calculate = new Command(() =>
            {
                Addition = Convert.ToDouble(Number1) + Convert.ToDouble(Number2);
                Subtraction = Convert.ToDouble(Number1) - Convert.ToDouble(Number2);
                Multiplication = Convert.ToDouble(Number1) * Convert.ToDouble(Number2);
                if(Convert.ToInt32(Number2) == 0)
                {
                    Division = -1;
                }
                else
                {
                    Division = Convert.ToDouble(Number1) / Convert.ToDouble(Number2);
                }
            });
        }
        
        string number1;
        string number2;

        double addition;
        double subtraction;
        double multiplication;
        double division;

        public double Addition
        {
            get => addition;
            set
            {
                addition = value;
                var args = new PropertyChangedEventArgs(nameof(Addition));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public double Subtraction
        {
            get => subtraction;
            set
            {
                subtraction = value;
                var args = new PropertyChangedEventArgs(nameof(Subtraction));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public double Multiplication
        {
            get => multiplication;
            set
            {
                multiplication = value;
                var args = new PropertyChangedEventArgs(nameof(Multiplication));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public double Division
        {
            get => division;
            set
            {
                division = value;
                var args = new PropertyChangedEventArgs(nameof(Division));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public string Number1
        {
            get => number1;
            set
            {
                number1 = value;
                var args = new PropertyChangedEventArgs(nameof(Number1));
                PropertyChanged?.Invoke(this,args);
            }
        }

        public string Number2
        {
            get => number2;
            set
            {
                number2 = value;
                var args = new PropertyChangedEventArgs(nameof(Number2));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command Calculate { get; set; }

    }
}
