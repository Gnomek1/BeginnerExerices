using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BeginnerExerices
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ex4();
        }

        static void Ex1() //Napisz program, który posortuje tablicę liczb w porządku rosnącym
        {
            Console.Write("Podaj dlugość jaką ma mieć twoja tablica: ");
            string lenOfArray=Console.ReadLine();
            if (int.TryParse(lenOfArray, out int result))
            {
                Console.WriteLine("super");
            }
            else
            {
                Console.WriteLine("Podaj dlugość jaką ma mieć twoja tablica");
            }
            int[] tab = new int[result];

            for (int i = 0; i < result-1; i++)
            {
                Console.Write("Podaj liczbę do twojej tablicy: ");
                tab[i]=int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tab.Length; i++)
            {
                int temp = 0;
                for (int j =i+1; j < tab.Length; j++)
                {
                    if (tab[i]>tab[j])
                    {
                        temp = tab[i];
                        tab[i] = tab[j];
                        tab[j]=temp;
                    }
                    
                }
            }

            foreach (var a in tab)
            {
                Console.Write($" {a},");
            }
        }

        static void Ex2() //Napisz program, który będzie sprawdzał poprawność wprowadzonego przez użytkownika numeru PESEL.
        {
            Console.Write("Podaj Pesel: ");
            var pesel = Console.ReadLine();
            if (pesel.Length!=11)
            {
                
            }
            else
            {
                Console.WriteLine("podaj poprawny pesel");
            }

        }

        static void Ex3()//Napisz program do zamiany stopni Celcjusza na Farenheita i odwrotnie
        {
            Console.WriteLine("Podajesz wartość w:\n 1. st.Celcjusza\n 2.Farenheita\n ? : ");
            var option=int.Parse(Console.ReadLine());
            if (option==1)
            {
                Console.Write("Podaj wartość: ");
                double celcjusz = double.Parse(Console.ReadLine());
                Console.WriteLine($"Wartość w Farenheitach to: {((celcjusz * 9) / 5) + 32}");
            }
            else if (option==2)
            {
                Console.Write("Podaj wartość: ");
                double farenheit = double.Parse(Console.ReadLine());
                Console.WriteLine($"Wartość w celcjuszach to: {((farenheit - 32)*5)/9 }");
            }
            else
            {
                throw new Exception("wybierz poprawną opcję");
                Console.WriteLine(typeof(Exception));
                //pobawic sie tym 
            }

        }
        static void Ex4()//Napisz program, który odwróci liczbę (np. 1344 => 4431)
        {
            Console.Write("Napisz liczbę, którą chcęsz odwrócić: ");
            var input=Console.ReadLine();
            if (int.TryParse(input,out int res))
            {
                char[] arrayOfNumber = input.ToCharArray();
                for (int i = arrayOfNumber.Length-1; i >= 0; i--)
                {
                    Console.Write($"{arrayOfNumber[i]}");
                }
            }
            else
            {
                Console.WriteLine("Podaj poprawnby format");
            }
        }

        static void Ex5()//Napisz program, który usunie wszystkie zduplikowane liczby z podanej tablicy
        {

        }
        
    }
}
