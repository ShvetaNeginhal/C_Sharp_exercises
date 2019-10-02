using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;
namespace Demo1
{
    class Program       
    {
        static void Main(string[] args)
        {
            //ReadFromFile();
            // int count = GetLineCount("D:\\C# FILE HANDLING\\test.txt");
            //Console.WriteLine("Count = " + count);

            //int count = WordCount("D:\\C# FILE HANDLING\\test.txt");
            // Console.WriteLine(" Word Count = " + count);

            //var products = LoadAllProduct("D:\\C# FILE HANDLING\\mytest.txt");
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Product p = new Product();
            //SaveProduct(p, "D:\\C# FILE HANDLING\\test_write.txt");

            ////Write to XML file
            //Product p = new Product { ID = 101, Name = "ABC", Price = 200, InStock = true };
            //SaveAsXml(p, "D:\\C# FILE HANDLING\\mytestXML.xml");

            //Read from XML file
            Product p = GetXmlFile("D:\\C# FILE HANDLING\\mytestXML.xml");
            Console.WriteLine("Name:" + p.Name);
        }

        
        private static void ReadFromFile()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("D:\\C# FILE HANDLING\\test.txt");
                //// To read all at once
                //string str = sr.ReadToEnd();
                //Console.WriteLine(" read all at once");
                //Console.WriteLine(str);

                // to read line by line
                
                Console.WriteLine("Reading line by line");
                while(!sr.EndOfStream)
                {
                    string readline = sr.ReadLine();
                    Console.WriteLine(readline);
                }

            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                if(sr != null)
                sr.Close();
            }
        }

        private static void WriteToFile()
        {
            string msg = "Welcome to EARTH!";
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter("D:\\C# FILE HANDLING\\test.txt", true);
                 sw.WriteLine(msg);
            }
            finally
            {
                sw.Close();
            }
        }

        //Line Count
        private static int GetLineCount(string fname)
        {
            int c = 0;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fname);
                while (!sr.EndOfStream)
                {
                    sr.ReadLine();
                    c++;
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                if (sr != null)
                    sr.Close();

            }
            return c;
        }
        
        //Word-Count
        private static int WordCount(string fname)
        {
            int wc = 0;
            StreamReader sr = null;
            
                sr = new StreamReader(fname);
           
                while (!sr.EndOfStream)
                {
                string readline = sr.ReadLine();
                string[] words = readline.Split(' ');
                wc += words.Length;
                }
            sr.Close();
            return wc;
        }            
        
        //Read structured data 
        private static List<Product> LoadAllProduct(string fname)
        {
            StreamReader sr = new StreamReader(fname);
            List<Product> products = new List<Product>();
            //to skip first line of the file
            sr.ReadLine();
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] words = line.Split(',');
                Product product = new Product();
                product.ID = int.Parse(words[0]);
                product.Name = words[1];
                product.Price = double.Parse(words[2]);
                product.InStock = bool.Parse(words[3]);
                products.Add(product);

            }
            sr.Close();
            return products;
        }
        
        private static void SaveProduct(Product product,string fname)
        {
            StreamWriter sw = new StreamWriter(fname);
            List<Product> products = new List<Product>();

            //Console.WriteLine("enter y/n");
            //string c = Console.ReadLine();
            int c = 0;
            while (c <= 2)
            {
                
                Product p = new Product();
                Console.WriteLine("enter ID");
                p.ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name");
                p.Name = Console.ReadLine();
                Console.WriteLine("Enter Price");
                p.Price = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Instock or not");
                p.InStock = bool.Parse(Console.ReadLine());
                products.Add(p);

                c++;
            }
            foreach (var item in products)
            {
              sw.Write(item.ID + "," + item.Name + "," + item.Price + "," + item.InStock + "\n");
             }
            sw.Close();
        }
        private static void SaveAsXml(Product p, string fname)
        {
            //XML Serialization --> object to XML
            //XML Deserialization --> XML to object
            XmlSerializer serial = new XmlSerializer(typeof(Product));
            Stream stream = File.Open(fname, FileMode.Create);
            serial.Serialize(stream, p);
            stream.Close();
        }
        private static Product GetXmlFile(string fname)
        {
            //XML Deserialization --> XML to object
            XmlSerializer deserial = new XmlSerializer(typeof(Product));
            Stream stream = File.Open(fname, FileMode.Open);
            Product p = (Product)deserial.Deserialize(stream);
            stream.Close();
            return p;
        }

    }

        
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }
    }
}

