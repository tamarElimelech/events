using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    class Event
    {
        static int id;
        private string title;
        private DateTime start;
        static public int cnt = 0;

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }


        public Event()
        {
         
            Id=id++;
            Title = null;
            Start = DateTime.Now;

        }
        public Event(string title)
        {
            Id = id++;
            Title = title;
            Start = DateTime.Now;
        }

     
    }
}

       

