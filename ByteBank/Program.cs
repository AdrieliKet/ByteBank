using ByteBank.Contas;
using ByteBank.Titular;

Cliente cliente1= new Cliente("Adrieli Kethin dos Santos", "10000000000");
cliente1.Profissao = "Desenvolvedor de sistemas";

ContaCorrente conta1 = new ContaCorrente(15, "1010-X", cliente1);
conta1.Saldo = 100;

ContaCorrente conta2 = new ContaCorrente(17, "1010-5", new Cliente("Jean Oliveira", "00000000000"));
conta2.Titular.Profissao = "Promotor de vendas";
conta2.Saldo = 350;

Console.WriteLine("Saldo em conta: " + conta1.Saldo);

//Deposito
conta1.Depositar(100);
Console.WriteLine("Saldo em conta pós deposito: " + conta1.Saldo);
Console.WriteLine();

//Saque
conta1.Sacar(300);
Console.WriteLine();

Console.WriteLine("Saldo pessoa 1: " + conta1.Saldo);
Console.WriteLine("Saldo pessoa 2: " + conta2.Saldo);
Console.WriteLine();

//Transferência
conta1.Tranferir(50, conta2);
Console.WriteLine("Saldo pessoa 1 após transferência: " + conta1.Saldo);
Console.WriteLine("Saldo pessoa 2 após transferência: : " + conta2.Saldo);
Console.WriteLine();

conta1.ImprimirDados();
Console.WriteLine();
conta2.ImprimirDados();

//Propriedade estática da classe
Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);
