using System;
						
public class Program
{
  public static Tuple<double,double,double,double> AddSubMultiDiv(double a, double b)
  {
      return new Tuple<double, double,double,double>((a+b),(a-b),(a*b),(a%b));
  }
  public static void Main(string[] args)
  {
      Tuple<double, double, double, double> output = Program.AddSubMultiDiv(6,3);
      Console.WriteLine("sum=" +output.Item1+ "sub=" +output.Item2 + "Multi value= "+output.Item3 + "div=" +output.Item4);
      Console.ReadLine();
      Tuple<double, double, double, double> tuple;
  }
}
