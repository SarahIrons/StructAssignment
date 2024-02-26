using System;
//STRUCT ASSIGNMENT

//Perform these actions and create a console app that includes the following:


//Create a struct called Number and give it the property “Amount” and have it be of data type decimal.

//In the Main() method, create an object of data type Number and assign an amount to it.

//Print this amount to the console.
namespace StructAssignment
{
    class Program
    {
        public static void Main()
        {
            Number cost = new Number(); //instantiate new instance of Number
            cost.Amount = 34.56M; //designate that this is decimal with "M" at end of the number
          Console.WriteLine(cost.Amount); //variable name 'cost' put through struct (cost.Amount) to output the reading of 34.56
        }
    }
}
