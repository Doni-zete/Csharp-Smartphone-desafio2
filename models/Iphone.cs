using System.Security.Cryptography.X509Certificates;

namespace desafio2.models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;

        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo [{nome}] no IPhone");
        }

   
    }


}