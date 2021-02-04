using MVVMExample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMExample.ModelView
{
    public class HolesViewModel : ObservableBase
    {
        public HolesViewModel()
        {
            AllHoles = new ObservableCollection<HolesModel>();
        }



        public bool CanDelete
        {
            get { return _currentHole != null; }
        }

        public ObservableCollection<HolesModel> AllHoles { get; set; }



        private HolesModel _currentHole;

        public HolesModel CurrentHole
        {
            get { return _currentHole; }
            set
            {
                _currentHole = value;
                OnPropertyChanged("CurrentHole");
                OnPropertyChanged("CanDelete");
            }
        }
    }
}
