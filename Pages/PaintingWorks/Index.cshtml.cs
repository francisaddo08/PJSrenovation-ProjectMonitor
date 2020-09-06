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
    public class IndexModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;

        public IndexModel(PJSrenovationsWebContext context)
        {
            _context = context;
        }

        public IList<PaintingDecoratingWork> PaintingDecoratingWork { get;set; }
        

        public async Task OnGetAsync()
        {
            PaintingDecoratingWork = await _context
                .PaintingDecoratingWorks
                .Include(p => p.Project)
                .OrderByDescending(p => p.EntryDate)
                .Take(10)
                .ToListAsync();
            

       
        }
    }
}
