using System;
using System.ComponentModel;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            //CONVERSION (explicit, implicit, Convert)

            //1. CHAR CONVERSION 
            char sex = 'М';//to string
            string sex1 = Convert.ToString(sex); //"M"

            char place = '3';//to int
            int place1 = (int)place;//"3"

            char hasFingerPrints = '0';//to boolean
            bool hasFingerPrints1 = Convert.ToBoolean(hasFingerPrints);//not compiling

            //2. STRING CONVERSION           
            string hasPhotoString = "True";//to bolean
            bool hasPhotoString1 = Convert.ToBoolean(hasPhotoString);//"True"

            string flatNumber = "34";//to int
            int flatNumber1 = Convert.ToInt32(flatNumber);//"34"

            string visaPriceString = "34,23";//to float
            float visaPriceString1 = Convert.ToSingle(visaPriceString);//"34,23"

            string photoPriceString = "7.23";//to float
            float photoPriceString1 = Convert.ToSingle(photoPriceString);//"7,23"


            //3. BOOL CONVERSION
            bool hasFree2Pages = false;//to string, to char, to int
            string hasFree2Pages1 = Convert.ToString(hasFree2Pages);//"false"
            char hasFree2Pages2 = Convert.ToChar(hasFree2Pages);//
            int hasFree2Pages3 = Convert.ToInt32(hasFree2Pages);//
                   
            //4. DECIMAL CONVERSION
            double visaPrice = 60;//to int, to string
            int visaPrice1 = Convert.ToInt32(visaPrice);//"60"
            string visaPrice2 = Convert.ToString(visaPrice);//

            double finterPrintsPrice = 55.2;//to int, to string
            int finterPrintsPrice1 = Convert.ToInt32(finterPrintsPrice);//"55"
            string finterPrintsPrice2 = Convert.ToString(finterPrintsPrice);//

            //4. INT CONVERSION
            int birthYear = 2000;//to string, to double, to char
            char birhtYearChar = (char)birthYear;//
            double birthYear1 = (double)birthYear;//"2000,0"
            string birthYear2 = Convert.ToString(birthYear);//

            int hasPhotoInt = 1;//to boolean
            bool hasPhotoInt1 = Convert.ToBoolean(hasPhotoInt);//
        }
    }
}
