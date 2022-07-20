using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rooms.Entities
{
    class Reservation
    {
        public int numberRoom { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }

        public Reservation() { }

        public Reservation(int numberRoom, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new Exception("Check-out date must be after check-in date");
            } else
            {
                this.checkin = checkin;
                this.checkout = checkout;
            }
            if (numberRoom > 0)
            {
                this.numberRoom = numberRoom;
            } else
            {
                throw new Exception("The room number needs > 0");
            }
        }

        public int duration()
        {
            TimeSpan timestamp = this.checkout.Subtract(this.checkin);
            return (int)timestamp.TotalDays;
        }

        public void updateDate(DateTime checkin, DateTime checkout) {
            DateTime now = DateTime.Now;
            if (checkout < now || checkin < now)
            {
                throw new Exception("Reservation dates for update must be future dates");
            } else if (checkout <= checkin)
            {
                throw new Exception("Check-out date must be after check-in date");
            }
            this.checkin = checkin;
            this.checkout = checkout;
        }

        public override string ToString()
        {
            return "Room "
                + this.numberRoom
                + ", check-in: "
                + checkin.ToString("dd/MM/yyyy")
                + ", check-out: "
                + checkout.ToString("dd/MM/yyyy")
                + ", "
                + duration()
                + " nights";
        }
    }
}
