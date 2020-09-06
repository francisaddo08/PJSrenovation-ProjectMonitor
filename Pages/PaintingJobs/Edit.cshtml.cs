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

namespace PJSrenovationWeb.Pages.PaintingJobs
{
    public class EditModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EditModel(PJSrenovationsWebContext context, IWebHostEnvironment environment)
        {
            this._context = context;
            this._webHostEnvironment = environment;
        }
        public string FileName { get; set; }
        [BindProperty]
        public IFormFile JobImage { get; set; }
        [BindProperty]
        public PaintingDecoratingJob PaintingDecoratingJob { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PaintingDecoratingJob = await _context.PaintingDecoratingJobs
                .Include(p => p.Painter)
                .Include(p => p.Work).FirstOrDefaultAsync(m => m.PaintDecoratingJobID == id);

            if (PaintingDecoratingJob == null)
            {
                return NotFound();
            }
            ViewData["SelfEmployedPainterID"] = new SelectList(_context.SelfEmployedPainters, "PainterID", "PainterID");
            ViewData["WorkID"] = new SelectList(_context.PaintingDecoratingWorks, "WorkID", "WorkID");
            ViewData["JobImage"] = _context.PaintingDecoratingJobs;
            this.FileName = PaintingDecoratingJob.JobImage;
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
            if (this.JobImage != null)
            {
                //get the file name of the image
                var imageName = FileUploads.GetFileName(JobImage.FileName);
                // combine the rootdir of the web host and the uploads folder in a url string
                var uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "ProjectImages");
                //create the url for the image
                var imagePath = Path.Combine(uploadFolder, imageName);
                // upload the image
                this.JobImage.CopyTo(new FileStream(imagePath, FileMode.Create));
                this.PaintingDecoratingJob.JobImage = imageName; //set db value
            }
            else
            {
                PaintingDecoratingJob.JobImage = FileName;
            }

            _context.Attach(PaintingDecoratingJob).State = EntityState.Modified;


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaintingDecoratingJobExists(PaintingDecoratingJob.PaintDecoratingJobID))
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

        private bool PaintingDecoratingJobExists(int id)
        {
            return _context.PaintingDecoratingJobs.Any(e => e.PaintDecoratingJobID == id);
        }
    }
}
