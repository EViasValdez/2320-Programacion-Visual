public class Figura {
    private String Nombre;
    private int NumLados;

    // Constructor vacio.
    public Figura()
    {
        this.Nombre = null;
        this.NumLados = 0;
    }
     // Constructor con parámetros.
    public Figura(String Nom, int Num)
    {
        this.Nombre = Nom;
        this.NumLados = Num;
    }
    public void setNombre(String Nom)
    {
        this.Nombre = Nom;
    }
    public String getNombre()
    {
        return this.Nombre;
    }
    public int getNum_lados() {
        return NumLados;
    }
    public void setNum_lados(int NumLados) {
        this.NumLados = NumLados;
    }
}