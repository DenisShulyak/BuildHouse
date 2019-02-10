using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            House project = new House();
            project.parts.Add(new Basement());
            project.parts.Add(new Walls());
            project.parts.Add(new Walls());
            project.parts.Add(new Walls());
            project.parts.Add(new Walls());
            project.parts.Add(new Window());
            project.parts.Add(new Window());
            project.parts.Add(new Window());
            project.parts.Add(new Window());
            project.parts.Add(new Door());
            project.parts.Add(new Roof());
            
            Team team = new Team();
            
            int countDays = 1;
            while (!project.HouseFinished())
            {
                Console.WriteLine("Начало дня № {0}", countDays);
                for (int i = 0; i < team.workers.Count; i++)
                { if(i<4)
                    {
                    Console.Write("Рабочий {0} : ", i + 1);
                    team.workers[i].Work(project);

                    }
                    else
                    {
                        Console.Write("Бригадир: ");
                        team.workers[i].Work(project);
                    }
                }
                Console.WriteLine();
                countDays++;
                if(countDays == 3 )
                {
                    Console.WriteLine("     ___________________");
                    Console.WriteLine("    /                  /");
                    Console.WriteLine("   /                  /");
                    Console.WriteLine("  /                  /");
                    Console.WriteLine(" /                  /");
                    Console.WriteLine("/__________________/");
                }
                else if(countDays == 4)
                {
                    Console.WriteLine("     __________________     ");
                    Console.WriteLine("    /|                 |     ");
                    Console.WriteLine("   / |                 |    ");
                    Console.WriteLine("  /  |                 |   ");
                    Console.WriteLine(" /   |                 |  ");
                    Console.WriteLine("/    |                 |");
                    Console.WriteLine("|    |                 |");
                    Console.WriteLine("|    |                 |");
                    Console.WriteLine("|    |                 |");
                    Console.WriteLine("|    |_________________|");
                    Console.WriteLine("|   /                  /");
                    Console.WriteLine("|  /                  /");
                    Console.WriteLine("| /                  /");
                    Console.WriteLine("|/                  /");
                    Console.WriteLine("/__________________/");

                }
                else if (countDays == 5)
                {
                    Console.WriteLine("     __________________     ");
                    Console.WriteLine("    /|                 |     ");
                    Console.WriteLine("   / |                /|    ");
                    Console.WriteLine("  /  |               / |   ");
                    Console.WriteLine(" /   |              /  |  ");
                    Console.WriteLine("/____|_____________/   |");
                    Console.WriteLine("|    |            |    |");
                    Console.WriteLine("|    |            |    |");
                    Console.WriteLine("|    |            |    |");
                    Console.WriteLine("|    |____________|____|");
                    Console.WriteLine("|   /             |    /");
                    Console.WriteLine("|  /              |   /");
                    Console.WriteLine("| /               |  /");
                    Console.WriteLine("|/                | /");
                    Console.WriteLine("/_________________|/");
                }
                else if (countDays == 6)
                {
                    Console.WriteLine("     __________________     ");
                    Console.WriteLine("    /|   ___   ___     |     ");
                    Console.WriteLine("   / |  |_|_| |_|_|   /|    ");
                    Console.WriteLine("  /  |   ___    ___  / |   ");
                    Console.WriteLine(" /   |  |_|_|  |_|_|/  |  ");
                    Console.WriteLine("/____|_____________/   |");
                    Console.WriteLine("|    |            |    |");
                    Console.WriteLine("|    |            |    |");
                    Console.WriteLine("|    |            |    |");
                    Console.WriteLine("|    |____________|____|");
                    Console.WriteLine("|   /             |    /");
                    Console.WriteLine("|  /              |   /");
                    Console.WriteLine("| /               |  /");
                    Console.WriteLine("|/                | /");
                    Console.WriteLine("/_________________|/");
                }
                else if (countDays == 7)
                {
                    Console.WriteLine("     __________________     ");
                    Console.WriteLine("    /|   ___   ___     |     ");
                    Console.WriteLine("   / |  |_|_| |_|_|   /|    ");
                    Console.WriteLine("  /  |   ___    ___  / |   ");
                    Console.WriteLine(" /   |  |_|_|  |_|_|/  |  ");
                    Console.WriteLine("/____|_____________/   |");
                    Console.WriteLine("|    |            |    |");
                    Console.WriteLine("|    |            |    |");
                    Console.WriteLine("|    |            |    |");
                    Console.WriteLine("|    |____________|____|");
                    Console.WriteLine("|   /             |    /");
                    Console.WriteLine("|  /   ____       |   /");
                    Console.WriteLine("| /   |    |      |  /");
                    Console.WriteLine("|/    |    |      | /");
                    Console.WriteLine("/_____|_ __|______|/");
                }
                else if (countDays == 8)
                {
                    Console.WriteLine("         __________ ");
                    Console.WriteLine(@"        / \        \       ");
                    Console.WriteLine(@"       /   \        \     ");
                    Console.WriteLine(@"      /     \        \     ");
                    Console.WriteLine(@"     /       \        \     ");
                    Console.WriteLine(@"    /         \        |     ");
                    Console.WriteLine(@"   /           \      /|    ");
                    Console.WriteLine(@"  /             \    / |   ");
                    Console.WriteLine(@" /               \  /  |  ");
                    Console.WriteLine(@"/_________________\/   |");
                    Console.WriteLine("|                 |    |");
                    Console.WriteLine("|                 |    |");
                    Console.WriteLine("|                 |    |");
                    Console.WriteLine("|                 |    |");
                    Console.WriteLine("|                 |    /");
                    Console.WriteLine("|      ____       |   /");
                    Console.WriteLine("|     |    |      |  /");
                    Console.WriteLine("|     |    |      | /");
                    Console.WriteLine("|_____|_ __|______|/");
                }
                Console.WriteLine("Для начала следующего дня нажмите ENTER");
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadLine();
        }
    }
}
