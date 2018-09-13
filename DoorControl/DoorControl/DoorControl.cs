using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    class DoorControl
    {
        int RequestEntry(int id)
        {
            if (!ValidateEntryRequest(id))
            {
                return -1;
            }

            Open();
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
