using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            //Use the generic methods
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "Adana", "Antalya");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { Name = "Hayrettin" }, new Customer { Name = "Metin" });
            foreach (var item in result2)
            {
                Console.WriteLine(item.Name);
            }


        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items) //Generic method
        {
            return new List<T>(items);
        }
    }
    //Generic
    interface IProductDal : IRepository<Product>
    {

    }
    interface ICustomerDal : IRepository<Customer>
    {
        void Custom();
        string Name { get; set; }
    }

    class Product : IEntity
    {
        public void Add(Product entity)
        {

        }

        public void Delete(Product entity)
        {

        }

        public Product Get(int id)
        {
            return new Product { };
        }

        public List<Product> GetAll()
        {
            return new List<Product> { };

        }

        public void Update(Product entity)
        {

        }
    }

    class Customer : IEntity
    {
        public string Name { get; set; }

        public void Add(Customer entity)
        {

        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {

        }

        public Customer Get(int id)
        {
            return new Customer { };

        }

        public List<Customer> GetAll()
        {
            return new List<Customer> { };
        }

        public void Update(Customer entity)
        {

        }
    }

    //Generic Repository and generic contains
    interface IRepository<T> where T : class, IEntity, new() //or use to struct
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    interface IEntity
    {

    }
}
