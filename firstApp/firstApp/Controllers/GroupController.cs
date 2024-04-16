using System;
using firstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstApp.Controllers
{
    public class GroupController : Controller
    {
        private List<Group> _groups;
        public GroupController()
        {
            _groups = new List<Group> { new Group { Id = 1, No = "PB101" }, new Group { Id = 2, No = "PB102" } };
        }

        public JsonResult Get(int id,string no)
        {
            var data = _groups[0];
                return Json(data);
        }
        public JsonResult GetAll()
        {
            return new JsonResult(_groups);
        }
        public ViewResult Page()
        {
            ViewBag.Groups = _groups;
            return View("Index");
        }

    }
}

