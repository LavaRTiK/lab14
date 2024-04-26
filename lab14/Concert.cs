using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    public class Concert : Entety
    {
        public string name;
        public string performer;
        public DateTime data;
        public string venue;
        public int number_of_seats;

        public Concert(string performer , DateTime data , string venue,int number_of_seats) {
            this.performer = performer;
            this.data = data;
            this.venue = venue;
            this.number_of_seats = number_of_seats;
            this.name = "Концерт";
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} {2} {3} {4} {5}",id,name,performer,data,venue,number_of_seats);
        }
    }
}
