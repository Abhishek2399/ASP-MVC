using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


// When we run this directly we will get error as the page wont be found 
// we need to add it manually in the url : {local host}https://localhost:44329/ + Customer{Controller name}/Display{Action name} 
namespace MVC_Empty.Controllers
{
    public class CustomerController : Controller
    {

        // To Display some thing on screen we need to return String 
        // Display is the action method 
        public string Display()
        {
            return "Welcome to MVC";
        }

        // Returning int values
        public int Add()
        {
            return 100;
        }

        // Getting values 
        // Changes in the url : https://localhost:44329/Customer/Square?id=3
        public int Square(int id = 0)
        {
            return id * id;
        }

    }
}