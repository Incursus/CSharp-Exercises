using System.Collections;
using System.Collections.Generic;

namespace CollectionDataStructureComparison
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //https://github.com/RehanSaeed/.NET-Big-O-Algorithm-Complexity-Cheat-Sheet/blob/master/Cheat%20Sheet.pdf
            //http://www.vcskicks.com/csharp_data_structures2.php
            /*Duotas studentų sąrašas su vardais ir pavardėm. Kokią sąrašo struktūrą naudoti našumo atžvilgiu vieno studento paieškai:
            1.Kai tikimasi jog visi studentų vardai yra unikalūs ir jų eilė sąraše yra svarbi ? O(n) 
           2.Kai visi studentų vardai unikalūs ir eilė sąraše nesvarbi ?
          3.Kai tarp studentų vardų gali būti pasikartojimų ir eilė sąraše svarbi ?
         4.Gali būti pasikartojimų ir eilė sąraše nesvarbi?
        HINT: bus keturios atskiros struktūros.*/
            /*
              Redas, Gvidas, Darius.
              */

            var firstNamesWithFirstNames = new SortedDictionary<string, string>();
            firstNamesWithFirstNames.Add("Redas", "Redas");



        }
    }
}
