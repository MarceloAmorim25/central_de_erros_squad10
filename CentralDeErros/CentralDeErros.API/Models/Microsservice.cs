﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeErros.API.Models
{
    public class Microsservice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Occurrence> Occurrences { get; set; }

    }
}
