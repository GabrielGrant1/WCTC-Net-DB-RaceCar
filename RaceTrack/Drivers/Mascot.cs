using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Mascot : Driver
    {
        public Mascot(RaceCar car) : base(car)
        {
            Name = "Mascot";
            SkillLevel = 15;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}