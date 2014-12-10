using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeague
{
    public class Ploeg : INotifyPropertyChanged
    {
        private int id;
        private string naam;
        private string bestand;
        private string land;
        private string groep;
        private string opmerking;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Naam
        {
            //test test
            get { return naam; }
            set
            {
                naam = value; NotifyPropertyChanged("Naam");
                                NotifyPropertyChanged("NaamEnLand"); }
        }

        public string NaamEnLand
        {
            get { return naam + " (" + land + ")"; }
        }

        public string Bestand
        {
            get { return bestand; }
            set { bestand = value; }
        }

        public string Logo
        {
            get { return "Assets/Logos/" + bestand; }
        }

        public string Shirt
        {
            get { return "Assets/Shirts/" + bestand; }
        }

        public string Land
        {
            get { return land.ToUpper(); }
            set
            {
                land = value; NotifyPropertyChanged("Land");
                                NotifyPropertyChanged("NaamEnLand");}
        }

        public string Groep
        {
            get { return groep; }
            set { groep = value; }
        }

        public string Opmerking
        {
            get { return opmerking; }
            set { opmerking = value; }
        }

        public Ploeg(int id, string naam, string bestand, string land, string groep, string opmerking)
        {
            Id = id;
            Naam = naam;
            Bestand = bestand;
            Land = land;
            Groep = groep;
            Opmerking = opmerking;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
