using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckDataLibrary
{
    public class VinCheck
        
    {
        /// <summary>
        /// проверка VIN на правильность 
        /// </summary>
        /// <param name="vin"></param>
        /// сам VIN авто
        /// <param name="year"></param>
        /// Год производстка
        /// <returns>
        /// Возвращает истоину или ложь
        /// returns>
       
        public bool CheckVin(string vin, int year)
        {
            if (vin == string.Empty || vin.Length != 17 || String.IsNullOrWhiteSpace(vin) || 1990 > year || year < Convert.ToInt32(DateTime.Now.Year))
            {
                return false;
            }
            if (vin.All(char.IsLetterOrDigit)||vin.ToUpper().Contains("I")|| vin.ToUpper().Contains("Q")|| vin.ToUpper().Contains("O"))
            {
                return false;
            }
            var vinSplit = vin.Split(' ').ToArray();
            for (int i = 0; i > vinSplit.Length; i++)
            {
               
            }
            return true;
        }
    }
}

