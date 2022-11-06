using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){ NameMark = "Game", ProcessorType = "Intel", ProcessorFrequency = 2.7, AmountOfRAM = 16, HardDiskCapacity = 500, VideoCardMemory = 4, ComputerCost = 30000, CountComputer = 10 },
                new Computer(){ NameMark = "GameF", ProcessorType = "Intel", ProcessorFrequency = 3.7, AmountOfRAM = 24, HardDiskCapacity = 1000, VideoCardMemory = 8, ComputerCost = 50000, CountComputer = 45 },
                new Computer(){ NameMark = "GameTurbo", ProcessorType = "Intel", ProcessorFrequency = 5.7, AmountOfRAM = 32, HardDiskCapacity = 3000, VideoCardMemory = 16, ComputerCost = 75000, CountComputer = 50 },
                new Computer(){ NameMark = "GameA", ProcessorType = "AMD", ProcessorFrequency = 4.0, AmountOfRAM = 16, HardDiskCapacity = 1000, VideoCardMemory = 10, ComputerCost = 60000, CountComputer = 30 },
                new Computer(){ NameMark = "GameATurbo", ProcessorType = "AMD", ProcessorFrequency = 6.0, AmountOfRAM = 32, HardDiskCapacity = 3000, VideoCardMemory = 16, ComputerCost = 80000, CountComputer = 100 },
                new Computer(){ NameMark = "Ofice", ProcessorType = "Intel", ProcessorFrequency = 1.7, AmountOfRAM = 8, HardDiskCapacity = 500, VideoCardMemory = 2, ComputerCost = 25000, CountComputer = 5 },
                new Computer(){ NameMark = "Ofice+", ProcessorType = "Intel", ProcessorFrequency = 2.5, AmountOfRAM = 12, HardDiskCapacity = 1000, VideoCardMemory = 4, ComputerCost = 45000, CountComputer = 20 },
                new Computer(){ NameMark = "OficeA", ProcessorType = "AMD", ProcessorFrequency = 3.5, AmountOfRAM = 16, HardDiskCapacity = 2000, VideoCardMemory = 8, ComputerCost = 65000, CountComputer = 30 },
                new Computer(){ NameMark = "Home", ProcessorType = "Intel", ProcessorFrequency = 1.5, AmountOfRAM = 6, HardDiskCapacity = 250, VideoCardMemory = 1, ComputerCost = 15000, CountComputer = 200 },
                new Computer(){ NameMark = "Home+", ProcessorType = "Intel", ProcessorFrequency = 2.5, AmountOfRAM = 8, HardDiskCapacity = 150, VideoCardMemory = 2, ComputerCost = 25000, CountComputer = 300 },
                new Computer(){ NameMark = "HomeA", ProcessorType = "AMD", ProcessorFrequency = 3.5, AmountOfRAM = 16, HardDiskCapacity = 1000, VideoCardMemory = 4, ComputerCost = 35000, CountComputer = 100 }
            };
            Console.WriteLine("Введите имя процессора");
            string processorString = Console.ReadLine();
            List<Computer> computers1 = computers.Where(a => a.ProcessorType == processorString).ToList();
            if (computers1.Count==0)
               {
                   Console.WriteLine("Не найдены компьютеры с данным процессором");
               }
            else
               {
                   Print(computers1);
               }
                    



            Console.WriteLine("Введите объём ОЗУ");
            double amountOfRAMTemp = Convert.ToDouble(Console.ReadLine());
            List<Computer> computers2 = computers.Where(a => a.AmountOfRAM >= amountOfRAMTemp).ToList();
            if (computers2.Count == 0)
            {
                Console.WriteLine("Не найдены компьютеры с превышаюшим данный объём ОЗУ");
            }
            else
            {
                Print(computers2);
            }


            List<Computer> computers3 = computers.OrderBy(a => a.ComputerCost).ToList();
            Console.WriteLine("Компьютеры отсортированые по возрастаю цены");
            Print(computers3);

            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(a => a.ProcessorType);
            foreach (IGrouping<string, Computer> g in computers4)
            {
                Console.WriteLine(g.Key);
                foreach (Computer computer in g)
                {
                    Console.WriteLine($"{computer.NameMark,15} {computer.ProcessorType,8} {computer.ProcessorFrequency,5} {computer.AmountOfRAM,5} {computer.HardDiskCapacity,5} {computer.VideoCardMemory,5} {computer.ComputerCost,7} {computer.CountComputer,5}");

                }
            }


            Computer computer5 = computers.OrderByDescending(a => a.ComputerCost).FirstOrDefault();
            Computer computer6 = computers.OrderBy(a => a.ComputerCost).FirstOrDefault();
            Console.WriteLine("Самый дорогой компьютер");
            Console.WriteLine($"{computer5.NameMark,15} {computer5.ProcessorType,8} {computer5.ProcessorFrequency,5} {computer5.AmountOfRAM,5} {computer5.HardDiskCapacity,5} {computer5.VideoCardMemory,5} {computer5.ComputerCost,7} {computer5.CountComputer,5}");
            Console.WriteLine("Самый дешёвый компьютер");
            Console.WriteLine($"{computer6.NameMark,15} {computer6.ProcessorType,8} {computer6.ProcessorFrequency,5} {computer6.AmountOfRAM,5} {computer6.HardDiskCapacity,5} {computer6.VideoCardMemory,5} {computer6.ComputerCost,7} {computer6.CountComputer,5}");

            if (computers.Any(a => a.CountComputer >= 30))
            {
                Console.WriteLine("Есть хотя бы один компьютер в количестве не менее 30 штук");
            }
            else 
            {
                Console.WriteLine("Нету ни одного компьютера в количестве не менее 30 штук");
            }


            Console.ReadKey();

        }

        static void Print(List<Computer> computers)
        {
            foreach (Computer computer in computers)
            {
                Console.WriteLine($"{computer.NameMark,15} {computer.ProcessorType,8} {computer.ProcessorFrequency,5} {computer.AmountOfRAM,5} {computer.HardDiskCapacity,5} {computer.VideoCardMemory,5} {computer.ComputerCost,7} {computer.CountComputer,5}");
            }
        }


    }
}
