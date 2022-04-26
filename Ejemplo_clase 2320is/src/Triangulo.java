
import java.util.Scanner;

public class Triangulo extends Figura {
    
    private double base, altura;
    
    public Triangulo()
    {
        this.base = 0;
        this.altura = 0;
    }

    public double getBase() {
        return base;
    }

    public void setBase(double base) {
        this.base = base;
    }

    public double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }
    
    public double Perimetro(double num)
    {
        return num + num + num;
    }
    public double area(double base, double altura)
    {
        return (base * altura ) / 2;
    }
}