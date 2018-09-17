using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl.Unit.Test
{
    public class FakeDoor : IDoor
    {
        public event MyDel DoorClosed;
        public event MyDel2 DoorOpened;
        public int hasDoorBeenOpened = 0;
        public int hasDoorBeenClosed = 0;

        public FakeDoor()
        {
            
        }

        public void Open()
        {
            hasDoorBeenOpened = 1;
            DoorClosed();
        }

        public void Close()
        {
            hasDoorBeenClosed = 1;
            DoorOpened();
        }


    }
}
