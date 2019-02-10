using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    class TeamLeader:IWorker
    {

        public void Work(House obj)
        {
            if (obj.HouseFinished())
            {
                Console.WriteLine("Дом построен");
            }
            else
            {
                int i = 0;
                Console.Write("Отчет за день: ");
                bool w = true;
                while (obj.parts[i].isBuilt)
                {
                    w = false;
                    string[] elements = obj.parts[i].ToString().Split('.'); // Чтобы выводил не BuildHouse.Walls, а Walls
                    Console.Write(elements[elements.Length - 1] + " ");
                    i++;
                }
                if (w)
                {
                    Console.Write("Ничего не сделано");
                }
            }
        }
    }
}
