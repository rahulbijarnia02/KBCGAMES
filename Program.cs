using System.Collections;
using System.Linq;
public class Program
{

    public static void Main()
    {
        QuestionData Emp =new QuestionData();
        var employ=Emp.GetEmployee();
        var Question = (from e in employ
                             select e);
        
        Random num = new Random();
        var res=Question.Skip(num.Next(8)).Take(5);
        int i=0;
        Console.WriteLine("Welcome ");
        Console.WriteLine("Enter your Name");
        Console.ReadLine();
        Console.WriteLine("First Question");
        foreach(Employee s in res){
            if(i<2){
                Console.WriteLine(s.Question);
                Console.WriteLine(s.Ans);
                
                    int ans=Convert.ToInt32(Console.ReadLine());
                    while(ans<1||ans>4){
                        Console.WriteLine("Please enter number from 1 to 4");
                        ans=Convert.ToInt32(Console.ReadLine());
                    }
                    if(s.Ansid==ans){
                        Console.WriteLine("correct ans");
                    }else{
                        Console.WriteLine("incorrect ans");
                        i++;
                    }
            }else{
                break;
            }  
        }
        if(i==2){
            Console.WriteLine("Better luck Next time");
        }else{
            Console.WriteLine("You have won 1 lakh rupee");
        }
         
    }

   
}