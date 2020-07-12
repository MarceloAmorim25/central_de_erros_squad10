using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeErros.API.Models
{
    public class Occurrence
    {
        public int Id { get; set; }

        public string Origin { get; set; }

        public string Details { get; set; }

        public DateTime OccurrenceDate { get; set; }

        public int MicrosserviceId { get; set; }

        public Microsservice Microsservice { get; set; }

    }
}
