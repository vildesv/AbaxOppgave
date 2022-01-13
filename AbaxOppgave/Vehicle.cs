using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxOppgave
{
    abstract class Vehicle
    {
        public string RegNo { get; }
        public int Effect { get; }

        protected Vehicle(string regNo, int effect)
        {
            RegNo = regNo;
            Effect = effect;
        }
        public virtual void PrintInformation()
        {
            Console.WriteLine($" - Reg.nr. = {RegNo}");
            Console.WriteLine($" - Effekt = {Effect}kw");
        }
        public abstract void Run();
    }
}
