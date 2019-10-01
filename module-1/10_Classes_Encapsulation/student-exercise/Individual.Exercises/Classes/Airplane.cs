using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;

            AvailableFirstClassSeats = TotalFirstClassSeats - BookedFirstClassSeats;
            AvailableCoachSeats = totalCoachSeats - BookedCoachSeats;

        }
        public string PlaneNumber { get;  }
        public int BookedFirstClassSeats { get; private set; }
        public int AvailableFirstClassSeats { get;  }
        public int TotalFirstClassSeats { get;  }
        public int BookedCoachSeats { get; private set; }
        public int AvailableCoachSeats { get;  }
        public int TotalCoachSeats { get;  }



        bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass == true)
            {
                 totalNumberOfSeats = totalNumberOfSeats + BookedFirstClassSeats;
            }
            else if (forFirstClass == false)
            {
                totalNumberOfSeats = totalNumberOfSeats + BookedCoachSeats;
            }
            return true; // didn't get this part right. I would like to get with someone about this after the pair exercises tomorrow.
        }


    }
}

