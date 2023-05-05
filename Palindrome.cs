// See https://aka.ms/new-console-template for more information

class palindrom
{
    public static void Main()
    {
        
         Console.Write("Enter string");  
         String str = Console.ReadLine();  	// getting value from the user
         String rev = "";  				//empty string in which we are going to store each character in reverse order
         String  temp =str;    			// a temporary variable that can store the original string so that we compare it with the reverse string later on
         for(int i = str.Length-1; i>=0;i--)  // using for loop in reverse direction 
         {
            rev=rev+str[i];         		// concatenate each character with the rev, the main logic of reversing the string
         }

        if (temp==rev)              	// compare reversed string with the original string that can store in the temp variable
        { Console.Write("Palindrome");  	// if both are same then palindrome string
        }
        else
        {
            Console.Write("Not Palindrome"); // otherwise not palindrome string will print
        }
 
    }
}