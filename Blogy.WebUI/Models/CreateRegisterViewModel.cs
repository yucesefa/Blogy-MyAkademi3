﻿using Blogy.EntityLayer.Concrete;

namespace Blogy.WebUI.Models
{
    public class CreateRegisterViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
