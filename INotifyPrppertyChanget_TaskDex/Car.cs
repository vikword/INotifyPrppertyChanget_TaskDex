using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace INotifyPrppertyChanget_TaskDex
{
    class Car : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly string _brand;
        private readonly string _model;
        private readonly string _win;
        private string _namber;
        private string _carOwner;

        public Car(string breand, string model, string win)
        {
            _brand = breand;
            _model = model;
            _win = win;
        }

        private void CangedProperty([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return "\nМврка: " + Brand + "\nМодель: " + Model + "\nГос Номер: " + Namber + "\nВладелец: " + CarOwner;
        }

        public string Brand
        {
            get => _brand;
        }

        public string Model
        {
            get => _model;
        }

        public string Win
        {
            get => _win;
        }

        public string Namber
        {
            get => _namber;
            set
            {
                if (value != _namber)
                {
                    _namber = value;
                    CangedProperty();
                }
            }
        }

        public string CarOwner
        {
            get => _carOwner;
            set 
            {
                if (value != _carOwner)
                {
                    _carOwner = value;
                    CangedProperty();
                }
            }
        }
    }
}
