using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    public class Festival : Concert
    {
        public Festival(string performer, DateTime data, string venue, int number_of_seats) : base(performer, data, venue, number_of_seats)
        {
            name = "Фестеваль";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
