Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

c1.Depositar(2000.00);
c1.Sacar(100);
Console.WriteLine("Saldo em c1 {0}", c1.Saldo);


c2.Depositar(200.00);
c2.Sacar(150.00);
Console.WriteLine("Saldo em c2 {0}", c2.Saldo);

c1.Transferir(c2, 300.00);
Console.WriteLine("Saldo em c1 {0}", c1.Saldo);
Console.WriteLine("Saldo em c2 {0}", c2.Saldo);

