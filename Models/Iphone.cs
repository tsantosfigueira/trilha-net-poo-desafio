namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando app {nomeApp} no IPhone {Modelo}");
        }

         public override string ToString()
        {
            return $"Este é um Iphone de modelo {Modelo} com {Memoria} GB de memória. Número: {Numero} e IMEI: {IMEI}";
        }
    }
}