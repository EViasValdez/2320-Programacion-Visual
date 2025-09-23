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

public class Menu {
    int Opcion;
    Scanner Leer = new Scanner (System.in);

    public void menu1()
    {
        System.out.println("MENU");
        System.out.println("Opción 1: Calculo de perímetro y area de triangulo");
        System.out.println("Opción 2: Calculo de perímetro y area de cuadrado");
        System.out.println("Opción 3: Calculo de perímetro y area de rectángulo");
        Opcion = Leer.nextInt();

        switch (Opcion)
        {
            case 1:
                Triangulo Triangulo1 = new Triangulo();
                System.out.println("Calculo de perímetro del triangulo");
                Leer.nextLine();
                System.out.println("Nombre de la figura");
                Triangulo1.SetNombre(Leer.nextLine());
                System.out.println("Numero de lados");
                Triangulo1.SetNumLados(Leer.nextInt());
                System.out.println("Ingresa la base del triangulo");
                Triangulo1.SetBase(Leer.nextInt());
                System.out.println("Ingresa la altura del triangulo");
                Triangulo1.SetAltura(Leer.nextInt());
                
                // Se manda a llamar al método "Perímetro".
                double x = Triangulo1.Perimetro (Triangulo1.GetBase());
                System.out.println("El perímetro es: " + x);

                System.out.println("El area es : " + Triangulo1.Area(Triangulo1.GetBase(),Triangulo1.GetAltura()));
            break;
        }
    }
}