using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace RundenRollen
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Trupp> VerbündeteEinheiten { get; set; } = new ObservableCollection<Trupp>();
        public ObservableCollection<Trupp> GegnerEinheiten { get; set; } = new ObservableCollection<Trupp>();

        private Trupp selectedUnit;
        public Trupp SelectedUnit
        {
            get
            {
                return selectedUnit;
            }
            set
            {
                selectedUnit = value;
                RaisePropertyChanged("SelectedUnit");
            }
        }

        ICommand NewUnitCommand
        {
            get
            {
                return new RelayCommand((param) => NewUnit(param));
            }
        }
        private void NewUnit(object Param)
        {
            
        }

        private void RaisePropertyChanged(string Property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
