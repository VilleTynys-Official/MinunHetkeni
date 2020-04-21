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

            Kategoriat.Add(new Kategoria("Ensimmäiset askeleet", "kategoria1.png",
                "Aloita tästä seitsemän päivän tutustumisjakso. Yhden harjoituksen kesto noin 10 minuuttia."));

            Kategoriat.Add(new Kategoria("Seuraavat askeleet", "kategoria2.png",
                "Jatka tästä tutustumisjakson jälkeen. Yhden harjoituksen kesto noin 10 minuuttia."));

            Kategoriat.Add(new Kategoria("Tutustuminen Metta-meditointiin", "kategoria3.png",
                "Tässä kolmannessa polussa tutustut Metta-meditointiin. Yhden harjoituksen kesto noin 10 minuuttia"));

            Kategoriat.Add(new Kategoria("Tutustuminen Metta-meditointiin", "kategoria3.png",
                "Tässä kolmannessa polussa tutustut Metta-meditointiin. Yhden harjoituksen kesto noin 10 minuuttia"));

            Kategoriat.Add(new Kategoria("Tutustuminen Metta-meditointiin", "kategoria3.png",
                "Tässä kolmannessa polussa tutustut Metta-meditointiin. Yhden harjoituksen kesto noin 10 minuuttia"));

            Kategoriat.Add(new Kategoria("Tutustuminen Metta-meditointiin", "kategoria3.png",
                "Tässä kolmannessa polussa tutustut Metta-meditointiin. Yhden harjoituksen kesto noin 10 minuuttia"));

            Kategoriat.Add(new Kategoria("Tutustuminen Metta-meditointiin", "kategoria3.png",
                "Tässä kolmannessa polussa tutustut Metta-meditointiin. Yhden harjoituksen kesto noin 10 minuuttia"));

            Kategoriat.Add(new Kategoria("Tutustuminen Metta-meditointiin", "kategoria3.png",
                "Tässä kolmannessa polussa tutustut Metta-meditointiin. Yhden harjoituksen kesto noin 10 minuuttia"));

            Kategoriat.Add(new Kategoria("Tutustuminen Metta-meditointiin", "kategoria3.png",
                "Tässä kolmannessa polussa tutustut Metta-meditointiin. Yhden harjoituksen kesto noin 10 minuuttia"));

            Kategoriat.Add(new Kategoria("Tutustuminen Metta-meditointiin", "kategoria3.png",
                "Tässä kolmannessa polussa tutustut Metta-meditointiin. Yhden harjoituksen kesto noin 10 minuuttia"));

            Kategoriat.Add(new Kategoria("Tutustuminen Metta-meditointiin", "kategoria3.png",
                "Tässä kolmannessa polussa tutustut Metta-meditointiin. Yhden harjoituksen kesto noin 10 minuuttia"));

            Kategoriat.Add(new Kategoria("Tutustuminen Metta-meditointiin", "kategoria3.png",
                "Tässä kolmannessa polussa tutustut Metta-meditointiin. Yhden harjoituksen kesto noin 10 minuuttia"));
        }
    }
}
