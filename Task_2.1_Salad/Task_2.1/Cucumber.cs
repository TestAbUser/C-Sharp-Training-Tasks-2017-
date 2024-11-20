using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAM_Pre_Selection_dotNET_p2
{
    public class Cucumber: Vegetable 
    {

    private const double WATER = 95;
    private const double PROTEINS = 0.8;
    private const double FATS = 0.1;
    private const double CARBOHYDRATES = 2.5;

    public Cucumber(String name, String colour, double weight): base(name, colour, weight)
    {

    }

   
    public override void eat()
    {
        Console.WriteLine("\"" + this + "\"has been digested!");
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
