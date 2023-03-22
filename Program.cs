namespace LINQTestTITpe22
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Test TITpe22");
            Console.WriteLine("\n");
            //Siin kutsusin meetodid välja
            SingleOrDefaultLINQ();
            SkipLINQ();
        }

        public static void SingleOrDefaultLINQ()
        {
            IList<int> oneElement = new List<int>() { 2 };

            Console.WriteLine("Single or Default:");
            //Kui nimekirjas on ainult üks element, tagastatakse see element;
            //kui nimekirjas pole ühtegi elementi, tagastatakse null;
            //kui nimekirjas on rohkem kui üks element, visatakse erind.
            var singleOrDefault = oneElement.SingleOrDefault();
                     
            Console.WriteLine(singleOrDefault);            
        }

        public static void SkipLINQ()
        {          
            Console.WriteLine("\n");
            Console.WriteLine("Skip:");
            //Skip jätab esimesed 5 numbrit Numbers klassit vahele ja
            //jätkab kirjutama ülejäänud numbreid          
            var skip = Numbers.numbrid.Skip(5);
         
            foreach (var value in skip)
            {               
                Console.WriteLine(value);
            }            
        }
    }
}