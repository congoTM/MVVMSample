using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMExample.Model
{
    public class HolesModel : INotifyPropertyChanged
    {
        private string numeroID;
        public string NumeroID
        {
            get { return numeroID; }
            set
            {
                numeroID = value;
                RaisePropertyChanged("NumeroID");
            }
        }

        private double length;
        public double Length
        {
            get { return length; }
            set
            {
                length = value;
                RaisePropertyChanged("Length");
                RaisePropertyChanged("HoleWidthTotal");

            }
        }

        private double stemming;

        public double Stemming
        {
            get { return stemming; }
            set
            {
                if (Length < value)
                {
                    Length += 1;
                }
                else
                {
                    stemming = value;
                    RaisePropertyChanged("Stemming");
                    RaisePropertyChanged("HoleWidthTotal");

                }

            }
        }


        public double HoleWidthTotal
        {
            get { return Stemming + Length; }
        }

       


        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}