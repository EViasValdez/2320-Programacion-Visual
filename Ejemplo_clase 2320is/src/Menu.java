
import java.util.Scanner;


public class Menu {
    
    int opcion;
    Scanner leer = new Scanner (System.in);

    public void menu1()
    {
        System.out.println("MENU");
        System.out.println("Opcion 1: Calculo de Perimetro y area de triangulo");
        System.out.println("Opcion 2: Calculo de Perimetro y area de cuadrado");
        System.out.println("Opcion 3: Calculo de Perimetro y area de rectangulo");
        opcion = leer.nextInt();
        
        switch (opcion)
        {
            case 1:
                Triangulo triangulo1 = new Triangulo();
                System.out.println("Calculo de Perimetro del triangulo");
                leer.nextLine();
                System.out.println("Nombre de la figura");
                triangulo1.setNombre(leer.nextLine());
                System.out.println("Numero de lados");
                triangulo1.setNum_lados(leer.nextInt());
                System.out.println("Ingresa la base del triangulo");
                triangulo1.setBase(leer.nextInt());
                System.out.println("Ingresa la altura del triangulo");
                triangulo1.setAltura(leer.nextInt());
                // Mando a llamar al metodo "perimetro".
        
                double x = triangulo1.Perimetro (triangulo1.getBase());
                System.out.println("El perimetro es: " + x);
        
                System.out.println("El area es : " + triangulo1.area(triangulo1.getBase(),triangulo1.getAltura()));
            break;
        }
    }
}