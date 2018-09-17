using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControl;

namespace DoorControl.Unit.Test
{
    class FakeEntryNotify : IEntryNotification
    {

        public bool NotifyEntryGranted()
        {
            return true;
        }


        public bool NotifyEntryDenied()
        {
            return true;
        }

    }
}
