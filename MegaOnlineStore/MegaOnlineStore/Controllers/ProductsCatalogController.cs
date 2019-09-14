using MegaOnlineStore.Models.DataAccess;
using MegaOnlineStore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MegaOnlineStore.Controllers
{
    public class ProductsCatalogController : Controller
    {
        IProductsRepository repo = new ProductsRepository();
        //this is wat the customer has added to the cart
        //it can be datavase,file,list
       static private List<SaleItem> cart = null;
        // GET: ProductsCatalog
       
        public ActionResult List(int min=0, int max=0,string Category = null)
        {
            //S1: get list of products from DAL layer
            List<SaleItem> p;

            if(Category == null)
            {
                if(min == 0 && max ==0)
                {
                    p = repo.GetSaleItems().ToList();
                }
                else
                {
                    p = repo.GetSaleItemByPriceRange(min,max).ToList();
                }
            }
            else
            {
                List<SaleItem> pbyprice =  new List<SaleItem>();
                p = repo.GetSaleItemByCategory(Category).ToList();
                foreach (var item in p)
                {
                    if(item.Price <= max  && item.Price >= min)
                    {
                        pbyprice.Add(item);
                    }
                }
                p = pbyprice;
            }
            //returning final list of saleitem
            return View(p);

        }
        public ActionResult AddToCart(SaleItem s)
        {
            //S1: do validation
            if(ModelState.IsValid)
            //s2: store item in cart
            {
                if(Session["Cart"] == null) //first time visit
                {
                    cart = new List<SaleItem>(); // allocating memory here
                    Session["Cart"] = cart; // put cart into session, happens on first time
                }
                else
                {
                    cart = (List<SaleItem>) Session["Cart"]; 
                }
                cart.Add(s);
            }
            //s3: return cart view
            //view name - shoppingcart
            
            return View("shoppingcart",cart);
        }
        
    }
}