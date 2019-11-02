using EFDemoConsoleApp.DataAccessLayer;
using EFDemoConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------DB First(bottom up)- we need to create database and table, EF will create entity classes and code -------------
            
            //S1: Identify or create DB (ContactsDB)
            //S2: Identify or craete Table (Contact)

            //S3: Generate the entity classes using EF
            //S4 : Perform CRUD operations using EF

            //Add new contact
            // Add();

            //Get All Contacts
            // GetAllContacts();

            ////delete 
            //DeleteContact();

            ////UpdateContact();

            ////Total contact count
            //ContactsDBDataContext db = new ContactsDBDataContext();
            //var totcontact = db.Contacts.Count();
            //Console.WriteLine("Total Count = " + totcontact);


            ////male count
            //var malecount = db.Contacts.Where(c => c.Gender == "Male").Count();
            //Console.WriteLine("Male Count = " + malecount);

            ////female count
            //var femalecount = db.Contacts.Where(c => c.Gender == "F").Count();
            //Console.WriteLine("Female Count = " + femalecount);

           
            //-----------------Code First (top down)- vice versa-----------------

            //S1 : Identify entity class
            //S2 : Extend DBContext Class
            //s3 : Add prperties into extended class
            //s4 : CRUD operations

            ProductsDB db = new ProductsDB();
            //Product p = new Product { Name = "Book", Price = 10,InStock = true,Qty=5 };
            //db.Products.Add(p);
            //db.SaveChanges();

            //Adding to table category

            //Category category = new Category { Name = "Stationery" };
            //db.Categories.Add(category);
            //db.SaveChanges();

            //Product pro = new Product { Name = "Pen", Price = 30, InStock = true, Qty = 70 };
            //Category cat = db.Categories.Where(c => c.Name == "Stationery").First();
            //pro.Category = cat;
            //db.Products.Add(pro);
            //db.SaveChanges();
            //Console.WriteLine("done!");

            //Add new Product to a new category
           
            //Category cat = new Category { Name = "Accessories" };
            //Product pro = new Product { Name = "Watch", Price = 3000, InStock = true, Qty = 30, category = cat };
            //db.Products.Add(pro);
            //db.SaveChanges();

            ////Add new cat and pro
           
            //Category cat = new Category { Name = "Furniture" };
            //Product pro = new Product { Name = "Sofa", Price = 30000, InStock = true, Qty = 10, category = cat };
            //db.Products.Add(pro);
            //db.SaveChanges();

            //Extracting Data from multiple entities

            db.Database.Log = Console.WriteLine;

            //var pnamecname = from p in db.Products
            //                 select new { PName = p.Name, CName = p.category.Name }; // anonyomous object
            //foreach (var item in pnamecname)
            //{
            //    Console.WriteLine(item.PName+"  "+item.CName);
            //}

            //extract and show all products of category stationery
            //var pname = from p in db.Products

            //            where p.category.Name == "Stationery"
            //            select p.Name;

            //find total price of all staionery
            //var price = from p in db.Products
            //            select p.Price;
            //Console.WriteLine(price.Sum());

            



        }




        //-----------------applies to DB first -----------------------

        private static void UpdateContact()
        {
           // Update
            ContactsDBDataContext db = new ContactsDBDataContext();
            var contactUpdate = db.Contacts.Find(23);
            contactUpdate.Gender = "Male";
            db.SaveChanges();
        }

        private static void DeleteContact()
        {
            ContactsDBDataContext db = new ContactsDBDataContext();
            var deleteContact = db.Contacts.Where(c => c.Name == "HermoineGranger").First();
            db.Contacts.Remove(deleteContact);
            db.SaveChanges();
        }

        private static void GetAllContacts()
        {
            ContactsDBDataContext db = new ContactsDBDataContext();
            // to write from DB
            db.Database.Log = Console.WriteLine;
            var allContacts = db.Contacts;
            //foreach (var item in allContacts)
            //{

            //    Console.WriteLine(item.Name);
            //}
            var allBoys = from contact in db.Contacts
                          where contact.Gender == "Male"
                          select contact;
        }

        private static void Add()
        {
            //Add new contact
            Contact c = new Contact();
            c.Name = "HermoineGranger";
            c.Loc = "England";
            c.Gender = "F";
            c.Email = "hermoinegmailcom";
           

            ContactsDBDataContext db = new ContactsDBDataContext();
            db.Contacts.Add(c);
            db.SaveChanges();
        }

       



    }
}
