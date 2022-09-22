using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeHospedagem.Models
{
    public class Reserva
    {
        
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            if(Hospedes.Count <= suite.Capacidade)
            {
                Suite = suite;
            }
            else
            {
                throw new ArgumentException ("A capacidade da suíte não pode ser menor que a quantidade de hóspedes.");
            }
        }

        public int ObterQuantidadeDeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorTotal()
        {
            if(DiasReservados < 10)
            {
                return DiasReservados * Suite.ValorDiaria;
            }
            else
            {
                decimal valorSemDesconto = DiasReservados * Suite.ValorDiaria;
                decimal desconto = 0.10M;
                return Math.Round(valorSemDesconto - (valorSemDesconto * desconto), 2);
            }
        }
    }
}