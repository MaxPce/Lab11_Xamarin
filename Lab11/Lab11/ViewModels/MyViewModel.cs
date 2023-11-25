using System;
using System.Collections.Generic;
using System.Text;
using Lab11.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab11.ViewModels
{
    public class MyViewModel : INotifyPropertyChanged
    {
        private MyModel _myModel;

        public MyViewModel()
        {
            _myModel = new MyModel();
            SumarCommand = new Command(SumarOperacion);
            MultiplicarCommand = new Command(MultiplicarOperacion);
        }

        public double Valor1
        {
            get => _myModel.Valor1;
            set
            {
                if (_myModel.Valor1 != value)
                {
                    _myModel.Valor1 = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Valor2
        {
            get => _myModel.Valor2;
            set
            {
                if (_myModel.Valor2 != value)
                {
                    _myModel.Valor2 = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Valor3
        {
            get => _myModel.Valor3;
            set
            {
                if (_myModel.Valor3 != value)
                {
                    _myModel.Valor3 = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Sumar => _myModel.Valor1 + _myModel.Valor2 + _myModel.Valor3;

        public double Multiplicar => _myModel.Valor1 * _myModel.Valor2 * _myModel.Valor3;

        public ICommand SumarCommand { get; }
        public ICommand MultiplicarCommand { get; }

        private void SumarOperacion()
        {
            OnPropertyChanged(nameof(Sumar));
        }

        private void MultiplicarOperacion()
        {
            OnPropertyChanged(nameof(Multiplicar));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
