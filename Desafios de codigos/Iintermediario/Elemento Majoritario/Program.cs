// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        int[] num = new int[n];
    
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0 ; i < n; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));
        
    }
public static int MajorityElement(int[] nums)
  {
    int major = 0;
    int countAux = 0;
     
    for (int a = 0; a < nums.Length; a++)
    {
     int count = 0;
      
     for (int b = 0; b < nums.Length; b++)
     {
      if (nums[a] == nums[b])
      {
       count++;
      }
     }
      
     if (count > countAux)
     {
      major = nums[a];
      countAux = count;
     }
    }
    return major;
  }
}