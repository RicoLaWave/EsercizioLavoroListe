using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EsercizioLavoroListe
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creo la lista dei lavoratori
            List<Lavoratore> listLavoratore = new List<Lavoratore>();
            Lavoratore[] lavoratore = new Lavoratore[]
            {
               new Lavoratore("Federico", "Verdi", 'M', 1500, 2),
               new Lavoratore("Matteo", "Bianchi", 'M', 1200, 3),
               new Lavoratore("Adriano", "Rossi", 'M', 1100, 5),
               new Lavoratore("Elena", "Rosa", 'F', 1800, 7),
            };

            listLavoratore.AddRange(lavoratore);

            //creo una stringa che mi sarà utile per visualizzare l'intera lista;
            StringBuilder sb = new StringBuilder();
            foreach (var p in listLavoratore)
            {
                sb.AppendLine(p.ToString());
            }
            string path = "C:\\Users\\CORSO 45\\Desktop\\Lavoratore";
            string fileName = "LavoratoreListe.txt";

            //Controllo DIRECTORY 
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string fullPath = Path.Combine(path, fileName);

            //Controllo del FILE
            if (!File.Exists(path + "\\" + fileName))
            {
                File.Create(fullPath);
            }

            File.WriteAllText(fullPath, sb.ToString());
            string result = File.ReadAllText(fullPath);
            Console.WriteLine(result);


            //SERIALIZZAZIONE DEI LAVORATORI 
            Lavoratore l1 = new Lavoratore("Federico", "Gialli", 'M', 2500, 12);

            XmlSerializer serializer = new XmlSerializer(typeof(Lavoratore));
            fullPath = Path.Combine(path, "LavoratoreList1.xml");
            FileStream ll1 = File.Open(fullPath, FileMode.Create);
            serializer.Serialize(ll1, l1);
            Console.WriteLine(l1);
            ll1.Close();

            //DESERIALIZZAZIONE DEI LAVORATORI 
            fullPath = Path.Combine(path, "LavoratoreList1.xml");
            FileStream ll2 = File.Open(fullPath, FileMode.Open);
            Lavoratore l2 = (Lavoratore)serializer.Deserialize(ll2);
            ll2.Close();
            Console.WriteLine(l2);


            Console.ReadLine();
        }
       
    }
}
