using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGeneration;
using PJSrenovationWeb.Data;
using PJSrenovationWeb.Models;

namespace PJSrenovationWeb.Pages.Clients
{
    public class CreateModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;
        private readonly Microsoft.Extensions.Logging.ILogger _logger;

        public CreateModel(PJSrenovationsWebContext context,
            ILogger<CreateModel> logger )
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Client Client { get; set; }
            //{ ClientID = Client.ID, 
            //        Address = Client.AddressLine1, Location = Client.AddressLine2,
            //        Client.County,  Client.Postcode
    

    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    // more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Client.PropertyAddres)
            {

                _context.Clients.Add(Client);
                await _context.SaveChangesAsync();
                //PropertyAddress propertyAddess = new PropertyAddress();
                //propertyAddess.ClientID = Client.ID;
                //propertyAddess.Address = Client.AddressLine1;
                //propertyAddess.Location = Client.AddressLine2;
                //propertyAddess.County = Client.County;
                //propertyAddess.Postcode = Client.Postcode;

                Property newProperty = new Property();
                newProperty.ClintID = Client.ID;
                newProperty.Address = Client.AddressLine1;
                newProperty.Location = Client.AddressLine2;
                newProperty.County = Client.County;
                newProperty.Postcode = Client.Postcode;

                string message = " CLIENT SAVED TO CLIENT TABLE TABLE";
                _logger.LogInformation(message);
                _logger.LogInformation( newProperty.Address);
                return RedirectToPage("/Properties/Create", newProperty );
            }

            _context.Clients.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
