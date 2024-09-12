/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author carmen (Correcciones por EViasValdez)
 */

import java.util.Scanner;

public class Triangulo extends Figura {
    private double Base, Altura;
    
    public Triangulo()
    {
        this.Base = 0;
        this.Altura = 0;
    }
    public double GetBase()
    {
        return Base;
    }
    public void SetBase(double Base)
    {
        this.Base = Base;
    }
    public double GetAltura()
    {
        return Altura;
    }
    public void SetAltura(double Altura)
    {
        this.Altura = Altura;
    }
    public double Perimetro(double num)
    {
        return num + num + num;
    }
    public double Area(double Base, double Altura)
    {
        return (Base * Altura ) / 2;
    }
}