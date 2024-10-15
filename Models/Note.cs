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
        public DateTime DateOfCreation { get; set; }

        private string title = "";
        public string Title 
        { 
            get { return this.title; }
            set
            {
                if (value == null)
                    return;
                else
                    this.title = value;
            } 
        }

        private string entry = "";
        public string Entry
        {
            get { return this.entry; }
            set
            {
                if (value == null)
                    return;
                else
                    this.entry = value;
            }
        }

    }
}
