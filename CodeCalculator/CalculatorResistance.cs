using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCalculator
{
    public class CalculateResistance : IOhmValueCalculator
    {
        /// <summary>
        /// Calculates the Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>

        public double CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            int ohmBandA = 0;
            int ohmBandB = 0;
            int multiplier = 0;
            double tolerance = 0.0;

            CalculatorInput calInput = new CalculatorInput();


            if (!string.IsNullOrEmpty(bandAColor) && calInput.significantNumbers.ContainsKey(TrimColorName(bandAColor)))
            {
                ohmBandA = calInput.significantNumbers[TrimColorName(bandAColor)];
            }

            if (!string.IsNullOrEmpty(bandBColor) && calInput.significantNumbers.ContainsKey(TrimColorName(bandBColor)))
            {
                ohmBandB = calInput.significantNumbers[TrimColorName(bandBColor)];
            }

            if (!string.IsNullOrEmpty(bandCColor) && calInput.multiplier.ContainsKey(TrimColorName(bandCColor)))
            {
                multiplier = calInput.multiplier[TrimColorName(bandCColor)];
            }

            if (!string.IsNullOrEmpty(bandDColor) && calInput.tolerance.ContainsKey(TrimColorName(bandDColor)))
            {
                tolerance = calInput.tolerance[TrimColorName(bandDColor)];
            }
            else
            {
                //No Color
                tolerance = 0.20;
            }

            int ohmValue = Convert.ToInt32(string.Format("{0}{1}", ohmBandA, ohmBandB));

            //Here both maxResistance and minResistance can be calculated based on tolerance, for now returning only upper bound value.
            double maxResistance = (ohmValue * Math.Pow(10, multiplier) * (1 + tolerance));

            //To calculate the minimum resistance use (1 - tolerance) and change the return type to return both min and max values.

            // return resistance value range.
            return maxResistance;

        }

        private string TrimColorName(string bandColor)
        {
            return bandColor.ToLower().Trim().Replace(",", string.Empty);
        }
    }
}
