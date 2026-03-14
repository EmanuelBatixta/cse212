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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // set a new array with the input length
        // create e loop for (To each number untill length i will multiply the number of input)
        // The result will be add in the new array 
        // Return this new array

        var arr = new double[length];
        for (int i = 0; i < length; i++) {
            arr[i]= number * (i+1);
        }
        return arr;
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //create two new lists i will call 'a' and 'b'
        //I will split the 'data' list and save data in list a
        //I will use the remaining number to save in list b
        //clear data
        //i will merge both list (a and b) in list data

        var a = new List<int>(); 
        var b = new List<int>();

        a = data.GetRange(data.Count- amount, amount);
        b = data.GetRange(0, data.Count - a.Count);

        data.Clear();
        data.AddRange(a);
        data.AddRange(b);
        Debug.WriteLine(data);
    }
}
