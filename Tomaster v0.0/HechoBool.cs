namespace Tomaster_v0._0;

public class HechoBool : unHecho
{
    private string nombre;        
    private bool valor;     
    private int nivel;            
    private string? pregunta = null;


    public string Nombre()
    {
        return nombre;
    }

    public bool valorBool()
    {
        return valor;
    }

    public int Nivel()
    {
        return nivel;
    }

    public string? Pregunta()
    {
        return pregunta;
    }

    public void setNivel(int n)
    {
        nivel = n;
    }

    public HechoBool(string nombre, bool valor, int nivel, string? pregunta)
    {
        this.nombre = nombre;
        this.valor = valor;
        this.nivel = nivel;
        this.pregunta = pregunta;
    }
    
 /*   public String toString()
    {
        String resultado = "";
        if (!valor)
        {
            resultado += "!";
        }
        resultado += nombre + " (" + nivel + ")"+"("+pregunta+")";
        Console.WriteLine(resultado);
        return resultado;
    }
    */
}