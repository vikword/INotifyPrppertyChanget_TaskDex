using System;
using System.ComponentModel;

namespace INotifyPrppertyChanget_TaskDex
{
    class Program
    {
        static void Main(string[] args)
        {
            Car person = new Car("BMW", "335D", "BWRS1245TT12T56")
            {
                Namber = "T 335 BH", 
                CarOwner = "Петров Александр Васильевич" 
            };

            person.PropertyChanged += CarPropertyChanged;
            person.CarOwner = "Иванов Сергей Аркадьевич";
            person.Namber = "C 513 AB";
        }

        private static void CarPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Namber":
                    Console.WriteLine($"Данные о номере авто изменены: {e.PropertyName} {sender}\n");
                    break;
                case "CarOwner":
                    Console.WriteLine($"Данные о владельце авто изменены: {e.PropertyName} {sender}\n");
                    break;
            }
        }
    }
}
