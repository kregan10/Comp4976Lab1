using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompoundInterestLibrary.Models
{
    public class FutureValue
    {
        public double principle;
        public double interestRate;
        public double numOfCompoundsPerYear;
        public int numOfYears;

        public FutureValue(string principle, string interestRate, string numOfCompoundsPerYear, string numOfYears)
        {
            this.principle = Convert.ToDouble(principle);
            this.interestRate = Convert.ToDouble(interestRate);
            this.numOfCompoundsPerYear = Convert.ToDouble(numOfCompoundsPerYear);
            this.numOfYears = Convert.ToInt32(numOfYears);
        }
        
        public double calcPresentValue()
        {
            return principle * Math.Pow((1 + (interestRate / numOfCompoundsPerYear)), (numOfCompoundsPerYear * numOfYears));
        }
    }
}
