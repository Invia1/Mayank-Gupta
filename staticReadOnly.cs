class college
{

    public static readonly string policy;
      static college()
    {
        policy = "study everyday";
    }
    
    public static void collegeDetail(){
        Console.WriteLine("Policy : " + policy);
       
    }

       
    public static void Main(){
        
        collegeDetail();
    }
}
