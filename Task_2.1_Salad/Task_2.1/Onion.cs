using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAM_Pre_Selection_dotNET_p2
{
    public class Onion : Vegetable
    {

        private const double WATER = 89.8;
        private const double PROTEINS = 1.8;
        private const double FATS = 0.2;
        private const double CARBOHYDRATES = 7.3;

        public Onion(String name, String colour, double weight) : base(name, colour, weight)
        {

        }


        public override void eat()
        {
            Console.WriteLine("\"" + this + "\" has been digested!");
        }


        public override void cook()
        {
            this.value.setWater(WATER);
            this.value.setCarbohydrates(CARBOHYDRATES);
            this.value.setFats(FATS);
            this.value.setProteins(PROTEINS);
        }
    }
}
