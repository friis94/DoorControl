using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public delegate void MyDel();
    public delegate void MyDel2();
    public interface IDoor
    {
        
        event MyDel DoorClosed;
        event MyDel2 DoorOpened;

        void Open();
        void Close();
    }
}
