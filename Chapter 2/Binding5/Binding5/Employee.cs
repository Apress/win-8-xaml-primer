using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Binding5
{
    class Employee : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }

        private void RaisePropertyChanged(
            [CallerMemberName] string caller = "" )
        {
            if ( PropertyChanged != null )
            {
                PropertyChanged( this, new PropertyChangedEventArgs( caller ) );
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add( new Employee() { Name = "Washington", Title = "President 1" } );
            employees.Add( new Employee() { Name = "Adams", Title = "President 2" } );
            employees.Add( new Employee() { Name = "Jefferson", Title = "President 3" } );
            employees.Add( new Employee() { Name = "Madison", Title = "President 4" } );
            employees.Add( new Employee() { Name = "Monroe", Title = "President 5" } );
            return employees;
        }

    }
}
