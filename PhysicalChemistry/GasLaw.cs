using System;


namespace PhysicalChemistry
{
    public class Gaslaw
    {
        /// <summary>
        /// using the Ideal gas law, calculate the pressure, volume, temperature and moles.
        /// <para>Mark the missing variable with null</para>
        /// </summary>
        /// <returns>Variable marked <see langword="null"/></returns>
        /// <param name="pressure">Pressure.</param>
        /// <param name="volume">Volume.</param>
        /// <param name="temperature">Temperature.</param>
        /// <param name="moles">Moles.</param>
        public double Ideal(double? pressure, double? volume, double? temperature, double? moles)
        {
            double gasconstant = 8.31446261815324;

            if (pressure==null)
            {
                pressure = ((moles * gasconstant * temperature) / volume);
                return Convert.ToDouble(pressure);
            }
            else if (volume==null)
            {
                volume = ((moles * gasconstant * temperature) / pressure);
                return Convert.ToDouble(volume);
            }
            else if (temperature==null)
            {
                temperature = ((pressure * volume) / (gasconstant * moles));
                return Convert.ToDouble(temperature);
            }
            else if (moles==null)
            {
                moles = ((pressure * volume) / (gasconstant * temperature));
                return Convert.ToDouble(moles);
            }
            else return 0;
        }

        /// <summary>
        /// Returns [a,b,critical volume]
        /// </summary>
        /// <returns>The Coefficients.</returns>
        /// <param name="criticalpressure">Critical pressure.</param>
        /// <param name="criticaltemperature">Critical temperature.</param>
        public double[] VDWCoefficients(double criticalpressure, double criticaltemperature)
        {
            //estimate the coefficients a and b

            double[] coefficients = new double[3];

            double gasconstant = 8.31446261815324;
           

            coefficients[0] = (((27 * gasconstant * gasconstant * criticaltemperature * criticaltemperature) / (64 * criticalpressure))*1.0e-4);
            coefficients[1] = ((gasconstant * criticaltemperature) / (8 * criticalpressure))*1.0e-3;
            coefficients[2] = (3 * coefficients[1]);

            return coefficients;
        }
    }
}
