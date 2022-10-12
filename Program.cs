// The program shows the second digit of 3-digit-number

using System;
class Program
{
    // function without any return type declaration  
    public int GetNumber(string VarName)
    {
        int res;
        string input;
        bool is_number = false;
        bool is_3d_number = false;
        do
        {
            Console.WriteLine(String.Format("Enter 3 digit number: {0} = ", VarName));
            input = Console.ReadLine();
            
            is_number = int.TryParse(input, out res);
            
            is_3d_number = false;
            if (is_number) {
                 is_3d_number = TestNumber_3c(res);
            }

            if (!is_3d_number) {
                Console.WriteLine(String.Format("The number {0} is not 3 digit", res));
            }
        } while (!is_number ||  !is_3d_number);

        return res;
    }
    
    public bool TestNumber_3c(int num) {
        
        if (num >= 100 && num < 1000) {
            return true;
        } else {
            return false;
        }
    }

    public int[] ConvertNumberToArrayOfDigit(int num)
    {
        int Size = 3;
        int[] DigitOfNumber = new int[Size];
        int Rest = 0;
        int LastNumber = num;
        int Base = 10;
        for (int i = 0; i < Size; i++)
        {
            Rest = LastNumber % Base;
            DigitOfNumber[i] = Rest;
            LastNumber = (LastNumber - Rest) / Base;
        }
        return DigitOfNumber;
    }
    public static void Main(string[] args)
    {
        Program pr = new Program(); // Creating a class Object  
        Console.WriteLine("The program calculates the parity of a numbers.");

        string VarName_N = "N";
        int N = pr.GetNumber(VarName_N);
        int[] DigintOfNumber = pr.ConvertNumberToArrayOfDigit(N);
        Console.WriteLine(String.Format("Num = {0}*10^2 + {1}*10 + {2}", DigintOfNumber[2], DigintOfNumber[1], DigintOfNumber[0]));
        Console.WriteLine(String.Format("Second digit of number is {0} ", DigintOfNumber[1]));
    }
}