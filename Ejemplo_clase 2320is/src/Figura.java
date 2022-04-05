
public class Figura {
    private String nombre;
    private int num_lados;
    
    //contructor vacio
    public Figura()
    {
        this.nombre = null;
        this.num_lados = 0;
    }
     //contructor con parametros
    public Figura(String nom, int num)
    {
        this.nombre = nom;
        this.num_lados = num;
    }
    
    public void setNombre(String nom)
    {
        this.nombre = nom;
    }
    public String getNombre()
    {
        return this.nombre;
    }

    public int getNum_lados() {
        return num_lados;
    }

    public void setNum_lados(int num_lados) {
        this.num_lados = num_lados;
    }
    
    
}
