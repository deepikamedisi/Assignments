using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBaseTest3
{
    class Cricket
    {
        public void Pointscalculation(int no_of_matches)
        {
            int[] scores = new int[no_of_matches];
            double sum = 0;
            for(int i=0;i<no_of_matches;i++)
            {
                Console.WriteLine($"Enter score for match{i + 1}");
                int score = int.Parse(Console.ReadLine());
                sum += score;
            }
            double average = sum / no_of_matches;
            Console.WriteLine($"The sum of the scores {sum}");
            Console.WriteLine($"The average score {average}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no.of matches");
            int no_of_matches = Convert.ToInt32(Console.ReadLine());
            Cricket cricketmatch = new Cricket();
            cricketmatch.Pointscalculation(no_of_matches);
            
            Console.ReadLine();
        }
    }
}
