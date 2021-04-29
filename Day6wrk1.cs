using System;
						
public class Program
{
  public static Tuple<double,double> AddMulti(double a, double b)
  {
      return new Tuple<double, double>((a+b),(a*b));
  }
  public static void Main(string[] args)
  {
      Tuple<double, double> output = Program.AddMulti(3.5,2.0);
      Console.WriteLine("sum=" +output.Item1+ "Multi value= "+output.Item2);
      Console.ReadLine();
      Tuple<int, string, double> tuple;// = new tuple<string,
  }
}