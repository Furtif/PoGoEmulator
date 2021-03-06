﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// ReSharper disable InconsistentNaming

namespace PoGoEmulator.Database.Tables
{
    [Table("pokestop")]
    public class PokeStop
    {
        public int id { get; set; }

        [StringLength(64)]
        public string cell_id { get; set; }

        public double latitude { get; set; }
        public double longitude { get; set; }

        [StringLength(64)]
        public string name { get; set; }

        [StringLength(128)]
        public string description { get; set; }

        [StringLength(64)]
        public string img_url { get; set; }

        public int experience { get; set; }

        [StringLength(64)]
        public string rewards { get; set; }
    }
}