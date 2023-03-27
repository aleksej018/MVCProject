using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekat.Models
{
    public class Proizvod
    {
        [Required(ErrorMessage="Unesite ime proizvoda.")]
        public string Naziv { get; set; } //svojstvo

        [Required(ErrorMessage = "Unesite sliku proizvoda.")]
        public string Slika { get; set; }

        [Required(ErrorMessage = "Unesite cenu proizvoda."), MinLength(4, ErrorMessage ="Cena ne moze imati manje od 3 cifre")]
        public double Cena { get; set; }

        [Required(ErrorMessage ="Unesite proizvodjaca.")]
        public string Proizvodjac { get; set; }

        [Required(ErrorMessage = "Unesite akciju za proizvod.")]
        public bool Akcija { get; set; }

        [Required(ErrorMessage ="Dodajte opis za proizvod.")]
        public string Opis { get; set; }

    }
}