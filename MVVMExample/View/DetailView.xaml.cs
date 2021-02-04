using MVVMExample.ModelView;
using System.Collections.ObjectModel;
using System.Windows.Controls;


namespace MVVMExample.View
{
    /// <summary>
    /// Interaction logic for DetailView.xaml
    /// </summary>
    public partial class DetailView : UserControl
    {
        public HolesViewModel FurosList { get; set; }

        public DetailView()
        {

            FurosList = new HolesViewModel()
            {
                AllHoles = new ObservableCollection<Model.HolesModel>()
                {
                    new Model.HolesModel()
                    {
                        NumeroID="5",
                        Length=3.2,
                        Stemming=1
                    },
                    new Model.HolesModel()
                    {
                        NumeroID="10",
                        Length=10,
                        Stemming=4
                    },
                    new Model.HolesModel()
                    {
                        NumeroID="11",
                        Length=7,
                        Stemming=3
                    }
                }
            };

            this.DataContext = FurosList;


            InitializeComponent();

            
        }
    }
}
