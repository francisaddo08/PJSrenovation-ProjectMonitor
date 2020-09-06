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
    public class IndexModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;

        public IndexModel(PJSrenovationsWebContext context)
        {
            _context = context;
        }

     //   public IList<PaintingDecoratingJob> PaintingDecoratingJob { get;set; }
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public GeneralPaginationList<PaintingDecoratingJob> PaintingDecoratingJob { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString, string currentFilter, int? pageIndex)
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            CurrentFilter = searchString;

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            IQueryable<PaintingDecoratingJob> PaintingJobIQ = _context
                .PaintingDecoratingJobs
                .Include(p => p.Painter)
                .Include(p => p.Work)
                .AsQueryable();
                                               
                                                               
                                                            
            if (!String.IsNullOrEmpty(searchString))
            {
                PaintingJobIQ = PaintingJobIQ.Where(p => p.WorkID.Contains(searchString) ||
                   p.SelfEmployedPainterID.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    PaintingJobIQ = PaintingJobIQ.OrderByDescending(p => p.SelfEmployedPainterID) ;
                    break;
                case "Date":
                    PaintingJobIQ = PaintingJobIQ.OrderBy(p => p.StartDate);
                    break;
                case "date_desc":
                    PaintingJobIQ = PaintingJobIQ.OrderByDescending(p => p.StartDate);
                    break;
                default:
                    PaintingJobIQ = PaintingJobIQ.OrderByDescending(p => p.StartDate);
                    break;
            }

            int pageSize = 3;
            PaintingDecoratingJob = await GeneralPaginationList<PaintingDecoratingJob>.CreateAsync(
                PaintingJobIQ.AsNoTracking(), pageIndex ?? 1, pageSize);


        }
    }
}
