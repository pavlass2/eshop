﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages
{
    public class ScienceFictionModel : PageModel
    {
        readonly IDataAcces dataAcces;
        public IQueryable<Item> Items { get; set; }
        public ScienceFictionModel(IDataAcces dataAcces)
        {
            this.dataAcces = dataAcces;
        }
        public IActionResult OnGet(Lang lang)
        {
            Items = dataAcces.GetLangCategoryItems(lang, Category.ScienceFiction);
            return Page();
        }
    }
}