using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class RaceLawnMower : RaceCar
    {
        public RaceLawnMower()
        {
            Name = "Race Lawn Mower";
            TopSpeed = 20;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts");
        }
        public override void Brake()
        {
            Console.WriteLine($"The {Name} comes to an abrupt halt!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name}'s engine stops");
        }
    }
}