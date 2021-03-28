using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account kowalskiAccount = new Account("Jan Kowalski", "36417", "mała", "czarna");

            kowalskiAccount.Zaloguj("mała", "czarna");
            Console.WriteLine(kowalskiAccount);

            kowalskiAccount.ChangePass("mała", "czarna");
            Console.WriteLine(kowalskiAccount);

            kowalskiAccount.Deposit(20);
            Console.WriteLine(kowalskiAccount);

            kowalskiAccount.PayOut(10);
            Console.WriteLine(kowalskiAccount);

            kowalskiAccount.Logout("mała", "czarna");
            Console.WriteLine(kowalskiAccount);

            Hours godz = new Hours();

            godz.Hour = 24; //dostęp do zmiennej prywatnej poprzez właściwość

           // przypisanie możliwe dzięki sekcji set we własności Hour

            Console.WriteLine(godz.Info());

            Console.WriteLine("Naciśnij dowolny klawisz");
            Console.ReadKey();
        }
    }
}
