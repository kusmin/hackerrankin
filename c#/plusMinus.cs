using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        Int32 length = arr.Count;
        int countPositives = 0;
        int countNegatives = 0;
        int countNeutros = 0;
        foreach (int element in arr){
            if(element > 0)
            {
                countPositives++;
            }
            else if(element < 0)
            {
                countNegatives++;
            }
            else 
            {
                countNeutros++;    
            }
        }
        double positives = (double)countPositives / length;
        double negatives = (double)countNegatives / length;
        double neutros = (double)countNeutros / length;

        Console.WriteLine(positives.ToString("F6"));
        Console.WriteLine(negatives.ToString("F6"));
        Console.WriteLine(neutros.ToString("F6"));   
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}