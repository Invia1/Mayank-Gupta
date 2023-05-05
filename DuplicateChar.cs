                   
public class DuplicateCharacters  
{  
    public static void Main()  
    {  Console.Write("Enter the string");
            String str = Console.ReadLine();  
        int count;        
        char[] ch = str.ToCharArray();  
          
        
        for(int i = 0; i <ch.Length; i++) {  
            count = 1;  
            for(int j = i+1; j <ch.Length; j++) {  
                if(ch[i] == ch[j] && ch[i] != ' ') {  
                    count++;  
                   
                    ch[j] = '0';  
                }  
            }  
            
            if(count > 1 && ch[i] != '0')  
                Console.WriteLine("{0},{1}",ch[i],count);  
        }  
    }  
}