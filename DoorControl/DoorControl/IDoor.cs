using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public delegate void MyDel();
    public delegate void MyDel2();


    public class DoorChangedEventArgs : EventArgs
    {
        public bool DoorOpen { get; set; }
    }

    public interface IDoor
    {

        event EventHandler<DoorChangedEventArgs> DoorChangedEvent;

        void Open();
        void Close();
    }
}
