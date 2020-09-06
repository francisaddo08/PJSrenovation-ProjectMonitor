using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PJSrenovationWeb.Data;
using PJSrenovationWeb.Models;

namespace PJSrenovationWeb.Pages.Properties
{
    public class IndexModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;

        public IndexModel(PJSrenovationsWebContext context)
        {
            _context = context;
        }

        public IList<Property> Property { get;set; }

        public async Task OnGetAsync()
        {
            Property = await _context.Properties
                .Include(p => p.Client).Include(p => p.Project)
                .OrderByDescending(p =>p.EntryDate)
                .ToListAsync();
        }
    }
}
