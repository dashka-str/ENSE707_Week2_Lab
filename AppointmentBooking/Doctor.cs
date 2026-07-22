using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBooking
{
    public class Doctor
    {
        public string Id { get; set; }
        public string FullName { get; set; }

        //private set denies authorised access to availability
        public int AvailableSlots { get; private set; }

        //doesnt accept null entries or negative availability, also sets expectations for tests
        public Doctor(string id, string fullName, int availableSlots)
        {
            if(string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Doctor id is required");
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Doctor name is required");
            if (availableSlots < 0)
                throw new ArgumentException("Available slots cannot benegative");
            Id = id;
            FullName = fullName;
            AvailableSlots = availableSlots;
        }

        public bool HasAvailableSlot()
        {
            return AvailableSlots > 0;
        }

        public void ReserveSlot()
        {
            if (!HasAvailableSlot())
                throw new InvalidOperationException("No appointment slots are available");
            AvailableSlots--;
        }
    }
}
