using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TGLWebApp.Data;
using TGLWebApp.Models;

namespace TGLWebApp.Pages.Computers
{
    public class IndexModel : PageModel
    {
        public ComputerStore ComputerStore { get; set; }
        public List<Computer> Computers { get; set; }
        public IndexModel(ComputerStore computerStore)
        {
            ComputerStore = computerStore;
            Computers = ComputerStore.GetComputers();
        }

        public IActionResult OnPostDelete(Guid id)
        {
            ComputerStore.DeleteComputer(id);
            return RedirectToPage();
        }
        public void OnGet()
        {
        }
    }
}
