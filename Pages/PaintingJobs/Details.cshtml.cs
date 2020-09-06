using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PJSrenovationWeb.Data;
using PJSrenovationWeb.Models;

namespace PJSrenovationWeb.Pages.PaintingJobs
{
    public class DetailsModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;

        public DetailsModel(PJSrenovationsWebContext context)
        {
            _context = context;
        }

        public PaintingDecoratingJob PaintingDecoratingJob { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PaintingDecoratingJob = await _context.PaintingDecoratingJobs
                .Include(p => p.Painter)
                .Include(p => p.Work).ThenInclude(w => w.Project).ThenInclude(p => p.Property)
                .FirstOrDefaultAsync(m => m.PaintDecoratingJobID == id);

            if (PaintingDecoratingJob == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
