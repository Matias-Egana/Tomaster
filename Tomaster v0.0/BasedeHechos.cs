namespace Tomaster_v0._0;

public class BasedeHechos
{
    private List<HechoBool> hechos;

    public List<HechoBool> getHechos()
    {
        return hechos;
    }

    public BasedeHechos()
    {
        hechos = new List<HechoBool>();
    }

    public void vaciarHechos()
    {
        hechos.Clear();
        Console.WriteLine("vaciada correctamente");
    }

    public void agregarHecho(HechoBool hecho)
    {
        hechos.Add(hecho);
        Console.WriteLine("agregado correctamente");
    }
    public HechoBool? buscarHechos(string nombre)
    {
        foreach (HechoBool hecho in hechos)
        {
            if (hecho.Nombre().Equals(nombre))
            {
                Console.WriteLine(""+hecho.Nombre()+"("+hecho.Nivel()+")");
                return hecho;
            }
        }
        Console.WriteLine("no encontrado");
        return null;
    }

    public bool? RecuperarValor(string nombre)
    {
        int n = 0;
        foreach (HechoBool hecho in hechos)
        {
            if (hecho.Nombre().Equals(nombre))
            {
                Console.WriteLine("" + hecho.Nombre() + "(" + hecho.valorBool() + ")");
                n=n+1;
                return hecho.valorBool();
            }
        }
        Console.WriteLine("hecho "+ nombre+", no encontrado");
        return null;
    }

   /* public void MostrarHechos()
    {
        String res = "Soluciones encontradas\n";
        foreach( HechoBool aux in hechos) {
            
        }
        Console.WriteLine(res);
    }
*/
}