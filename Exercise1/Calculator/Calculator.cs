namespace Calculator;

public class Calculator
{
    public double Add(double one, double two) => one + two;

    public double Subtract(double one, double two) => one - two;

    public double Multiply(double one, double two) => one * two;
    


    public double Divide(double one, double two) => one / two;
    
    public double Power(double num, double exp) => Math.Pow(num, exp);
}