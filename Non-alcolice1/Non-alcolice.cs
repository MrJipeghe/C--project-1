
using BauturiInfinity;

namespace Non_alcolice1Infinity;

public class Non_alcolice : Bauturi
{

        public string numeBautura;
        public string taraOrigine;
        public string tip;
        public void setNumBaut(string numeBautura)
        {
            this.numeBautura = numeBautura;
            Console.WriteLine("{0}", numeBautura);
        }
        public void settip(string tip)
        {
            this.tip = tip;
            Console.WriteLine("{0}", tip);
        }
        public string gettip()
        { return tip; }

        public void getNameString()
        { Console.WriteLine("Clasa Alcolice: test pentru static polymorphism"); }

        //dynamic polymorphism
        public virtual void getTypeString()
        { Console.WriteLine("Clasa Alcolice: test pentru dynamic polymorphism"); }

    
}