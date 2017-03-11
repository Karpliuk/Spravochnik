﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB
{
    public class Service
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string Code { get; set; }

        public bool? IsDiscountAllowed { get; set; }
       
        public virtual Location Location { get; set; }

        public virtual ICollection<ServiceXMedicalServiceGroups> ServiceXMedicalServiceGroups { get; set; }

        public virtual ICollection<PriceList> PriceLists { get; set; }

        public Service()
        {
            ServiceXMedicalServiceGroups = new List<ServiceXMedicalServiceGroups>();
            PriceLists = new List<PriceList>();
        }

    }
}