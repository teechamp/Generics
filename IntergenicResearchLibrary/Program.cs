using System;
using System.Collections.Generic;

namespace IntergenicResearchLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
                Library library1 = new Library(28, 3, 2020, 5, 4, 2020, "Stuart", "100 level", "Things fall apart", "712", "John","Arise", "9999");
                Library library2 = new Library(30, 7, 2020, 4, 2, 2020, "Pamela", "200 level", "Our Husband Has Gone mad Again", "767", "Jan","Dont Cry", "8765");
                Library library3 = new Library(15, 3, 2020, 11, 9, 2020,"Prince", "300 level", "Half of a Yellow Sun", "743", "Jean","Shadow", "9986");
                Library library4 = new Library(18, 1, 2020, 4, 6, 2020, "Justice", "100 level", "Black Shadow", "766", "John","Eclipse", "66543");
                Library library5 = new Library(30, 6, 2020, 9, 5
                , 2020, "James", "200 level", "Amateur Love", "789", "John","Things Fall Apart", "9876");


            GenericDefaulterList<IDefaulter> library = new GenericDefaulterList<IDefaulter>(6); 


               library.Add(library1);                     
               library.Add(library2);                     
               library.Add(library3);                     
               library.Add(library4);                     
               library.Add(library5);  
             

            library.GetDefaulter();
            
            
            
            }
    }
}
