using POO;

Conta conta1 = new Conta();

conta1.Nome = "Vinicius";
conta1.NumeroConta = "12436472";

conta1.Depositar(15.25);

conta1.Sacar(10);

Console.WriteLine($"Saldo: {conta1.Saldo}");
