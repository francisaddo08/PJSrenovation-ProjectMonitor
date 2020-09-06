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
    public class DeleteModel : PageModel
    {
        private readonly PJSrenovationWeb.Data.PJSrenovationsWebContext _context;

        public DeleteModel(PJSrenovationWeb.Data.PJSrenovationsWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PaintingDecoratingJob PaintingDecoratingJob { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PaintingDecoratingJob = await _context.PaintingDecoratingJobs
                .Include(p => p.Painter)
                .Include(p => p.Work).FirstOrDefaultAsync(m => m.PaintDecoratingJobID == id);

            if (PaintingDecoratingJob == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PaintingDecoratingJob = await _context.PaintingDecoratingJobs.FindAsync(id);

            if (PaintingDecoratingJob != null)
            {
                _context.PaintingDecoratingJobs.Remove(PaintingDecoratingJob);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
