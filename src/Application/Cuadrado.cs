namespace Application;

public class Poligono_R
{
    public static double Perimetro(double lado, int n_lados)
    {
        double perimetro = lado * n_lados;
        return perimetro;
    }
    public static double Area(double lado, int n_lados, double radio)
    {
        double area = (n_lados * lado * radio)/2;
        return area;
    }
}