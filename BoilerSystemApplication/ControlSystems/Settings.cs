using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoilerSystem.ControlSystems
{
    public static class Settings
    {
        static public double T { get; } = 42;
        static public double Gain1 { get; } = 0.2;
        static public double Gain2 { get; } = 0.2;
        //static public double Kin { get; } = 0.0;
        //static public double Kout { get; } = 0.0;
        static public double WaterLevelLimit { get; } = 1;
        static public double MaxInputStream { get; } = 0.2;
        static public double MaxOutputStream { get; } = 0.2;
        static public double RecommendedStep { get; } = 0.01;
        static public double Delay { get; } = 1.5;
        static public double Interference { get; } = 0.015;
    }
}
