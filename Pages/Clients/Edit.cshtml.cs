using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PJSrenovationWeb.Data;
using PJSrenovationWeb.Models;

namespace PJSrenovationWeb.Pages.Clients
{
    public class EditModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;
        private readonly ILogger _logger;

        public EditModel( PJSrenovationsWebContext context , ILogger<EditModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        [BindProperty]
        public Client Client { get; set; }
       

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Clients.FirstOrDefaultAsync(m => m.ID == id);

            if (Client == null)
            {
                return NotFound();
            }
         
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

            _context.Attach(Client).State = EntityState.Modified;
          

            try
            {
                await _context.SaveChangesAsync();
                if (Client.PropertyAddres)
                {
                    Property newProperty = new Property();
                    newProperty.ClintID = Client.ID;
                    newProperty.Address = Client.AddressLine1;
                    newProperty.Location = Client.AddressLine2;
                    newProperty.County = Client.County;
                    newProperty.Postcode = Client.Postcode;
                    string message = " CLIENT SAVED TO CLIENT TABLE TABLE";
                    _logger.LogInformation(message);
                    _logger.LogInformation(newProperty.Address);
                    return RedirectToPage("/Properties/Create", newProperty);

                }
             
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(Client.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ClientExists(string id)
        {
            return _context.Clients.Any(e => e.ID == id);
        }
    }
}
