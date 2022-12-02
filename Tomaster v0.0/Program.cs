// See https://aka.ms/new-console-template for more information

using Tomaster_v0._0;

Console.WriteLine("Hello, World!");
    BasedeHechos bh = new BasedeHechos();
    HechoBool hb = new HechoBool("juan",true,0,null);
    HechoBool hb2 = new HechoBool("marco",true,0,null);
    HechoBool hb3 = new HechoBool("till",false,0,null);
    bh.agregarHecho(hb);
    bh.agregarHecho(hb2);
    bh.agregarHecho(hb3);
   // bh.vaciarHechos();
    bh.buscarHechos("marco");
    bh.buscarHechos("marcosias");
    bh.buscarHechos("marcosias"); 
    bh.RecuperarValor("till");
    bh.RecuperarValor("tillaaa");
    
Console.ReadKey();
// bh.MostrarHechos();