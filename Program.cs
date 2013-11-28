using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //%を使わないでFizzBuzz
            Console.Write("Limit =");
            int limit = Int32.Parse(Console.ReadLine())+1;

            int[] flagArray = new int[limit];
            for(int i = 0;i < limit; i++){
                flagArray[i] = 0;//配列の初期化
            }

            int loopCount = 1;
            for (int i = 3; i < limit; i = 3 * loopCount)
            {
                flagArray[i]++;
                loopCount++;
            }
            loopCount = 1;
            for (int i = 5; i < limit; i = 5 * loopCount)
            {
                flagArray[i] += 2;
                loopCount++;
            }

            //結果出力
            for(int i = 1;i < limit;i++){
                int result =  flagArray[i];
                switch(result){
                    default:
                        Console.WriteLine(i);
                        break;
                    case 1:
                        Console.WriteLine("Fizz");
                        break;
                    case 2:
                        Console.WriteLine("Buzz");
                        break;
                    case 3:
                        Console.WriteLine("FizzBuzz");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
