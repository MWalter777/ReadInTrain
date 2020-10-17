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
            int hoursTotal = 0;
            Console.WriteLine("Digite el numero de horas a permanecer en el tren");
            int hourTrain = readNumberBetween(0,1000);
            Console.WriteLine("Digite el numero de horas a leer");
            int hourReader = readNumberBetween(0, hourTrain);
            Console.WriteLine("Digite el numero minimo de luz que necesita para leer");
            int levelLightMin = readNumberBetween(30, 70);
            travel = new Travel(hourTrain, hourReader, levelLightMin, 95);

            Console.WriteLine("Digite el nivel de luz durante cada hora en el tren separados por espacios");
            readNumberBetween();

            Console.Clear();

            foreach(LevelLight l in travel.levels)
            {
                if (l.canRead(travel.levelMinForRead, travel.levelMaxForRead))
                {
                    Console.Write(" {0} : {1},  ", l.hour, l.level);
                    hoursTotal++;
                }
            }

            if (hoursTotal >= hourReader)
            {
                Console.WriteLine("Puedes leer las horas que seleccionaste, en total tienes {0} horas disponibles", hoursTotal);
            }else
            {
                Console.WriteLine("No puedes leer todo el tiempo establecido, solo tienes {0} horas disponibles", hoursTotal);
            }

            Console.ReadKey();

        }

        private static void readNumberBetween()
        {
            int hourTrain = travel.hourTrain;
            int salir = 0;
            do
            {
                string levelForHours = Console.ReadLine();
                string[] levels = levelForHours.Split(' ');
                Console.Write("length = {0}", levels.Length);
                if (levels.Length != hourTrain)
                {
                    Console.WriteLine("Error debe ingresar el nivel de luz de todas las horas ({0}) y solo numeros separados por espacios", hourTrain);
                }
                else
                {
                    try
                    {
                        List<LevelLight> level = new List<LevelLight>();
                        for(int i=0; i<levels.Length; i++)
                        {
                            int n = int.Parse(levels[i]);
                            if(n>=0 && n <= 100)
                            {
                                level.Add(new LevelLight(n, i + 1));
                                salir++;
                            }
                        }
                        if(salir == hourTrain)
                        {
                            salir = 1;
                            travel.levels = level;
                        }
                    } catch(Exception e)
                    {
                        salir = 0;
                    }
                }
            } while (salir <=0);
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
