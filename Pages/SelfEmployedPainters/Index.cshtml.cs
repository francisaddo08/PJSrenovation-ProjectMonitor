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
    public class IndexModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;

        public IndexModel(PJSrenovationsWebContext context)
        {
            _context = context;
        }

        public IList<SelfEmployedPainter> SelfEmployedPainter { get;set; }

        public async Task OnGetAsync()
        {
            SelfEmployedPainter = await _context.SelfEmployedPainters.ToListAsync();
        }
    }
}
