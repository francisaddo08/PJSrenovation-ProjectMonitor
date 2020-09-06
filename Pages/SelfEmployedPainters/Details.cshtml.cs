using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PJSrenovationWeb.Data;
using PJSrenovationWeb.Models;

namespace PJSrenovationWeb.Pages.SelfEmployedPainters
{
    public class DetailsModel : PageModel
    {
        private readonly PJSrenovationWeb.Data.PJSrenovationsWebContext _context;

        public DetailsModel(PJSrenovationWeb.Data.PJSrenovationsWebContext context)
        {
            _context = context;
        }

        public SelfEmployedPainter SelfEmployedPainter { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SelfEmployedPainter = await _context.SelfEmployedPainters.FirstOrDefaultAsync(m => m.PainterID == id);

            if (SelfEmployedPainter == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
