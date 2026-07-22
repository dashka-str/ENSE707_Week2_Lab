using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace AppointmentBooking
{
    public class AppointmentBookingService
    {
        public bool BookAppointment(AppointmentRequest request)
        {
            if (request == null)
                return new BookingResult(false, "Appontment request is missing");

            if (!request.Doctor.HasAvailableSlot())
            {
                return new BookingResult(
                    false,
                    $"Appoinment cannot be booked because {request.Doctor.FullName} has no available slots")
                );
            }
            request.Doctor.ReserveSlot();
            return new BookingResult(

        }
    }
}
*/