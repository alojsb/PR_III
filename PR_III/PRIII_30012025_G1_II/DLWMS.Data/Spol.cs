﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data
{
    [Table("SpoloviBrojIndeksa")]
    public class Spol
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Aktivan { get; set; }
    }
}