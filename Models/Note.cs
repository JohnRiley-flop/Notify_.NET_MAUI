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
        private string title = "";
        public string Title 
        { 
            get { return title; }
            set
            {
                if (value == null)
                    return;
                else
                    title = value;
            } 
        }

        private string entry = "";
        public string Entry
        {
            get { return entry; }
            set
            {
                if (value == null)
                    return;
                else
                    entry = value;
            }
        }

    }
}
