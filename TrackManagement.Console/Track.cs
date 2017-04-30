using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TrackManagement.Console.Enum;

namespace TrackManagement.Console
{
    public class Track
    {
        private const int MORNING_SESSION_DURATION = 180;
        private const int AFTERNOON_SESSION_DURATION = 240;

        public string Nome { get; set; }

        public List<Event> Events { get; set; }

        private int DurationSession(EventSession session)
        {
            return this.Events.Where(e => e.Session == session)
                              .Sum(e => e.Duration);
        }        

        public Track(string name)
        {
            this.Nome = name;
            this.Events = new List<Event>();
        }

        public bool IsPossibleInclude(EventSession session, int eventDuration)
        {
            var duration = this.DurationSession(session);

            if(session == EventSession.Morning)
            {
                return duration <= MORNING_SESSION_DURATION
                    && duration + eventDuration <= MORNING_SESSION_DURATION;
            }
            else
            {
                return duration <= AFTERNOON_SESSION_DURATION 
                    && duration + eventDuration <= AFTERNOON_SESSION_DURATION;
            }
        }
    }
}
