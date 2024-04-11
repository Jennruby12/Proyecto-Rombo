namespace Application;

public class Rombo
{
    public static double Perimetro(double lado)
    {
        double Perimetro =  4*lado;
        return Perimetro;
    }
    public static double Area(double Diagonal_M, double Diagonal_m)
    {
        double Area = (Diagonal_M*Diagonal_m)/2;
        return Area;
    }
}
