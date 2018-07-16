using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SimpleIValueConverter.Classes
{
    public class Person : INotifyPropertyChanged
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged(); }
        }
        private string _gender;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; OnPropertyChanged(); }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
