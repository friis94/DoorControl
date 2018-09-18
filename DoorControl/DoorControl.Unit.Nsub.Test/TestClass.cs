using System;
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
        private DoorController _uut;






        [Test]
        public void DoorOpened_DoorOpenedEvent_DoorOpenedCalled()
        {

            _door.DoorOpened += Raise.Event();
            _uut.Received().DoorOpen();
        }

    }
}
