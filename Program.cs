namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro meuCachorro = new Cachorro("Jade", "Vira-Lata");
            Gato meuGato = new Gato("Mingau", "Vira-Lata");

            meuCachorro.Comer();
            meuCachorro.Latir();
            meuGato.Comer();
            meuGato.Miar();
;        }
    }
}
