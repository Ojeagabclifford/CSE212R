using System.Data;
using System.Diagnostics;
public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        //This is  my plan for this assignment MultiplesOf function
        // First I will neead:

        // vairable 
        //  for loop 
        // double array

        // my variable will be:
        // names:

        // checker
        // Result
        // Doubles this will be an array variable

        //Checker this variable will work with the for loop 
        //it will be the one to check againts  the last number e.g [checher == length]. 
        // When it  increase to the ammount of the last number before it stop 
        // increasing.

        // The chceker value will also add the result to the double array through the index.  
        // When it value = 0 it will be add to the first place of the array

        // The checeker virable will also be the one which will be mutiply by the first number e.g[number * checker]

        //  Any value that result from this two value will then be save in my 
        // Result virable.
        // This virable will then be the value input in to the array at value index of the checker

        // THE FOR LOOP
        // The for loop will be the one to run untill the checker variable value is equal to the value of the last number.

        // creating an array that will amount the size of the lenght number or last number to make it fixed array
        
        double[] doubles = new double[length];
        //

        //
        //int count = 0;
        // The for loop that countine to run unless the checker variable value is equal to the value of the last number.
        for (int checker = 1; checker <= length; checker++) // using an expression to chcek the two value.
        {
            //the checker virable will be mutiply by the first number 
            //the result will be store a double virable called 


            double result = number * checker; // the will resuilt in[3,6,9] if the frist value is 3 and the lenght is 3
            doubles[checker - 1] = result;
            // Debug.WriteLine("result");
           
          //  count++;


        }
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
           
             
            return doubles; // replace this return statement with your own
    }


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
       public static void RotateListRight(List<int> data, int amount)
    {
        // THIS IS MY PLAN FOR THIS PROGRAM
        // In this program i will need a getRange, a RemoveRange, and InstertRange funtion
    // The getRange funtion will be the one that will help me to slice the list and retuned the last item  from the list 
    //starting from a particular amount
    // InsertRange will be the one to int the data that hads been store in dataValues variable i have created into the list starting at index 0




        // I will need to slice the list.
        var dataValues = data.GetRange(data.Count - amount, amount);


        // this will reomve from the data the psome part starting from the index of data.count -amount the resuit of this input 
        // will be the starting index and the amount will be the number of item to remove.
        data.RemoveRange(data.Count - amount, amount);


        // this will insert this data that hads been store in dataValues into the data staring at index 0
        data.InsertRange(0, dataValues);








        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
