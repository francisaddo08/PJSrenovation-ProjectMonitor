using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PJSrenovationWeb.Data;
using PJSrenovationWeb.Models;

namespace PJSrenovationWeb.Pages.PaintingWorks
{
    public class DeleteModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;

        public DeleteModel(PJSrenovationsWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PaintingDecoratingWork PaintingDecoratingWork { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PaintingDecoratingWork = await _context.PaintingDecoratingWorks
                .Include(p => p.Project).FirstOrDefaultAsync(m => m.WorkID == id);

            if (PaintingDecoratingWork == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PaintingDecoratingWork = await _context.PaintingDecoratingWorks.FindAsync(id);

            if (PaintingDecoratingWork != null)
            {
                _context.PaintingDecoratingWorks.Remove(PaintingDecoratingWork);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
