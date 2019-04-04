using System;

class MainClass {
  public static string CheckNums(int num1, int num2) { 
  
    // code goes here  
    /* Note: In C# the return type of a function and the 
       parameter types being passed are defined, so this return 
       call must match the return type of the function.
       You are free to modify the return type. */
    if (num2 > num1)
    {
    return "true";
    }
    else if (num1 > num2)
    {
        
    return "false";
    }
    else if (num1 == num2)
    {
        return "-1";
    }
    return " ";
            
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(CheckNums(Console.ReadLine()));
  } 
   
}
