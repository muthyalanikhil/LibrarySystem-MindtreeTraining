using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace LibrarySystem
{
    class HashtableListDemo
    {
        public HashtableListDemo()
        {
           
            Hashtable hashTable = new Hashtable();

            hashTable.Add("1032629", "Vicky");
            hashTable.Add("1032768", "Nikhil");
            hashTable.Add("1032567", "Kunal");
            hashTable.Add("1098454", "Manish");

            Console.WriteLine("ID\t Name");

            foreach (var keyValue in hashTable)
            {
                Console.WriteLine("{0},{1}",hashTable[keyValue],hashTable[key]);
            }
        }
    }
}
