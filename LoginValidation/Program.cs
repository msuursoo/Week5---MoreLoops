using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //Kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "adnin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."

            //kasutajal on kolm katsest

            int katsed = 0;

            while(katsed < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    katsed++;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. on jäänud {3 - katsed} katsed.");
                }
            }

           
        }
    }
}
