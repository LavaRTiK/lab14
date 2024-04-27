using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace lab14
{
    [JsonDerivedType(typeof(Concert), typeDiscriminator: "Concert")]
    [JsonDerivedType(typeof(Festival), typeDiscriminator: "Festival")]
    public class Concert : Entity
    {
        public string name { get; set; }
        public string performer { get; set; }
        public DateTime data { get; set; }
        public string venue { get; set; }
        public int number_of_seats { get; set; }

        public Concert(string performer , DateTime data , string venue,int number_of_seats) {
            this.performer = performer;
            this.data = data;
            this.venue = venue;
            this.number_of_seats = number_of_seats;
            this.name = "Конецерт";
        }

        public override string ToString()
        {;
            return string.Format("{0}: {1} {2} {3} {4} {5}",id,name,performer,data,venue,number_of_seats);
        }
    }
}
