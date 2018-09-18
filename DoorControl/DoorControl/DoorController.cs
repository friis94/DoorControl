using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class DoorController
    {
        public IAlarm _alarm;
        public IDoor _door;
        public IEntryNotification _entryNotification;
        public IUserValidation _userValidation;
        public event EventHandler OpenDoorEvent;
        public event EventHandler CloseDoorEvent;



        public DoorController(IAlarm alarm, IDoor door, IEntryNotification entryNotification, IUserValidation userValidation)
        {
            _alarm = alarm;
            _door = door;
            _entryNotification = entryNotification;
            _userValidation = userValidation;
            door.DoorChangedEvent += HandleDoorChanged;
        }

        public void HandleDoorChanged(object source, DoorChangedEventArgs args)
        {
            if (args.DoorOpen)
            {
                this.DoorOpen();
            }
            else
            {
                this.DoorClosed();
            }
        }





        int RequestEntry(int id)
        {
            if (!_userValidation.ValidateEntryRequest(id))
            {
                return -1;
            }

            _door.Open();
            
            return id;
        }

      

        public void DoorOpen()
        {
            OpenDoorEvent?.Invoke(this, EventArgs.Empty);
        }

        void DoorClosed()
        {
            
        }






    }
}
