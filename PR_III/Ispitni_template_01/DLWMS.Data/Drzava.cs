﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data
{
    [Table("Drzave")]
    public class Drzava
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }        
        public bool Aktivan { get; set; }
    }
}
