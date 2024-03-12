using BarInfinity;
namespace BauturiInfinity;

public class Bauturi : Bar
{

    static float profit;
    double pretDeBaza;
    double pretAdaos;
    public void Test()
    { Console.WriteLine("Acesta este un test"); }
    
    public Bauturi()
    {

    }
    //static polymorphism
    public void getNameString()
    { Console.WriteLine("Clasa Bauturi: test pentru static polymorphism"); }

    //dynamic polymorphism
    public virtual void getTypeString()
    { Console.WriteLine("Clasa Bauturi: test pentru dynamic polymorphism"); }


}
   