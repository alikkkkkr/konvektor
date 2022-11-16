using System;
namespace конвертер
{
	public class changetext
	{
        files files = new files();

        public void changeText()
        {
            Console.WriteLine("чтобы изменить текст нажмите любую клавишу и Enter чтобы выбрать строку, чтобы закончить F1");
            int position = 1;
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.F1)
            {
                if (key.Key == ConsoleKey.UpArrow) { position--; }
                else if (key.Key == ConsoleKey.DownArrow) { position++; }
                Console.Clear();
                foreach (human i in files.deseriliz)
                {
                    Console.WriteLine(i.name);
                }
                Console.SetCursorPosition(0, position);
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                        Console.Clear();
                        Console.WriteLine(files.deseriliz[position].name + files.deseriliz[position].age + files.deseriliz[position].color);
                        Console.WriteLine("Выбери: 1 - имя, 2 - возраст, 3 - любимый цвет ");
                        int nom = Convert.ToInt32(Console.ReadLine());
                        if (nom == 1) { files.deseriliz[position].name = Console.ReadLine(); }
                        if (nom == 2) { files.deseriliz[position].age = Convert.ToInt32(Console.ReadLine()); }
                        if (nom == 3) { files.deseriliz[position].color = Console.ReadLine(); }
                }
            }
            Console.Clear();
            files.serializal();
        }
    }
}

