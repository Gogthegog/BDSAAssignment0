using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            
            string yearstring = Console.ReadLine();
        

             try
            {
                int year = Convert.ToInt32(yearstring);
            
                if(IsLeapYear(year))
                {
                    Console.WriteLine("yay");
                }
                else
                {
                    Console.WriteLine("nay");
                }
            }
            catch(Exception e)
            {
                try
                {
                    throw new ArgumentException("Input has to be an integer equal to or more than 1582.");
                }
                catch(ArgumentException ie)
                {
                    Console.WriteLine(ie.Message);
                }
            }
        }

        public static bool IsLeapYear(int year)
        {
           
            if(year<1582){
                throw new ArgumentException("Input has to be an integer equal to or more than 1582.");
            }
            else
            {
                if(year%4 == 0)
            {
                if(year%100 == 0)
                {
                    if(year%400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                         return false;
                    }
                }
                else
                {
                    return true;
                }
                
            }
            else
            {
                return false;
            }
            }
        }
            
        }
}
