namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando app {nomeApp} no Nokia {Modelo}");
        }

        public override string ToString()
        {
            return $"Este é um Nokia de modelo {Modelo} com {Memoria} GB de memória. Número: {Numero} e IMEI: {IMEI}";
        }
    }
}