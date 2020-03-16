using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RundenRollen
{
    public class ViewModel
    {
        public ObservableCollection<Trupp> VerbündeteEinheiten { get; set; } = new ObservableCollection<Trupp>();
        public ObservableCollection<Trupp> GegnerEinheiten { get; set; } = new ObservableCollection<Trupp>();

    }
}
