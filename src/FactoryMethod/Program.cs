using FactoryMethod;



do
{
    Console.WriteLine("");
    Console.WriteLine("Escolha o Lanche : ");
    Console.WriteLine("(1)Bauru  (2)Frango  (3)Misto Quente  (4)Vegetariano (0)Sair");
    var lancheEscolhido = Convert.ToInt32(Console.ReadLine());

    try
    {
        if (lancheEscolhido == 0) return;

        LancheFactory factory = new LancheFactory();
        Product lanche = factory.CriarLanche(lancheEscolhido);

        Console.WriteLine(lanche.Nome);

        foreach (var ingrediente in lanche.Ingredientes)
            Console.WriteLine(ingrediente);

        Console.WriteLine("\nLanche montado com sucesso");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro :" + ex.Message);
    }
} while (true);
Console.ReadLine();