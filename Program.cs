namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {
        string answer2;
        int answer;
        do
        {
            
            Console.WriteLine("Choisis un nombre");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer % 2 < 1)
            {
                Console.WriteLine("Le nombre " + answer + " est pair");
            }
            else
            {
                Console.WriteLine("Le nombre " + answer + " est impair");
            }

            Console.WriteLine("Veux-tu vérifier un autre nombre ? \n(y/n)" ); 
            answer2 = Console.ReadLine();
        } while (answer2 != "n");
        
        /*
         * Consignes
         * Demandez à l'utilisateur un nombre
         * Dites à l'utilisateur si le nombre fourni est pair ou impair
         * Demandez à l'utilisateur s'il veut proposer un autre nombre
         *  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
         */
    }
}
