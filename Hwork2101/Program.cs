using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Hwork2101
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            string path = @"C:\Users\ПК\source\repos\Hwork2101\Hwork2101\obj\Debug\product.txt";
            Product product1 = new Product(1, "Хлеб", 60);
            Product product2 = new Product(2, "Сок", 100);
            Product product3 = new Product(3, "Сыр", 250);
            Product product4 = new Product(4, "Колбаса", 200);
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            WriteInFile.inputFIle(path, products);
            ReadInFile.ReadFile(path);
        }
    }

    class WriteInFile
    {

        public static void inputFIle(string path, List<Product> products)
        {
            using (StreamWriter sW = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate)))
            {

                for (int i = 0; i < products.Count; i++)
                {
                    sW.Write(products[i].Id.ToString() + ";");
                    sW.Write(products[i].Name + ';');
                    sW.WriteLine(products[i].Price);
                }
                sW.Close();
            }

        }

    }

    class ReadInFile
    {
        public static void ReadFile(string path)
        {
            using(StreamReader sR = new StreamReader(path))
            {
                Console.WriteLine(sR.ReadToEnd());
                sR.Close();
            }
            
        }
    }
}
