using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionUsingFalse
{
   public abstract class Person
    {
        public abstract void Breath();
        public abstract void Blink();
        public abstract void GoWork();
    }

    public class Baby : Person
    {
        public override void Breath()
        {
            Console.WriteLine("Get Breath");
        }
        public override void Blink()
        {
            Console.WriteLine("Blinked");
        }

        public override void GoWork()
        {
            Console.WriteLine("Babies can not go to work");
        }
    }

    public class Young : Person
    {
        public override void Breath()
        {
            Console.WriteLine("Get Breath");
        }
        public override void Blink()
        {
            Console.WriteLine("Blinked");
        }
        public override void GoWork()
        {
            Console.WriteLine("Go to work");
        }
    }

    public class Adult : Person
    {
        public override void Breath()
        {
            Console.WriteLine("Get Breath");
        }
        public override void Blink()
        {
            Console.WriteLine("Blinked");
        }

        public override void GoWork()
        {
            Console.WriteLine("Go to work");
        }
    }

}
