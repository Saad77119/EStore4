
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStore.Shared.Models;

using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using RestSharp;

namespace EStore.Server.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        
        userData user_data;
        eccomerence_storeContext dbCon;
        public AccountController()
        {
            dbCon = new eccomerence_storeContext();
            user_data = new userData();
            

        }
        [HttpGet]
        [Route("data")]
        public List<User> show_user_data()
        {
            return user_data.get_all_users();
           

        }

        [HttpPost]
        [Route("register")]
        public void register(User objUsr)
        {


               objUsr.Is_verified = false;



            var is_emailexist = IsEmailExists(objUsr.Email);

            if (is_emailexist)
                       {
                           ModelState.AddModelError("EmailExists", "Email already Exists");
                          // return View("Registration");
                       }
                       //it generate unique code
                       System.Guid guid = System.Guid.NewGuid();
                       objUsr.Is_token = guid.ToString();
                       //password convert    
                       objUsr.Password = encryptPassword.textToEncrypt(objUsr.Password); ;
                       //.Models.encryptPassword.textToEncrypt(objUsr.password);
                       dbCon.Users.Add(objUsr);
                       dbCon.SaveChanges();
                       // Send Email verification
                       // SendEmailToUser(objUsr.Email, objUsr.Is_token.ToString());
                       var message = "Registration Completed plese check the Email " + objUsr.Email;
            //  ViewBag.message = message;
            Console.WriteLine(message);

                       
        }

        //Return Register view
        public bool IsEmailExists(string eMail)
        {
            var IsCheck = dbCon.Users.Where(email => email.Email == eMail).FirstOrDefault();
            return IsCheck != null;
        }
        public void SendEmailToUser(string emailId, string activationCode)
        {
            var GenarateUserVerificationLink = "http://localhost:55700/Register/UserVerification/" + activationCode;
            
           
            string fromMail = "saadraza.official @gmail.com";
            string fromPassword = "dzlmmavktutqnmae";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Email Verification";
            message.To.Add(new MailAddress(emailId));
            message.Body = "<br/> Your registration completed succesfully." +
                          "<br/> please click on the below link for account verification" +
                          "<br/><br/><a href=" + GenarateUserVerificationLink + ">" + GenarateUserVerificationLink + "</a>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            smtpClient.Send(message);
        }

        public ActionResult UserVerification(string id)
        {

            //dbCon.Configuration.ValidateOnSaveEnabled = false; // Ignor to password confirmation     
            var IsVerify = dbCon.Users.Where(u => u.Is_token == (new Guid(id)).ToString()).FirstOrDefault();
            var message="";
            if (IsVerify != null)
            {
                IsVerify.Is_verified = true;
                dbCon.SaveChanges();

                message = "Email Verification completed";
                Console.WriteLine(message);
            }
            else
            {
               message = "Invalid Request...Email not verify";
                //ViewBag.Status = false;
            }
            // Console.WriteLine(message);
            //ViewBag.Message = message;
              return Content(message); 
        }

     [HttpPost]
        [Route("Login")]
        [ValidateAntiForgeryToken]
       
        public ActionResult Login(UserLogin LgnUsr)
        // public ActionResult Login(UserLogin LgnUsr)
        {
            var _passWord = encryptPassword.textToEncrypt(LgnUsr.password);
            bool Isvalid = dbCon.Users.Any(x => x.Email == LgnUsr.email && x.Is_verified == true &&
            x.Password == _passWord);
            if (Isvalid)
            {
                var obj = dbCon.Users.Where(a => a.Email.Equals(LgnUsr.email)).FirstOrDefault();

                HttpContext.Session.SetString("userid", obj.Id.ToString());
                HttpContext.Session.SetString("fname", obj.Fname.ToString());
                HttpContext.Session.SetString("lname", obj.Lname.ToString());
                HttpContext.Session.SetString("email", obj.Email.ToString());
                HttpContext.Session.SetString("role",  obj.Is_role.ToString());

                if (obj.Is_role == '1')
                {
                  //  return "admindashbord";
                    //Console.WriteLine);
                     return RedirectToAction("Index", "admindashbord");
                }
                else if (obj.Is_role == '2')
                {
                   // return "userdashbord";
                   // Console.WriteLine("userdashbord");
//                    return Content("Login Successfully");
                     return RedirectToAction("Index", "userdashbord");


                }
                else
                {
                   // return "sellerdashbord";
//                    Console.WriteLine("sellerdashbord");
                    
                    //return Content("Login Successfully");
                      return RedirectToAction("Index", "sellerdashbord");

                }


            }
            else
            {
           //     return "Invalid Information... Please try again!";
                //return Content("Login Error");
                 ModelState.AddModelError("", "Invalid Information... Please try again!");
            }

            return RedirectToAction("Login");
            //Console.WriteLine("Data is nt valid");
        }

        [HttpGet]
        [Route("Logout")]
        public ActionResult Logout()
        {
          
            HttpContext.Session.Clear(); // it will clear the session at the end of request
            return RedirectToAction("Login");
        }


    }





}

