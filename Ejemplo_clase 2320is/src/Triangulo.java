
import java.util.Scanner;

public class Triangulo extends Figura {
    
    private double Base, Altura;
    
    public Triangulo()
    {
        this.Base = 0;
        this.Altura = 0;
    }
    public double getBase() {
        return Base;
    }
    public void setBase(double Base) {
        this.Base = Base;
    }
    public double getAltura() {
        return Altura;
    }
    public void setAltura(double Altura) {
        this.Altura = Altura;
    }
    public double Perimetro(double num)
    {
        return num + num + num;
    }
    public double area(double Base, double Altura)
    {
        return (Base * Altura ) / 2;
    }
}