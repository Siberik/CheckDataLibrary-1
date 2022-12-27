using CheckDataLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace validStringData
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// проверка VIN на пустую строку
        /// </summary>
        [TestMethod]
        public void Check_Vin_StringEmpty_returnedFalse()
        {
            //Arange
            string vin = String.Empty;
            int year = 2000;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// проверка VIN на 17 пробелов
        /// </summary>
        [TestMethod]
        public void Check_Vin_17Blanck_returnedFalse()
        {
            //Arange
            string vin = "                 ";
            int year = 2000;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// проверка VIN на маленькую длину VIN
        /// </summary>
        [TestMethod]
        public void Check_Vin_SmallLenght_returnedFalse()
        {
            //Arange
            string vin = "123";
            int year = 2000;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// проверка VIN на прошлые года
        /// </summary>
        [TestMethod]
        public void Check_Vin_PrevYear_returnedFalse()
        {
            //Arange
            string vin = "JHMCM56557C404453";
            int year = 2000;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// проверка VIN на соответсвующие условия
        /// </summary>
        [TestMethod]
        public void Check_Vin_NormalYear_returnedFalse()
        {
            //Arange
            string vin = "JHMCM56557C404453";
            int year = 2000;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// проверка VIN на будущий год
        /// </summary>
        [TestMethod]
        public void Check_Vin_NextYear_returnedFalse()
        {
            //Arange
            string vin = "JHMCM56557C404453";
            int year = 2077;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);

        }
        /// <summary>
        /// проверка VIN на будущий год
        /// </summary>
        [TestMethod]
        public void Check_Vin_SpecialSymbols_returnedFalse()
        {
            //Arange
            string vin = "JHMCM56557C404453+";
            int year = 2077;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// проверка VIN на будущий год
        /// </summary>
        [TestMethod]
        public void Check_Vin_ForboddenSymbolsI_returnedFalse()
        {
            //Arange
            string vin = "JHMCM56557C40445I";
            int year = 2077;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// проверка VIN на будущий год
        /// </summary>
        [TestMethod]
        public void Check_Vin_ForboddenSymbolsQ_returnedFalse()
        {
            //Arange
            string vin = "JHMCM56557C40445Q";
            int year = 2077;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
        public void Check_Vin_ForboddenSymbolsO_returnedFalse()
        {
            //Arange
            string vin = "JHMCM56557C40445Q";
            int year = 2077;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
    }
}
