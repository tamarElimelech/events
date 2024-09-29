using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace events
{
    class Program
    {
       static List<Event> eventsl = new List<Event>();
       static public List<Event> GET()
        {
            return eventsl;
        }

        static public void POST(Event e)
        {
            eventsl.Add(e);
        }

        static public void PUT(int i, string t)
        {
            Event ev = eventsl.Where(e => e.Id == i).First();
            ev.Title = t;
        }
        static public void DELETE(int id)
        {
            Event ev = eventsl.Where(e => e.Id == id).First();
            eventsl.Remove(ev);
        }


    static void Main(string[] args)
        {
            Event e1 = new Event("evening");
            Event e2 = new Event("morning");
            Event e3 = new Event("afternoon");

            POST(e1);
            POST(e2);
            POST(e3);
            List<Event> events2 = new List<Event>();
            events2=GET();
            foreach(var e in events2)
            {
                Console.WriteLine("id:"+e.Id+" title: "+e.Title);
            }
            PUT(0, "UPDATE");
            DELETE(1);
            Console.WriteLine("events after");
            foreach (var e in eventsl)
            {
                Console.WriteLine("id:" + e.Id + " title: " + e.Title);
            }
            Console.ReadLine();
        }
    }
}
