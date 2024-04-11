// code .\src\ConsoleUI\Program.cs

double Perimetro;
double Area;
double Volumen;

Console.WriteLine("Calculadora de Perímetro, Área y Volumen de un Prisma Cuadrangular");

Console.Write("Dame el lado: ");
double lado = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame la diagonal mayor: ");
double Diagonal_M = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame la diagonal menor: ");
double Diagonal_menor = Convert.ToDouble(Console.ReadLine());

// Calcula el perímetro del rombo
Perimetro = Application.Rombo.Perimetro(lado);

// Calcula el área del rombo
Area = Application.Rombo.Area(Diagonal_M, Diagonal_menor);

Console.Write("Dame la altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

// Calcula el volumen del prisma cuadrangular
Volumen = Application.PrismaCuadrangular.Volumen(Area, altura);
Console.WriteLine();
Console.WriteLine($"Perímetro: {Perimetro}cm\nÁrea: {Area}cm2\nVolumen: {Volumen}cm3");