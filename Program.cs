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

Console.Clear();

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(@$"
Quantidade de ingredientes 
    para fazer {pesoPao}g       
     de pão italiano       ");
Console.ResetColor();

Console.WriteLine($@"    
==========================
    Farinha:  {(Math.Round(qtFarinha))} g
    Agua:     {(Math.Round(aguaf))} ml
    Fermento: {(Math.Round(fermentof))} g
    Sal:      {(Math.Round(salf))} g
==========================
");
