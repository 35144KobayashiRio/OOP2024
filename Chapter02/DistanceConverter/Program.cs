﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フィードからメートルへの対応表を出力
                PrintFeetToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                //メートルからフィートへの対応表を出力
                PrintMeterToFeetList(int.Parse(args[1]), int.Parse(args[2]));
            }
        }

        private static void PrintFeetToMeterList(int start, int stop) {
            FeetConverter fc = new FeetConverter();
            for (int feet = 1; feet <= 10; feet++) {
                double meter = fc.ToMeter(feet);
                Console.WriteLine("{0}ft ={1:0.0000}m", feet, meter);
            }
        }

        private static void PrintMeterToFeetList(int start, int stop) {
            FeetConverter fc = new FeetConverter();
            for (int meter = 1; meter <= 10; meter++) {
                double feet = fc.FromMeter(meter);
                Console.WriteLine("{0}m ={1:0.0000}ft", meter, feet);
            }
        }
    }
}