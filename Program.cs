Console.Clear();

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("                    🍞    Padaria    🍞                    ");
Console.WriteLine("                       Pão italiano                        ");
Console.WriteLine("🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞🍞 \n");
Console.ResetColor(); Thread.Sleep(800);

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(@" Aqui você calcula a quantidade de ingredientes necessária 
         para fazer determinada quantidade de pão          

Vamos começar:
");
Console.ResetColor(); Thread.Sleep(800);

Console.Write("Peso desejado em gramas: ");
double pesoPao = Convert.ToDouble(Console.ReadLine());

double farinha = 1;
double agua = 0.7;
double fermento = 0.4;
double sal = 0.02;

double percentualPao = farinha+ agua+ fermento+ sal;
double qtFarinha = pesoPao / percentualPao;

double aguaf = qtFarinha *agua;
double fermentof = qtFarinha *fermento;
double salf = qtFarinha *sal;

Console.WriteLine($"{qtFarinha}");
Console.WriteLine($"{aguaf}");
Console.WriteLine($"{fermentof}");
Console.WriteLine($"{salf}");
