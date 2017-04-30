using System;
using System.Collections.Generic;

namespace TrackManagement.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nameEvents = InputEvents();

            var tracks = ManagerTrack.Manage(nameEvents);

            foreach(var track in tracks)
            {
                System.Console.WriteLine(track.Nome);

                foreach (var e in track.Events)
                {
                    var printTrack = string.Format("Name: {0} | Duration: {1} min | Session: {2}", 
                                              e.Name, 
                                              e.Duration, 
                                              e.Session);

                    System.Console.WriteLine(printTrack);
                }
            }

            System.Console.ReadKey();
        }

        private static List<string> InputEvents()
        {
            var namesEvents = new List<string>();

            namesEvents.Add("Writing Fast Tests Against Enterprise Rails 60min");
            namesEvents.Add("Overdoing it in Python 45min");
            namesEvents.Add("Lua for the Masses 30min");
            namesEvents.Add("Ruby Errors from Mismatched Gem Versions 45min");
            namesEvents.Add("Common Ruby Errors 45min");
            namesEvents.Add("Rails for Python Developers lightning");
            namesEvents.Add("Communicating Over Distance 60min");
            namesEvents.Add("Accounting-Driven Development 45min");
            namesEvents.Add("Woah 30min");
            namesEvents.Add("Sit Down and Write 30min");
            namesEvents.Add("Pair Programming vs Noise 45min");
            namesEvents.Add("Rails Magic 60min");
            namesEvents.Add("Ruby on Rails: Why We Should Move On 60min");
            namesEvents.Add("Clojure Ate Scala (on my project) 45min");
            namesEvents.Add("Programming in the Boondocks of Seattle 30min");
            namesEvents.Add("Ruby vs. Clojure for Back-End Development 30min");
            namesEvents.Add("Ruby on Rails Legacy App Maintenance 60min");
            namesEvents.Add("A World Without HackerNews 30min");
            namesEvents.Add("User Interface CSS in Rails Apps 30min");

            return namesEvents;
        }
    }
}