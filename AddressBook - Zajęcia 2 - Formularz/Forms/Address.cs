using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook___Zajęcia_2___Formularz.Forms
{
    public class Address
    {
        [Display(Name = "Moja Ulica:")]
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = "Podaj nazwe!")]
        public string Street { get; set; }

        [Display(Name = "Numer:")]
        [Range(1,100,ErrorMessage ="Numer zbyt duży!")]
        public string Number { get; set; }

        [Display(Name = "Kod Pocztowy:")]
        [RegularExpression(@"\d{2}-\d{3}", ErrorMessage ="Poprawnie podaj kod pocztowy!"),Required(ErrorMessage="Podaj kod pocztowy!")]
        public string ZipCode { get; set; }

        [Display(Name = "Miasto:")]
        public string City { get; set; }
    }
}