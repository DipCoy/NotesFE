using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotesFETelegramBot;

namespace NotesFETelegramBot.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "MY SHIT!";
        }
    }
}