using CpfValidation.Service;


while (true)
{
    Console.WriteLine("\nInput cpf:");
    var input = Console.ReadLine();
    var result = Validation.IsCpfValid(input!);
    if (result)
    {
        Console.WriteLine("Cpf is valid");
    }
    else
    {
        Console.WriteLine("Cpf is invalid");
    }
}


