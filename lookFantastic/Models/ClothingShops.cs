namespace lookFantastic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClothingShops
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public double lon { get; set; }

        public double lat { get; set; }

        public string name { get; set; }

        public string opening_hours { get; set; }

        public string website { get; set; }

        public string addr_street { get; set; }

        public int numbergrades { get; set; }

        public double averagegrade { get; set; }
    }
}
