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
                if(track.IsPossibleInclude(currentSession, e.Duration))
                {
                    track.Events.Add(e);
                }
                else
                {
                    var lunch = new Event("Lunch", 60);
                    lunch.Session = EventSession.Lunch;
                    track.Events.Add(lunch);

                    if (currentSession == EventSession.Morning)
                    {
                        currentSession = EventSession.Afternoon;

                        if (track.IsPossibleInclude(currentSession, e.Duration))
                        {
                            e.Session = currentSession;
                            track.Events.Add(e);
                        }
                    }
                    else
                    {
                        var networking = new Event("Networking", 60);
                        networking.Session = EventSession.Network;
                        track.Events.Add(networking);

                        tracks.Add(track);

                        track = new Track("Track 2");

                        currentSession = EventSession.Morning;

                        if (track.IsPossibleInclude(currentSession, e.Duration))
                        {
                            e.Session = currentSession;
                            track.Events.Add(e);
                        }
                    }
                }
            }

            return tracks;

        }
    }
}
