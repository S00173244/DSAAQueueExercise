using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAQueueExerciseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numberQueue = new Queue<int>(3);

            do
            {
                int tempNum;
                Console.Write("Enter a number : ");
                string temp = Console.ReadLine();
                if (temp == "c")
                {
                    int num = numberQueue.Dequeue();
                    numberQueue.Enqueue(num);
                }
                else
                {

                    int.TryParse(temp, out tempNum);
                    if (numberQueue.Count < 3)
                        numberQueue.Enqueue(tempNum);
                    else
                    {
                        numberQueue.Dequeue();
                        numberQueue.Enqueue(tempNum);
                    }
                }

                Console.WriteLine();
                foreach (int item in numberQueue)
                {
                    Console.WriteLine(item);

                }

            } while (true);
        }
    }
}
