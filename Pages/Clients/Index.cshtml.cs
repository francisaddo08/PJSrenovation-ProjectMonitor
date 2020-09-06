using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PJSrenovationWeb.Data;
using PJSrenovationWeb.Models;

namespace PJSrenovationWeb.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;

        public IndexModel(PJSrenovationsWebContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public GeneralPaginationList<Client> Client { get; set; }

        //public IndexModel (string nameSort, string dateSort, string currentFilter, string currentSort) {
        //    this.NameSort = nameSort;
        //    this.DateSort = dateSort;
        //    this.CurrentFilter = currentFilter;
        //    this.CurrentSort = currentSort;

        //}

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

            IQueryable<Client> ClientsIQ = from s in _context.Clients select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                ClientsIQ = ClientsIQ.Where(c => c.LastName.Contains(searchString) ||
                   c.FirstName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    ClientsIQ = ClientsIQ.OrderByDescending(c => c.LastName);
                    break;
                case "Date":
                    ClientsIQ = ClientsIQ.OrderBy(c => c.EntryDate);
                    break;
                case "date_desc":
                    ClientsIQ = ClientsIQ.OrderByDescending(c => c.EntryDate);
                    break;
                default:
                    ClientsIQ = ClientsIQ.OrderBy(c => c.LastName);
                    break;
            }

            int pageSize = 3;
            Client = await GeneralPaginationList<Client>.CreateAsync(
                ClientsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}

