using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrackManagement.Console;

namespace TrackManagement.Test
{
    [TestClass]
    public class EventTest
    {
        [TestMethod]
        public void CreateEventSuccessWithDuration()
        {
            var nameEvent = "Overdoing it in Python 45min";

            var createdEvent = Event.GetDetails(nameEvent);

            Assert.AreEqual("Overdoing it in Python", createdEvent.Name);
            Assert.AreEqual(45, createdEvent.Duration);
        }

        [TestMethod]
        public void CreateEventSuccessWithoutDuration()
        {
            var nameEvent = "Rails for Python Developers lightning";

            var createdEvent = Event.GetDetails(nameEvent);

            Assert.AreEqual("Rails for Python Developers lightning", createdEvent.Name);
            Assert.AreEqual(60, createdEvent.Duration);     
        }
    }
}
