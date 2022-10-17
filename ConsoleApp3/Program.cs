// See https://aka.ms/new-console-template for more information
Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Idade: ");
string idade = Console.ReadLine();
int _idade = Convert.ToInt32(idade);


Console.Write("Nome: ");
string nome2 = Console.ReadLine();

Console.Write("Idade: ");
string idade2 = Console.ReadLine();
int _idade2 = Convert.ToInt32(idade2);

Console.WriteLine("Nome: {0} Idade: {1}", nome, idade);
Console.WriteLine("Nome: {0} Idade: {1}", nome2, idade2);


double media = (double)(_idade + _idade2)/2;

Console.WriteLine("A media da idade das duas pessoas é: {0}", media);
