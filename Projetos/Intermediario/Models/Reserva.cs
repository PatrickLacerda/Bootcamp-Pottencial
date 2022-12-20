namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
                       
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes; 
                Console.Write("Capacidade disponivel  ");
                
            }
            else  
            {
                Console.WriteLine("Número de hóspedes é maior que a capacidade");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*

;
            return Hospedes.Count;
            
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;
           
              
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valor = (DiasReservados * Suite.ValorDiaria) - (((DiasReservados * Suite.ValorDiaria)/100)*10);
            }

            return valor;
        }
    }
}