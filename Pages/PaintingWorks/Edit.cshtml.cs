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
using Microsoft.EntityFrameworkCore;
using PJSrenovationWeb.Data;
using PJSrenovationWeb.Models;

namespace PJSrenovationWeb.Pages.PaintingWorks
{
    public class EditModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EditModel( IWebHostEnvironment environment,  PJSrenovationsWebContext context)
        {
            _webHostEnvironment = environment;
            _context = context;
        }

        [BindProperty (SupportsGet =true)]
        public PaintingDecoratingWork PaintingDecoratingWork { get; set; }
        public IFormFile WorkImage { get; set; }

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
           ViewData["ProjectID"] = new SelectList(_context.Project, "ProjectID", "ProjectID");
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
            if (this.WorkImage != null)
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

            _context.Attach(PaintingDecoratingWork).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaintingDecoratingWorkExists(PaintingDecoratingWork.WorkID))
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

        private bool PaintingDecoratingWorkExists(string id)
        {
            return _context.PaintingDecoratingWorks.Any(e => e.WorkID == id);
        }
    }
}
