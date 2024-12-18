using System.Text;

namespace Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("enter number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < number; i++) {
            //    Console.WriteLine(i+1);
            //}

            #region matching patern and cas gaurd

            //object num = 3.2;
            //switch (num)
            //{
            //    case int value:
            //        Console.WriteLine("number is integer");
            //        break;
            //    case double value:
            //        Console.WriteLine("number is double");
            //        break;
            //    case float value:
            //        Console.WriteLine("number is float");
            //        break;
            //    default:
            //        Console.WriteLine("no matching");
            //        break;

            //}
            //Console.WriteLine($"number is {num}");


            //int num = 4;
            //string result = num switch
            //{
            //    > 10 => " number is greater than 10",
            //    < 5 and > 1 => " number is less than 5 and greaet than 1 ",
            //    _ => "not matchin"

            //};
            //Console.WriteLine(result);

            #endregion

            #region while && do while
            //int number;
            //bool isparsed;
            //do
            //{
            //    Console.Write("enter even number : ");
            //    isparsed =   int.TryParse(Console.ReadLine(), out number);

            //} while (!isparsed || number % 2 ==1);
            //Console.WriteLine($"even number is {number}");

            #endregion

            #region string builder
                StringBuilder sb = new StringBuilder();

            #endregion
        }
    }
}
