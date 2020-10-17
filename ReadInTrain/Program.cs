using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInTrain
{
    class Program
    {
        private static Travel travel;

        static void Main(string[] args)
        {
            int hourTrain = readNumberBetween(0,1000);
            int hourReader = readNumberBetween(0, hourTrain);
            int levelLightMin = readNumberBetween(30, 70);
            travel = new Travel(hourTrain, hourReader, levelLightMin, levelLightMin + 30);

            for(int i = 0; i < hourTrain; i++)
            {
                int number = readNumberBetween(0, 100);
                travel.addToLevel(new LevelLight(number, i + 1));
            }

            Console.Clear();

            foreach(LevelLight l in travel.levels)
            {
                if (l.canRead(travel.levelMinForRead, travel.levelMaxForRead))
                {
                    Console.Write(" {0} : {1},  ", l.hour, l.level);
                }
            }

            Console.ReadKey();

        }

        private static int readNumberBetween(int v1, int v2)
        {
            int number = v1 - 1;
            do
            {
                try
                {
                    Console.WriteLine("Digite un numero entre {0} y {1}", v1, v2);
                    number = int.Parse(Console.ReadLine());
                }catch(Exception e) { }
            } while (number < v1 || number > v2);
            return number;
        }


    }
}
