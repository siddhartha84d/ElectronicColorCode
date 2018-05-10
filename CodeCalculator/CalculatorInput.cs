using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCalculator
{
    public class CalculatorInput
    {
        //(values are from wikipedia Electronic Color Code)
        //Dictionary values for significant numbers
        public Dictionary<string, int> significantNumbers;

        //Dictionary values for multiplier
        public Dictionary<string, int> multiplier;

        //Dictionary values for tolerance
        public Dictionary<string, double> tolerance;

        //This function is supposed to pass the color-code values defined below.
        public CalculatorInput()
        {
            //significant color codes, mostly used for band A and B.            
            significantNumbers = new Dictionary<string, int>
            {
                    {"black", 0},
                    {"brown", 1},
                    {"red", 2},
                    {"orange", 3},
                    {"yellow", 4},
                    {"green", 5},
                    {"blue", 6},
                    {"violet", 7},
                    {"gray", 8},
                    {"white", 9}
            };

            //multiplier numbers for band C.
            multiplier = new Dictionary<string, int> {
                    {"pink", -3},
                    {"silver",  -2},
                    {"gold",  -1},
                    {"black", 0},
                    {"brown", 1},
                    {"red", 2},
                    {"orange",3},
                    {"yellow", 4},
                    {"green", 5},
                    {"blue",  6},
                    {"violet", 7},
                    {"gray", 8},
                    {"white", 9}
            };


            //tolerance numbers for band D
            tolerance = new Dictionary<string, double> {
                    {"pink", 0},
                    {"white", 0},
                    {"black", 0},
                    {"orange", 0},
                    {"silver", 0.10},
                    {"gold", 0.05},
                    {"brown",  0.01},
                    {"red", 0.02},
                    {"yellow", 0.05},
                    {"green", 0.005},
                    {"blue", 0.0025},
                    {"violet", 0.001},
                    {"gray", 0.0005}
            };

        }
    }
}
