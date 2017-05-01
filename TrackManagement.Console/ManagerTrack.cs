using System;
using System.Collections.Generic;
using System.Text;
using TrackManagement.Console.Enum;

namespace TrackManagement.Console
{
    public class ManagerTrack
    {
        public static List<Track> Manage(List<string> nameEvents)
        {
            var events = new List<Event>();

            foreach(var name in nameEvents)
            {
                var e = Event.GetDetails(name);

                events.Add(e);
            }

            var tracks = new List<Track>();

            var track = new Track("FirstTrack");

            var currentSession = EventSession.Morning;

            foreach(var e in events)
            {
                var isPossibleInclude = ManageInclude(currentSession, e, track);
                if (!isPossibleInclude)
                {
                    if (currentSession == EventSession.Morning)
                    {
                        var lunch = new Event("Lunch", 60);
                        lunch.Session = EventSession.Lunch;
                        track.Events.Add(lunch);

                        currentSession = EventSession.Afternoon;

                        ManageInclude(currentSession, e, track);
                    }
                    else
                    {
                        var networking = new Event("Networking", 60);
                        networking.Session = EventSession.Network;
                        track.Events.Add(networking);

                        var trackCloned = track.Clone();

                        tracks.Add(trackCloned);

                        track = new Track("Track 2");

                        currentSession = EventSession.Morning;

                        ManageInclude(currentSession, e, track);
                    }
                }
            }

            return tracks;
        }

        private static bool ManageInclude(EventSession currentSession, Event e, Track track)
        {
            if (track.IsPossibleInclude(currentSession, e.Duration))
            {
                e.Session = currentSession;
                track.Events.Add(e);

                return true;
            }

            return false;
        }
    }
}
