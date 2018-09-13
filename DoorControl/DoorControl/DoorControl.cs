using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    class DoorControl
    {
        private IAlarm _alarm;
        private IDoor _door;
        private IEntryNotification _entryNotification;
        private IUserValidation _userValidation;

        int RequestEntry(int id)
        {
            if (!_userValidation.ValidateEntryRequest(id))
            {
                return -1;
            }

            _door.Open();
            return 0;
        }

      

        void DoorOpen()
        {
            
        }

        void DoorClosed()
        {

        }
    }
}
