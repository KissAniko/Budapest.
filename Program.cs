using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Budapest
{
    internal class Program
    {

      
        static List <Kozterulet> kozteruletek = new List<Kozterulet> ();
        static void Main(string[] args)
        {


      /*    var ell = File.ReadAllLines("bp.csv");
            foreach(var s in ell )
          { 
            Console.WriteLine(s); 
          }  */


           string[] sorok = File.ReadAllLines("bp.csv").Skip(1).ToArray();

          
            for (int i = 0; i < sorok.Length; i++)
            {
                string[] data = sorok[i].Split(';');
              
                Kozterulet kozterulet = new Kozterulet(Convert.ToInt32(data[0]), data[1], data[2], data[3]);
                kozteruletek.Add(kozterulet);                

            }  
            


       /*     using (TextFieldParser sorok = new TextFieldParser("bp.csv"))
            {
                sorok.TextFieldType = FieldType.Delimited;
                sorok.SetDelimiters(";");

                while (!sorok.EndOfData)
                {
                    string[] data = sorok.ReadFields();

                    if (data != null)
                    {
                        Kozterulet kozterulet = new Kozterulet(Convert.ToInt32(data[0]), data[1], data[2], data[3]);
                        kozteruletek.Add(kozterulet);
                    }
                } */
                
                Console.WriteLine("2.feladat");
            Console.WriteLine($"\tTételek száma:{kozteruletek.Count}");

//-----------------------------------------------------------------------------------------------

                Console.WriteLine("3.feladat");
                int kozterSzam = kozteruletek.Where(x => x.Utotag == "köz").Count();
                Console.WriteLine($"\tKözterületek száma a XIII. kerületben:{kozterSzam}");

//-----------------------------------------------------------------------------------------------

                Console.WriteLine("4.feladat");
                Console.WriteLine("Kérek egy irányítószámot!");
                string bekertSzam = Console.ReadLine();
                int irSzam = Convert.ToInt32(bekertSzam);

                bool vanIlyenSzam = kozteruletek.Any(x => x.Irsz == irSzam);
                if (vanIlyenSzam)
                {
                    Console.WriteLine($"Van ilyen irányítószám!");
                }
                else
                {
                    Console.WriteLine($"Nincs ilyen irányítószám!");
                }

            //----------------------------------------------------------------------------------------------


            /* Kérjen be consolon egy szöveget, majd lsitázza az összes olyan közterület nevét és kerületét,
                aminek a neve a megadott szöveggel kezdődik. pl Petőfi */
               Console.WriteLine("5.feladat");

               Console.WriteLine("Kérem a közterület nevének kezdetét!");
               string koztNev = Console.ReadLine();




             var talalatok = kozteruletek.Where(x =>x.Nev == koztNev).ToList();

              if (talalatok.Any())
              {
                   foreach (var talalat in talalatok)
                 {
                     Console.WriteLine($"{talalat.Nev} - {talalat.Ker}. kerület");
                 }
              }
              else
              {
                   Console.WriteLine("Nincs ilyen közterület.");
              }

//-------------------------------------------------------------------------------------------------





}
}
}



