using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using PJSrenovationWeb.Data;
using PJSrenovationWeb.Models;

namespace PJSrenovationWeb.Pages.Properties
{
    public class CreateModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;
        private readonly ILogger _logger;
     
        public Client Clients { get; set; }
       // [BindProperty(SupportsGet =true)]
        //public PropertyAddress Address { get; set; }
        [BindProperty(SupportsGet =true)]
        public Property Property { get; set; }
        public DateTime today = DateTime.Now;

        public CreateModel(PJSrenovationsWebContext context, ILogger<CreateModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        //public IActionResult OnGet()
        //{
        //ViewData["ClientID"] = new SelectList(_context.Clients, "ID", "ID");
        //    return Page();
        //}
        public IActionResult OnGet(string? ClintID, string? Address, string? Location,
            string? County, string? Postcode)
        {
            Property.ClintID = ClintID;
            Property.Address = Address;
            Property.Location = Location;
            Property.County = County;
            Property.Postcode = Postcode;
            _logger.LogInformation("Info from client  "+Address+ " " + Property.Location);

            

            ViewData["ClientID"] = new SelectList(_context.Clients
                .OrderByDescending(c => c.EntryDate.Year) , "ID", "ID");
                _logger.LogInformation("no property data");
                return Page();
        }
     

     

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
     
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Properties.Add(Property);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
