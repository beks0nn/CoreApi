using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWeb.Models;
using TheWeb.Models.Services.Implementation;
using Newtonsoft.Json;
using RestEase;
using TheWeb.Models.Services.Interface;

namespace TheWeb.Controllers
{
    public class HomeController : Controller
    {
        #region Dependency
        private readonly ICommentServiceInternal _commentService;

        public HomeController(ICommentServiceInternal commentService)
        {
            _commentService = commentService;
        }
        #endregion


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("comments/new")]
        [HttpPost]
        public IActionResult AddComment(CommentModel comment)
        {
            var ret = _commentService.CreateComment(comment);
            return Content(JsonConvert.SerializeObject(ret));
        }

        [Route("comments/getAll")]
        [HttpGet]
        public IActionResult GetAllComments()
        {
            var ret = _commentService.GetComments();
            return Content(JsonConvert.SerializeObject(ret));
        }
    }
}
