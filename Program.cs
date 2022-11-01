// See https://aka.ms/new-console-template for more information
//contruir conversor cm, metro, km

bool conti = false;
string voUf;
do
{
    Console.WriteLine("Qual a unidade de medida" +
        System.Environment.NewLine + "1 - cm ----> m"
        +
        System.Environment.NewLine + "2 - cm ----> km"
        +
        System.Environment.NewLine + "3 - m  ----> cm"
        +
        System.Environment.NewLine + "4 - m  ----> km"
        +
        System.Environment.NewLine + "5 - km ----> cm"
        +
        System.Environment.NewLine + "6 - km ----> m"
        );
    string unidade = Console.ReadLine();
    Console.WriteLine("Digite o valor: ");
    double num = Convert.ToDouble(Console.ReadLine());

    double soma;
    switch (unidade)
    {

        case "1":
            soma = num / 100;
            Console.WriteLine("{0:f5} metros", soma);

            Console.WriteLine("Deseja realizar outra operação? "
                + System.Environment.NewLine + " s = sim / n = não"
                );
            voUf = Console.ReadLine();
            if (voUf == "n")
                conti = false;
            else
                conti = true;

            break;
        case "2":
            soma = num / 100000;
            Console.WriteLine("{0:f5} Quilmetros", soma);

            Console.WriteLine("Deseja realizar outra operação? ");
            voUf = Console.ReadLine();
            if (voUf == "n")
                conti = false;
            else
                conti = true;
            break;
        case "3":
            soma = num * 100;
            Console.WriteLine("{0:f5} Centimetros", soma);

            Console.WriteLine("Deseja realizar outra operação? ");
            voUf = Console.ReadLine();
            if (voUf == "n")
                conti = false;
            else
                conti = true;
            break;
        case "4":
            soma = num / 1000;
            Console.WriteLine("{0:f5} Quilmetros", soma);

            Console.WriteLine("Deseja realizar outra operação? ");
            voUf = Console.ReadLine();
            if (voUf == "n")
                conti = false;
            else
                conti = true;
            break;
        case "5":
            soma = num * 100000;
            Console.WriteLine("{0:f5} Centimetros", soma);

            Console.WriteLine("Deseja realizar outra operação? ");
            voUf = Console.ReadLine();
            if (voUf == "n")
                conti = false;
            else
                conti = true;
            break;
        case "6":
            soma = num * 1000;
            Console.WriteLine("{0:f5} metros", soma);

            Console.WriteLine("Deseja realizar outra operação? ");
            voUf = Console.ReadLine();
            if (voUf == "n")
                conti = false;
            else
                conti = true;
            break;

    }
} while (conti == true);
