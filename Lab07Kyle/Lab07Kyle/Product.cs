using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07Kyle
{
    class Product
    {
        public int ProductID { get; set; } //unique identifier 
        public Metal ProductMetalType { get; set; } //property that can select weapon metal type
        public Blade ProductBladeLength { get; set; } //property that can set weapon length
        public virtual bool TwoHandedWeapon() // method that can determine if the weapon is a two handed weapon or not
        {
            return false;
        }
    }

    enum Metal : int //setting the enumerator for selecting the metal type
    {
        adamantine = 1,
        bronze,
        cold_iron,
        silver,
        steel,
    }

    enum Blade : int // setting the enumerator for selecting blade length
    {
        inches_twenty = 1,
        inches_twentfour,
        inches_thirty,
        inches_forty,
    }
}
