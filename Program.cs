using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes

// Reserva 1:
// Dias reservados: 5
// Hóspdes: 2
// Valor diária: 150,00

Console.WriteLine("Reserva 1:");

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Dias reservados: {reserva.DiasReservados}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");

// Reserva 2:
// Dias reservados: 5
// Hóspdes: 2
// Valor diária: 150,00

Console.WriteLine("\nReserva 2:");

reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Dias reservados: {reserva.DiasReservados}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");


// Reserva 3:
// Dias reservados: 5
// Hóspdes: 2
// Capacidade da suíte = 1
// Gera uma exceção de capacidade de hóspedes que não comporta na suíte

Console.WriteLine("\nReserva 3:");

reserva = new Reserva(diasReservados: 10);
suite.Capacidade = 1;
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Dias reservados: {reserva.DiasReservados}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");