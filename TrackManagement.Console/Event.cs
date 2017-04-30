using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TrackManagement.Console.Enum;
using System.Linq;

namespace TrackManagement.Console
{
    public class Event
    {
        public int Duration { get; private set; }
        public string Name { get; private set; }
        public EventSession Session { get; set; }

        public Event(string name, int duration)
        {
            this.Name = name;
            this.Duration = duration;
        }

        public static Event GetDetails(string name)
        {
            var duracaoRegex = Regex.Match(name, @"\d+").Value;

            int duration = 0;
            Int32.TryParse(duracaoRegex, out duration);

            var nameRegex = Regex.Replace(name, @"\d+", string.Empty)
                                 .Replace("min", string.Empty);

            if(duration == 0)
            {
                duration = 60;
            }

            var currentEvent = new Event(nameRegex, duration);

            return currentEvent;
        }
    }
}
