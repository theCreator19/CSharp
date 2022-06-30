using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Linq;
namespace CSharpTraining.Ex15Inventory
{
    public class Inventory : Exercise14
    {
        Dictionary<Product, int> productDict = new Dictionary<Product, int>();
        //public Product prod1, prod2;
        public void ProductDictionary()
        {
            products.CollectionChanged += product_CollectionChanged;
            AddProduct();
            RemoveProduct();

            foreach( var prod in products)
            {

                productDict.Add(prod, 1);
            }

            int i =0;
            RemoveDefective();
            UpdateQuantity();

            foreach(var item in productDict)
            {
                i += 1;
                Console.WriteLine("Item : {0}",i);
                Console.WriteLine("Id :{0}\tPrice {1}\tIsDefective\t{2}\t\tQuantity:  {3}",item.Key.Id, item.Key.Price, item.Key.IsDefective, item.Value);
            }
            TotalValue();
        }
        public void RemoveDefective()
        {
            foreach(var item in products)
            {
                if(item.IsDefective==false)
                {
                    productDict.Remove(item);
                }
            }

        }
        public void UpdateQuantity()
        {
            int quantity = 3;
            int id = 2;
            
            foreach(var item in products)
            {
                if(item.Id==id)
                {
                    productDict[item] = quantity;
                }
            }
        }
        public void TotalValue()
        {
            double totalValue = 0;
            foreach (var item in productDict)
            {
                totalValue += item.Key.Price;
            }
            Console.WriteLine("Total Value : {0}", totalValue);
        }
    }
}
