using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using TestLogin.Pages.Models;
using Microsoft.EntityFrameworkCore;

namespace TestLogin.Pages
{
    public class LoginModel : PageModel
    {
        public string Message = "ETO DA:";
        public string LoginState = "";
        private readonly TestLogin.Pages.Models.UserContext _context;
        public bool isGood;

        //public LoginModel(TestLogin.Pages.Models.UserContext context)
        // {
        //    _context = context;
        //}
        [BindProperty]
        public IList<User> User { get; set; }
        

        public void OnPost(string log, string pwd)
        {
            foreach(var item in User)
            {
                    Message += item.Login;
            }
        }
    }
}
