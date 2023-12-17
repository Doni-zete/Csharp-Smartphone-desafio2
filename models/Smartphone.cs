namespace desafio2.models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void LigacaoConcluida()
        {
            Console.WriteLine("Finalizando chamada...");
        }
        public abstract void InstalarAplicativo(string nome);
        public virtual void ExibirDadosAparelho()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("DADOS DO APARELHO");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"IMEI: {Imei}");
            Console.WriteLine($"Memória: {Memoria}GB");
            Console.WriteLine("====================================");

        }
    }
}