using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace Maomäng
{
    internal class Program
    {
        int korgus = 20;
        int laius = 30;
        int[] x = new int[50];
        int[] y = new int[50];

        int toitx;
        int toity;
        int osi = 3;

        ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
        char key = 'w';
        Random rand = new Random();

        Program()
        {
            x[0] = 5;
            y[0] = 5;
            Console.CursorVisible = false;
            toitx = rand.Next(2, (laius - 2));
            toity = rand.Next(2, (korgus - 2));
        }
        public void laud()
        {
            Console.Clear();
            for (int i = 1; i <= (laius+2); i++)
            {
                Console.SetCursorPosition(i,1);
                Console.WriteLine("-");

            }
            for (int i = 1; i <= (laius+2); i++)
            {
                Console.SetCursorPosition(i,(korgus+2));
                Console.WriteLine("-");

            }
            for (int i = 1; i <= (korgus+1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.WriteLine("|");

            }
            
            for (int i = 1; i <= (korgus+1); i++)
            {
                Console.SetCursorPosition((laius + 2), i);
                Console.WriteLine("|");

            }
            
        }
        public void sisestus()
        {
            if (Console.KeyAvailable)
            {
                keyinfo = Console.ReadKey(true);
                key = keyinfo.KeyChar;
            }
        }
        public void kirjpunkt(int x, int y)
        {
            Console.SetCursorPosition(x,y);
            Console.Write("#");
        }
        public void log()
        {
            if (x[0] == toitx)
            {
                if (y[0] == toity)
                {
                    osi++;
                    toitx = rand.Next(2, (laius-2));
                    toity = rand.Next(2, (korgus-2));
                }
            }
            for(int i = osi; i >1; i--)
            {
                x[i-1] = x[i-2];
                y[i-1] = y[i-2];
            }
            switch(key)
            {
                case 'w':
                    y[0]--;
                    break;
                case 's':
                    y[0]++;
                    break;
                case 'a':
                    x[0]--;
                    break;
                case 'd':
                    x[0]++;
                    break;

            }
            for(int i = 0;i <= (osi-1); i++)
            {
                kirjpunkt(x[i], y[i]);
                kirjpunkt(toitx, toity);

            }
            Thread.Sleep(100);
        }
        static void Main(string[] args)
        {
            Program uss = new Program();
            while (true)
            {
                uss.laud();
                uss.sisestus();
                uss.log();
            }
            Console.ReadKey();
        }
    }
}