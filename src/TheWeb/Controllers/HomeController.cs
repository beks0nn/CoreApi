using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWeb.Models;
using TheWeb.Models.Services.Implementation;
using Newtonsoft.Json;
using RestEase;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TheWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("comments/new")]
        [HttpPost]
        public IActionResult AddComment(CommentModel comment)
        {
            var provider = new CommentService();
            CommentModel ret = provider.CreateComment(comment);

            return Content(JsonConvert.SerializeObject(ret));
        }

        [Route("comments/getAll")]
        [HttpGet]
        public IActionResult GetAllComments()
        {
            var provider = new CommentService();
            List<CommentModel> ret = provider.GetComments();

            return Content(JsonConvert.SerializeObject(ret));
        }
    }
}
