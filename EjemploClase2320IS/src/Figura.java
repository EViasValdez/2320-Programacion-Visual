public class Figura {
    private String Nombre;
    private int NumLados;

    // Constructor vació.
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
    public void SetNombre(String Nom)
    {
        this.Nombre = Nom;
    }
    public String GetNombre()
    {
        return this.Nombre;
    }
    public int GetNumLados()
    {
        return NumLados;
    }
    public void SetNumLados(int NumLados)
    {
        this.NumLados = NumLados;
    }
}