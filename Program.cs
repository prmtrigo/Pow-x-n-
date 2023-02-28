namespace Pow_x_n_;
class Program
{
    static double Potenciacao(double x, int numero){


        //se fomos elevar um número a enésima potência e esse número for menor que zero
        if(numero < 0){
            return 1/x * Potenciacao(1/x, -(numero + 1) );
        }

        if(numero == 0){
            return 1;
        }

        if(numero == 1){
            return x;
        }

        if(numero % 2 == 0){
            return Potenciacao(x * x, numero/2);
        }


        return x * Potenciacao(x * x, numero/2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Coloque o Número X (BASE): ");
        double x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Coloque o Expoente: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        //X^Numero

        Console.WriteLine(Potenciacao(x,numero));
    }
}
