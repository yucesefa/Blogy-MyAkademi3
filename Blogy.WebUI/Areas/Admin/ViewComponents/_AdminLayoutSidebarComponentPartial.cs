﻿using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.ViewComponents
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
