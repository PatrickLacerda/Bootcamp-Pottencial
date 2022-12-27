namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
             Numero = numero;
                    }

        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Aplicativo o aplicativo " + nomeApp + "no Iphone");
        }
    }
}