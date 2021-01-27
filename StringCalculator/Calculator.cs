using System;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbersAsString)
        {

            if(numbersAsString==string.Empty )
            {

                return 0;

            }
            if (int.Parse(numbersAsString) is int)
            {
                return int.Parse(numbersAsString);
            }

            string[] val=  numbersAsString.Split(',');
            if (val.Length==2)
            {
                    return int.Parse( val[0])  + int.Parse(val[1]);
            }

            //string[] valinft = numbersAsString.Split(',');
            if (val.Length > 2)
            {
                int length = val.Length;
                int sumNum=0;
                while (length>0)
                {
                    sumNum = sumNum + int.Parse(val[length]);
                    length--;
                }
                return sumNum;
            }

            return numbersAsString.Length;

            //throw new NotImplementedException();
        }
    }
}