using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PJSrenovationWeb.Data;
using PJSrenovationWeb.Models;

namespace PJSrenovationWeb.Pages.SelfEmployedPainters
{
    public class CreateModel : PageModel
    {
        private readonly PJSrenovationWeb.Data.PJSrenovationsWebContext _context;

        public CreateModel(PJSrenovationWeb.Data.PJSrenovationsWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SelfEmployedPainter SelfEmployedPainter { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SelfEmployedPainters.Add(SelfEmployedPainter);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
