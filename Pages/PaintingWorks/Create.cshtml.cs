using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using PJSrenovationWeb.Data;
using PJSrenovationWeb.Models;

namespace PJSrenovationWeb.Pages.PaintingWorks
{
    public class CreateModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        

        public CreateModel( IWebHostEnvironment environment,
            PJSrenovationsWebContext context)
        {
           _context = context;
            _webHostEnvironment = environment;
            
        }

        public IActionResult OnGet()
        {
        ViewData["ProjectID"] = new SelectList(_context.Project.Where(p => p.ActualEndDate == null), 
            "ProjectID", "ProjectID");
            return Page();
        }
        [BindProperty]
        public IFormFile WorkImage { get; set; }
        [BindProperty]
        public PaintingDecoratingWork PaintingDecoratingWork { get; set; }
        

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if ( this.WorkImage != null)
            {
                //get the file name of the image
                var imageName = FileUploads.GetFileName(WorkImage.FileName);
                // combine the rootdir of the web host and the uploads folder in a url string
                var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "ProjectImages");
                //create the url for the image
                var imagePath = Path.Combine(uploadFolder, imageName);
                // upload the image
                this.WorkImage.CopyTo(new FileStream(imagePath, FileMode.Create));
                this.PaintingDecoratingWork.WorkImage = imageName; //set db value


            }
           

            _context.PaintingDecoratingWorks.Add(PaintingDecoratingWork);
            await _context.SaveChangesAsync();
           


            return RedirectToPage("/PaintingJobs/Create", PaintingDecoratingWork);
        }
     
    }
}
