using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicColorCode.Models
{
    public class ColorSelector
    {
        //(values are from wikipedia Electronic Color Code)
        //Dictionary values for significant numbers
        public Dictionary<string, string> significantNumbers;

        //Dictionary values for multiplier
        public Dictionary<string, string> multiplier;

        //Dictionary values for tolerance
        public Dictionary<string, string> tolerance;

        //This function is supposed to pass the color-code values defined below.
        public ColorSelector()
        {
            //significant color codes, mostly used for band A and B.            
            significantNumbers = new Dictionary<string, string>
            {
                    {"black", "0 Black"},
                    {"brown", "1 Brown"},
                    {"red", "2 Red"},
                    {"orange", "3 Orange"},
                    {"yellow", "4 Yellow"},
                    {"green", "5 Green"},
                    {"blue", "6 Blue"},
                    {"violet", "7 Violet"},
                    {"gray", "8 Gray"},
                    {"white", "9 White"}
            };

            //multiplier numbers for band C.
            multiplier = new Dictionary<string, string> {
                    {"pink", "×0.001 Pink"},
                    {"silver", "×0.01 Silver"},
                    {"gold", "×0.1 Gold"},
                    {"black", "×1 Black"},
                    {"brown", "x10 Brown"},
                    {"red", "x100 Red"},
                    {"orange", "x1000 Orange"},
                    {"yellow", "x10000 Yellow"},
                    {"green", "x100000 Green"},
                    {"blue", "×1000000 Blue"},
                    {"violet",  "×10000000 Violet"},
                    {"gray",  "×100000000 Gray"},
                    {"white", "×1000000000 White"}
            };


            //tolerance numbers for band D
            tolerance = new Dictionary<string, string> {
                    {"silver",  "± 10% Silver"},
                    {"gold",  "± 5% Gold"},
                    {"brown", "± 1% Brown"},
                    {"red", "± 2% Red"},
                    {"yellow", "± 4% Yellow"},
                    {"green", "± 0.5% Green"},
                    {"blue",  "± 0.25% Blue"},
                    {"violet", "± 0.1% Violet"},
                    {"gray", "± 0.05% Gray"}
            };

        }
    }
}
