using Crop_Deal_Web_API.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crop_Deal_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailProcessController : ControllerBase
    {
        [HttpPost("EmailSendings")]
        public IActionResult EmailSending(string email)
        {
            //double totalamount = 0;
            string textBody = "<p> Hello Family, </p> <p>Thank you for ordering from our Online Organic Farm Application.</p> <p>Once the order is approved by farmer, we will process it</p>";
            //textBody += " <table border=" + 1 + " cellpadding=" + 0 + " cellspacing=" + 0 + " width = " + 400 + "><tr bgcolor='#4da6ff'><td><b>Crop Name</b></td> <td> <b> Crop Quantity</b> </td> <td> <b>Crop Type</b> </td> <td> <b>Total Amount</b> </td></tr>";
            //for (int loopCount = 0; loopCount < data_table.Count; loopCount++)
            //{
            //    textBody += "<tr><td>" + data_table[loopCount].CropName + "</td><td> " + data_table[loopCount].CropQty  + "</td><td> " + Convert.ToInt32(data_table[loopCount].OrderTotal) + "</td> </tr>";
            //    totalamount += data_table[loopCount].OrderTotal;
            //}
            //textBody += "</table> <br>";
            //textBody += "<strong>Order Date :</strong>";
            //textBody += data_table[0].OrderDate.ToShortDateString();
            //textBody += "<br><strong>Total Order Amount :</strong>";
            //textBody += totalamount;
            //textBody += "<br>";
            textBody += "<br><i>If you have any queries, contact us here on <b>ktsreddy369@gmail.com</b>! " +
            "We are here to help you! </i>";
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Farmer", "kovvuritejaswisaikeerthireddy@gmail.com"));
            message.To.Add(new MailboxAddress("Dealer", "ktsreddy369@gmail.com"));
            message.Subject = "Order Placed - Online Organic Farm ";
            message.Body = new TextPart("html")
            {
                Text = textBody
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("kovvuritejaswisaikeerthireddy@gmail.com", "oitjmpoztoruhvqe");
                client.Send(message);
                client.Disconnect(true);
            }
            return Ok("Email sent Successfully");
        }
        [HttpPost("AdminEmail/OrderConfirmation")]
        public IActionResult AdminEmailSending(string email)
        //public IActionResult AdminEmailSending(Invoice data_table)
        {
           // double totalamount = 0;
            string textBody = "<p> Hello Dealer, </p> <p>Thank you for ordering from Online Oraganic Farm Application.</p> <p>We’re happy to let you know that we’ve received your order.</p> <p>Your order was approved by farmer, and you will receive your order shortly.</p>";
            //textBody += " <table border=" + 1 + " cellpadding=" + 1 + " cellspacing=" + 1 + " width = " + 600 + "><tr><td><b>Crop Name</b></td> <td> <b> Crop Quantity</b> </td> <td> <b> Crop Type</b> </td> <td> <b>Total Amount</b> </td></tr>";
            //textBody += "<tr><td>" + data_table.CropName + "</td><td> " + data_table.CropQty + "</td><td> " + Convert.ToInt32(data_table.OrderTotal) + "</td> </tr>";
            //totalamount += data_table.OrderTotal;
            //textBody += "</table> <br>";
            //textBody += "<strong>Order Date :</strong>";
            //textBody += data_table.OrderDate.ToShortDateString();
            //textBody += "<br><strong>Total Order Amount :</strong>";
            //textBody += totalamount;
            textBody += "<br><i>If you have any queries, contact us here on <b>8688558004</b>! ";
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Farmer", "kovvuritejaswisaikeerthireddy@gmail.com"));
            message.To.Add(new MailboxAddress("Dealer", "ktsreddy369@gmail.com"));
            message.Subject = "Order Confirmed - Online Organic Farm";
            message.Body = new TextPart("html")
            {
                Text = textBody
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("kovvuritejaswisaikeerthireddy@gmail.com", "oitjmpoztoruhvqe");
                client.Send(message);
                client.Disconnect(true);
            }
            return Ok("Email sent Successfully");
        }         //Supplier Email Sending


        //[HttpPost("SupplierMail/StockRelated")]
        //public IActionResult EmailSendingToSupplier(string email)
        //{
        //    string textBody = "<p> Hello Supplier, We got a order greater than your supplies. please update your drugs </p>";
        //    var message = new MimeMessage();
        //    message.From.Add(new MailboxAddress("Pharmacy", "vajjarajaiah@gmail.com"));
        //    message.To.Add(new MailboxAddress("doctor", email));
        //    message.Subject = "Order Confirmed - Pharmacy Management System";
        //    message.Body = new TextPart("html")
        //    {
        //        Text = textBody
        //    };
        //    using (var client = new SmtpClient())
        //    {
        //        client.Connect("smtp.gmail.com", 587, false);
        //        client.Authenticate("vajjarajaiah@gmail.com", "usyfubldxvakaxvc");
        //        client.Send(message);
        //        client.Disconnect(true);
        //    }
        //    return Ok("Email sent Successfully");
        //}
    }
}

