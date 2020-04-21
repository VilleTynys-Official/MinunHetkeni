using System;
using System.Collections.ObjectModel;

namespace MinunHetkeni.ViewModels
{
    public class KategoriatListaViewModel
    {

        public ObservableCollection<Kategoria> Kategoriat { get; set; }
        

        public KategoriatListaViewModel()
        {
            Kategoriat = new ObservableCollection<Kategoria>();

            Kategoriat.Add(new Kategoria("Ensimmäiset askeleet", "ylaosa.png",
                "Aloita tästä seitsemän päivän tutustumisjakso. Yhden harjoituksen kesto noin 10 minuuttia." +
                " Ainut mitä tarvitset on oma rauhallinen paikka ilman häiriötekijöitä."));
        }
    }
}
