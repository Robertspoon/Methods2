using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WOWIE");

            int score;
            score = 0;
            score = AddScore(score, 100);
            Console.WriteLine("Score: " + score);


            Console.ReadKey(true);
        }


        static int AddScore(int prevScore, int pointsEarned)
        {
            return (prevScore + pointsEarned);
        }
    }
}
