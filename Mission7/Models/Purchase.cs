﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Mission7.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]

        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage ="Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a Address:")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage ="Please enter a city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a valid zip code")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a Country")]
        public string Country { get; set; }

    }
}