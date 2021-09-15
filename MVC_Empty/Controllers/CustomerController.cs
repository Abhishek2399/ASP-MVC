using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


// When we run this directly we will get error as the page wont be found 
// we need to add it manually in the url : {local host}https://localhost:44329/ + Customer{Controller name}/Display{Action name} 
namespace MVC_Empty.Controllers
{
    public class CustomerController : Controller
    {
        // Inversion of Control : If one object needs another object then Frist object can get other object from another src/file
        // Dependency Injecton : Injecting objects in some file 
        SqlConnection con;
        public CustomerController(SqlConnection conn) // injection of objects is done with the help of constructor  
        {
            con = conn; // conn will come from another file 
        }


        // To Display some thing on screen we need to return String 
        // Display is the action method 
        public string Display()
        {
            return "Welcome to MVC";
        }

        // Returning int values
        public int GetNum()
        {
            return 100;
        }

        // Getting values 
        // Changes in the url : https://localhost:44329/Customer/Square?id=3
        public int Square(int id = 0)
        {
            return id * id;
        }

        // URL Format : {Domain name}/{Controller class name}/{Action func name}?<Param=val>& . . . 

        // Add two numbers and return value 
        // Changes in url : https://localhost:44329/Customer/Add?num1=100&num2=100
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Displaying message with HTML File 
        // ActionResult should be the actual return type of action method 
        // Mother of all return type is action result 
        public ActionResult Greet() 
        {
            return Content("Welcome to MVC");
        }

        // can be called with ref in some html file with the controller name and action method name 
        public ActionResult Home() 
        {
            return Content("Home");
        }

        public ActionResult Login()
        {
            return Content("Login");
        }
        public ActionResult Register()
        {
            return Content("Register");
        }

        



    }
}