using AlcoliceInfinity;
namespace BereInfinity
{
    public class Bere : Alcolice
    {
        public string numeBere;
        public int procentAlcol;
        public string tip;
        public void setNumBere(string numeBere)
        {
            this.numeBere = numeBere;
            Console.WriteLine("{0}", numeBere);
        }
        public void settip(string tip)
        {
            this.tip = tip;
            Console.WriteLine("{0}", tip);
        }
        public void setProcentAlcol(int procentAlcol)
        {
            this.procentAlcol = procentAlcol;
        }
            public string getNumeBere()
        { return numeBere; }

        public void getNameString()
        { Console.WriteLine("Clasa Bere: test pentru static polymorphism"); }

        //dynamic polymorphism
        public virtual void getTypeString()
        { Console.WriteLine("Clasa Bere: test pentru dynamic polymorphism"); }
        /*void Baru.baru()
        { Console.WriteLine("Bere interfata"); }*/

    }
}
