using SistemaDeHospedagem.Models;


List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("nome1", "sobrenome1");
Pessoa p2 = new Pessoa("nome2", "sobrenome2");


hospedes.Add(p1);
hospedes.Add(p2);


Suite suite = new Suite("Duplo", 2, 60.00M);


Reserva reserva = new Reserva(7);
reserva.CadastrarHospedes(hospedes);
reserva.CadastrarSuite(suite);


Console.WriteLine($"Número de Hóspedes: {reserva.ObterQuantidadeDeHospedes()}");
Console.WriteLine($"Valor Total da reserva: {reserva.CalcularValorTotal()}");

