using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TrackManagement.Console;
using TrackManagement.Console.Enum;

namespace TrackManagement.Test
{
    [TestClass]
    public class TrackTest
    {
        [TestMethod]
        public void IncludeEventOnTrackWithSuccess()
        {
            var newEvent = new Event("Communicating Over Distance", 60);

            var track = new Track("Test Track");

            var isPossible = track.IsPossibleInclude(EventSession.Morning, 60);

            Assert.IsTrue(isPossible, "It is not possible include this event on track");
        }

        //TODO: Create all test scenarios about include track
    }
}
