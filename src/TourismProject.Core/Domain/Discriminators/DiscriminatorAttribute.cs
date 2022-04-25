﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismProject.Domain.Discriminators
{
    public class DiscriminatorAttribute
    {

        public string DiscriminatorColumn { get; set; }

        public bool UseDiscriminator { get; set; }

        public bool FilterUnknownDiscriminators { get; set; }

        public DiscriminatorAttribute()
        {
            DiscriminatorColumn = "Tour_Discriminator";
            UseDiscriminator = true;
            FilterUnknownDiscriminators = false;

        }
    }
}
