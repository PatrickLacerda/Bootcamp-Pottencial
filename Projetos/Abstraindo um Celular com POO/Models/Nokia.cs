namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
            
        }

                public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Aplicativo o aplicativo " + nomeApp + " no Nokia");
        }
    }
}