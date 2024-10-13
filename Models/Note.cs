using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notify.Models
{
    public class Note
    {
        public int ID { get; set; }
        public required string Title { get; set; }
        public required string Entry { get; set; }

    }
}
