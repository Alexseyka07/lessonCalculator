namespace lessonCalculator.Models{
public interface INumber
{
    public double Num1 {get; set;}
    public double Num2 {get; set;}
    public double Result {get; set;}

    public void Operation();
}
}