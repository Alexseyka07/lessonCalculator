using lessonCalculator.Models;

public class Div : INumber
{
    public double Num1 {get; set;}
    public double Num2 {get; set;}
    public double Result {get; set;}

    public void Operation(){
        Result = Num1 / Num2;
    }
}