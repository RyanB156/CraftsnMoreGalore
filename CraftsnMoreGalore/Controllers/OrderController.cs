using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using CraftsnMoreGalore.Models;
using Newtonsoft.Json;

namespace CraftsnMoreGalore.Controllers
{
    public class OrderController : Controller
    {

        private readonly bool testing = false;

        // GET: Order
        public ActionResult Index()
        {
            Order order;

            if (testing)
            {
                order = new Order()
                {
                    Customer = new Customer("Ryan Bressette", "bressetteryan@gmail.com", "(352)-603-0194"),
                    Description = "My order information"
                };
            }
            else
            {
                order = new Order();
            }

            return View(order);
        }

        [HttpPost]
        public ActionResult Index(Order order)
        {
            if (ModelState.IsValid)
            {
                var content = Newtonsoft.Json.JsonConvert.SerializeObject(order);

                try
                {
                    var publicKey = ConfigurationManager.AppSettings["MJ_APIKEY_PUBLIC"].ToString();
                    var privateKey = ConfigurationManager.AppSettings["MJ_APIKEY_PRIVATE"].ToString();
                    using (var smtpServer = new SmtpClient("in-v3.mailjet.com")
                    {
                        Port = 587,
                        Credentials = new System.Net.NetworkCredential(publicKey, privateKey),
                        EnableSsl = true
                    })
                    {
                        // Send order email.
                        var mail = new MailMessage()
                        {
                            From = new MailAddress("bressetteacres@gmail.com"),
                            Subject = $"Order_{ order.Customer.Name }_{ DateTime.Now.ToLongDateString() }".Replace(' ', '_').Replace(",", ""),
                            Body = order.ToString(),
                        };
                        mail.To.Add("bressetteacres@gmail.com");
                        smtpServer.Send(mail);

                        // Confirmation email.
                        mail = new MailMessage()
                        {
                            From = new MailAddress("bressetteacres@gmail.com"),
                            Subject = $"Order_Confirmation_{ order.Customer.Name }_{ DateTime.Now.ToLongDateString() }".Replace(' ', '_').Replace(",", ""),
                            Body = "Thank you for your order! I will get back with you shortly.\n\n" + order.ToString(),
                        };
                        mail.To.Add(order.Customer.EmailAddress);
                        smtpServer.Send(mail);

                        mail.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    return Content(ex.ToString());
                }

                //return Content("Thank you for your order:\n" + content);
                return View("Confirmation", order);
            }
            else
            {
                return View(order);
            }
        }
    }
}