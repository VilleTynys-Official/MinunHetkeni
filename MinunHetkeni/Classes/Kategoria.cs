using System;
namespace MinunHetkeni.ViewModels
{
    public class Kategoria
    {
        public string KategorianNimi { get; set; } //määritellään propertyt (eli fieldsit, joilla on get set accessorit)
        public string KategorianKuva { get; set; }
        public string KategorianKuvaus { get; set; }

        public Kategoria(string kategorianNimi, string kategorianKuva, string kategorianKuvaus)
        {

            KategorianNimi = kategorianNimi;        //käytetään accessoreja
            KategorianKuva = kategorianKuva;
            KategorianKuvaus = kategorianKuvaus;
        }
    }
}
