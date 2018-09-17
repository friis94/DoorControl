using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DoorControl.Unit.Test
{
    [TestFixture]
    class DoorControlUnitTest
    {

        [Test]
        public void DoorOpen_callOpen_doorHasBeenOpenedIs1()
        {

            //Assign
            FakeDoor myDoor = new FakeDoor();
            FakeEntryNotify myNotification = new FakeEntryNotify();
            FakeAlarm myAlarm = new FakeAlarm();
            FakeUserValidate myValidate = new FakeUserValidate();
            DoorController _uut = new DoorController(myAlarm, myDoor, myNotification, myValidate);

            //Act
            _uut._door.Open();

            //Assert
            Assert.That(myDoor.hasDoorBeenOpened.Equals(1));


        }

        [Test]
        public void DoorClose_callClose_doorHasBeenClosedIs1()
        {

            //Assign
            FakeDoor myDoor = new FakeDoor();
            FakeEntryNotify myNotification = new FakeEntryNotify();
            FakeAlarm myAlarm = new FakeAlarm();
            FakeUserValidate myValidate = new FakeUserValidate();
            DoorController _uut = new DoorController(myAlarm, myDoor, myNotification, myValidate);

            //Act
            _uut._door.Close();

            //Assert
            Assert.That(myDoor.hasDoorBeenClosed.Equals(1));


        }
    }
}
