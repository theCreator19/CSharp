using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using CSharpTraining.Ex15Inventory;
using System.Collections.Specialized;

namespace CSharpTraining
{

    public class Exercise14 : Product
    {
        //initialises 
        public Product prod1, prod2,prod3;
        //Creating observable collection of products
        public ObservableCollection<Product> products = new ObservableCollection<Product>();
        
        public void product_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Change type: " + e.Action);
            if (e.NewItems != null)
            {
                Console.WriteLine("Items added: ");
                foreach (Product item in e.NewItems)
                {
                    Console.WriteLine("ID : {0}\tPrice : {1}\tIsDefective : {2}",item.Id,item.Price,item.IsDefective);
                }
            }

            if (e.OldItems != null)
            {
                Console.WriteLine("Items removed: ");
                foreach (Product item in e.OldItems)
                {
                    Console.WriteLine("ID : {0}\tPrice : {1}\tIsDefective : {2}", item.Id, item.Price, item.IsDefective);
                }
            }
        }
        
        //to add product
        public void AddProduct()
        {
            prod1 = new Product { Id = 1, Price = 20, IsDefective = true };
            prod2 = new Product { Id = 2, Price = 30, IsDefective = true };
            prod3 = new Product { Id = 3, Price = 50, IsDefective = false };
            products.Add(prod1);
            products.Add(prod2);
            products.Add(prod3);

        }
        //to remove product
        public void RemoveProduct()
        {
            products.Remove(prod1);
            
        }
    }
}
