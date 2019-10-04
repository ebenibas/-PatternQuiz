using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsQuiz
{
    //queston1
    //public  abstract class BookingFlightsFromWinnipeg
    //{


    //}
    //public interface CalCulateFees
    //{

    //    void Calculatefee();
    //}

    //public class Fromwinnipeg : CalCulateFees
    //{
    //    public int Fee { get; set; }
    //    public int Month { get; set; }

    //    public int discountNumber { get; set; }
    //    public void discount()
    //    {
    //        Fee = Fee * discountNumber / 100;
    //    }
    //    public void Calculatecfee()
    //    {
    //        if(Month == 12)
    //        {
    //            Fee = Fee * Fee;
    //        }
    //        else if (Month == 6 )
    //        {


    //        }
    //    }

    //    public void Calculatefee()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome gamer");

            Console.WriteLine("Welcome to this game! Today you become a Hero or a loser!");
            Console.Write("Please enter your name:");
            Console.WriteLine("the weapon you have chosen is sword");
            Console.WriteLine("the enemy you have chosen is boss");
            Console.WriteLine("upgrade weapon");
            Console.ReadLine();
        }
       
    }
    public abstract class WeaponUpgrade
    {
        public String description = "Upgrade Weapon";
        public virtual String getDescription()
        {
            return description;
        }
        public abstract double Cost();
    }
    public abstract class CondimentDecorator : WeaponUpgrade
    {
        public abstract override String getDescription();
    }
   
    }
}
