using Microsoft.AspNetCore.Mvc;
using Messages.Models;
using System.Collections.Generic;

namespace Messages.Controllers
{
    public class MessageController : Controller
    {
        private static List<Message> messages = new List<Message>();
        [HttpGet]
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public IActionResult Index(Message message)
        {
            // Adiciona a nova mensagem à lista
            messages.Add(message);
            // Passa a lista de mensagens para a view
            return View(messages);

            // ViewBag.Name = message.Name;
            // ViewBag.Email = message.Email;
            // ViewBag.Message = message.Content;
            // return View();
        }

    }
}