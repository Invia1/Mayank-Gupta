using System;

class bank
{
    int amount;
    string pname;

    bankDetails details=new bankDetails();

    public int AMOUNT
    {
        get
        {
            return amount;
        }
        set
        {
            amount=value;
            if(amount<=10000)
            {
                
                details.creditAmount();
            }
            else
            {
                details.requiredAmount();
            }
        }
    }
    public string PNAME
    {
        get
        {
            return pname;
        }
        set
        {
            pname=value;
            if(string.IsNullOrEmpty(pname))
            {
            details.empty();
            
            Console.WriteLine("Enter Your Name :- ");
            string n=Console.ReadLine();
            n=pname;
            }
        
        }
    }
}
class bankDetails 
{
    public void empty()
    {
        Console.WriteLine("You can not leave this section blank.");
    }
    public void requiredAmount()
    {
        Console.WriteLine("Sorry!!Amount is less than needed. Not enough money to go for shopping.");
        
    }
    public void creditAmount()
    {
        Console.WriteLine("Wait for money to be debited.");
    }

    public void personAccountDetails()
    {
        bank obj= new bank();
        Console.WriteLine("Enter your name : ");
        obj.PNAME=(Console.ReadLine());
        
        Console.WriteLine("Amount you need to debit is : ");
        obj.AMOUNT=int.Parse(Console.ReadLine());
        
        
    }
}
class person
{
     public static void Main()
     {
        
        var pDetails = new bankDetails();
        pDetails.personAccountDetails();
     }
}
