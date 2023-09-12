// See https://aka.ms/new-console-template for more information
using controleContas;

Conta conta1 = new Conta(654321);
conta1.Saldo = 2341.42m;

Console.WriteLine($"Deseja criar uma nova conta? \n| 1 para não |\n| 2 para sim |");
int r1 = int.Parse(Console.ReadLine());

if (r1 == 2)
{
    Console.WriteLine("Informe os seus dados! \n");

    Cliente cliente1 = new Cliente();
    string nome = null;

    while (string.IsNullOrEmpty(nome))
    {
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();

        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("O nome não pode ser nulo. Tente novamente.");
        }
    }

    string cpf = null;

    while (string.IsNullOrEmpty(cpf) || cpf.Length < 11)
    {
        Console.Write("Digite seu CPF (11 dígitos, sem pontos e traços): ");
        cpf = Console.ReadLine();

        if (string.IsNullOrEmpty(cpf) && cpf.Length < 11 && cpf.Length > 11)
        {
            Console.WriteLine("O CPF deve conter pelo menos 11 dígitos. Tente novamente.");
        }
    }

    Console.Write("Digite o ano de nascimento: ");
    int anoNascimento;

    if (int.TryParse(Console.ReadLine(), out anoNascimento))
    {
        int idade = DateTime.Now.Year - anoNascimento;

        if (idade < 18)
        {
            Console.WriteLine("Desculpe, você tem menos de 18 anos e não pode criar um cadastro.");
        }
        else
        {
            Console.WriteLine("Cadastro criado com sucesso!\n");
        }
    }
    else
    {
        Console.WriteLine("Ano de nascimento inválido. Certifique-se de inserir um número válido.");
    }

    Console.WriteLine("Deseja continuar na conta 1 ou criar uma nova conta? \n 0 para continuar \n 1 para criar conta");
    int r2 = int.Parse(Console.ReadLine());

    if (r2 == 1)
    {
        Conta conta2 = new Conta();
        Console.WriteLine("Informe o saldo da nova conta: ");

        long saldo2 = long.Parse(Console.ReadLine());

        if (saldo2 >= 10)
        {
            conta2.Saldo = saldo2;
            Console.WriteLine($"O saldo da sua conta nova é :{conta2.Saldo}");
        }
        else
        {
            Console.WriteLine("Não aceitamos saldo menor que R$10");
        }
        Console.WriteLine("Você deseja realizar qual das seguintes operações? \n" +
            "0 para sair \n" +
            "1 para sacar \n" +
            "2 para depositar");
        int r3 = int.Parse(Console.ReadLine());
        switch (r3)
        {
            case 0:
                Console.WriteLine($"O seu saldo é: {conta2.Saldo}");
                break;
            case 1:
                Console.WriteLine("Informe o valor do saque: ");
                decimal novoSaldo = decimal.Parse(Console.ReadLine());
                conta2.Saque(novoSaldo);
                Console.WriteLine($"Valor do saldo depois do saque: {conta2.Saldo}");
                break;
            case 2:
                Console.WriteLine("Informe o valor do depósito: ");
                decimal novoDeposito = decimal.Parse(Console.ReadLine());
                conta2.Deposito(novoDeposito);
                Console.WriteLine($"Valor do saldo depois do depósito: {conta2.Saldo}");
                break;
        }
        if (conta1.Saldo > conta2.Saldo)
        {
            Console.WriteLine($"Número da conta de maior saldo: {conta1.Numero}");
        }
        else
        {
            Console.WriteLine($"Número da conta de maior saldo: {conta2.Numero}\n");
        }
    }
    else
    {
        Console.WriteLine("Você deseja realizar qual das seguintes operações? \n" +
            "0 para sair \n" +
            "1 para sacar \n" +
            "2 para depositar");
        int r4 = int.Parse(Console.ReadLine());
        switch (r4)
        {
            case 0:
                Console.WriteLine($"O seu saldo é: {conta1.Saldo}");
                break;
            case 1:
                Console.WriteLine("Informe o valor do saque: ");
                decimal novoSaldo = decimal.Parse(Console.ReadLine());
                conta1.Saque(novoSaldo);
                Console.WriteLine($"Valor do saldo depois do saque: {conta1.Saldo}");
                break;
            case 2:
                Console.WriteLine("Informe o valor do depósito: ");
                decimal novoDeposito = decimal.Parse(Console.ReadLine());
                conta1.Deposito(novoDeposito);
                Console.WriteLine($"Valor do saldo depois do depósito: {conta1.Saldo}");
                break;
        }
    }
}
else
{
    Console.WriteLine("Você não possui contas");
}
Banco meuBanco = new Banco { Nome = "BancoUGB", Numero = 123 };
Agencia minhaAgencia = new Agencia { Numero = 456, CEP = "12345-678", Telefone = "(24)9998888777" };
Console.WriteLine($"Nome do seu banco: {meuBanco.Nome} / Número do banco: {meuBanco.Numero}");
Console.WriteLine($"Número da sua agência: {minhaAgencia.Numero} / Cep da agência: {minhaAgencia.CEP} / Telefone da agência: {minhaAgencia.Telefone}");
