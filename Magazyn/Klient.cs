﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    class Klient
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string FullInfo
        {
            get 
            {
                // "Imie Nazwisko"
                return $"{Imie} {Nazwisko}";
            }
        }

    }
}