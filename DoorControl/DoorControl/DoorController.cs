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
        



        public DoorController(IAlarm alarm, IDoor door, IEntryNotification entryNotification, IUserValidation userValidation)
        {
            _alarm = alarm;
            _door = door;
            _door.DoorClosed += _door_DoorClosed;
            _door.DoorOpened += _door_DoorOpened;
            _entryNotification = entryNotification;
            _userValidation = userValidation;
        }

        private void _door_DoorOpened()
        {
            this.DoorOpen();
        }

        private void _door_DoorClosed()
        {
            this.DoorClosed();
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

      

        void DoorOpen()
        {

        }

        void DoorClosed()
        {
            
        }






    }
}
