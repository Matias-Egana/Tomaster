namespace Tomaster_v0._0;

public class Aplicacion : InterfazH
{
    public bool pedirValor(string pregunta)
    {
        try
        {
            Console.WriteLine(pregunta + "(si o no)");

        }
        catch (Exception e)
        {
            return false;
        }
    }

/*
 * try {
System.out.println(pregunta+ " (si, no)");
BufferedReader br = new BufferedReader(new
InputStreamReader(System.in));
String res = br.readLine();
return (res.equals("si")};
}
catch (IOException e) {
return false;
}
 */
    public void mostrarHechos(List<unHecho> hechos)
    {
       /*
     String res = "Solucion(es) encontrada(s) : \n";

    Collections.sort(hechos, (IHecho f1, IHecho f2) -> {
    return Integer.compare(f1.Nivel(), f2.Nivel()*(-1);
    });
    foreach(HechoBool h in hechos) {
    if (h.Nivel() != 0) {
    res += h.toString() + "\n";
        */
    }

    public void mostrarReglas(List<unaRegla> reglas)
    {
        /*
            String res = "";
            foreach(unaRegla r in reglas) {
                res += r.toString() + "\n";
            }
            Console.WriteLine(res);
        */
    }
}