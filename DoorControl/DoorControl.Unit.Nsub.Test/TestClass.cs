﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;

namespace DoorControl.Unit.Nsub.Test
{
    [TestFixture]
    class TestClass
    {
        private int _openDoorEventReceived;
        private DoorController _uut;
        private IDoor _door;
        private IAlarm _alarm;
        private IEntryNotification _entryNotification;
        private IUserValidation _userValidation;

        [SetUp]
        public void Setup()
        {
            _openDoorEventReceived = 0;
            _door = Substitute.For<IDoor>();
            _alarm = Substitute.For<IAlarm>();
            _entryNotification = Substitute.For<IEntryNotification>();
            _userValidation = Substitute.For<IUserValidation>();

            _uut = new DoorController(_alarm, _door, _entryNotification, _userValidation);

            _uut.OpenDoorEvent += (sender, args) => { ++_openDoorEventReceived; };

        }

        [Test]
        public void DoorOpened_DoorOpenedEvent_DoorOpenedCalled()
        {

            _door.DoorChangedEvent += Raise.EventWith(new DoorChangedEventArgs{DoorOpen = true});
            Assert.That(_openDoorEventReceived, Is.EqualTo(1));
        }

    }
}
