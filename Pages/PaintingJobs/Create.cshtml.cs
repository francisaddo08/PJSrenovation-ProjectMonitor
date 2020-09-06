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
using PJSrenovationWeb.Data;
using PJSrenovationWeb.Models;

namespace PJSrenovationWeb.Pages.PaintingJobs
{
    public class CreateModel : PageModel
    {
        private readonly PJSrenovationsWebContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CreateModel(IWebHostEnvironment environment, PJSrenovationsWebContext context)
        {
            this._context = context;
            this._webHostEnvironment = environment;
        }
        [BindProperty]
        public IFormFile JobImage { get; set; }
        [BindProperty(SupportsGet =true)]
        public PaintingDecoratingJob PaintingJob { get; set; }
     
        public string id { get; set; }
        public string Propertyarea { get; set; }
        public string Workarea { get; set; }
        public string WorkStart { get; set; }
        public string Surface { get; set; }
        public int jobid { get; set; }
 public Dictionary<string, string> JobValues { get; set; }

//public IActionResult OnGet()
//{


//    ViewData["SelfEmployedPainterID"] = new SelectList(_context.SelfEmployedPainters, "PainterID", "PainterID");
//    ViewData["WorkID"] = new SelectList(_context.PaintingDecoratingWorks, "WorkID", "WorkID");

//    return Page();
//}
public IActionResult OnGet( string workid, string PropertyArea, string WorkArea, string surface,
    string ExpectedHours, string ProjectID, string ProjectStart, string ProjectEnd)

        {
            var job = _context.PaintingDecoratingJobs
                   .Where(j => j.WorkID == workid)
                   .FirstOrDefault();
            if (job != null)
            {
                this.jobid = job.PaintDecoratingJobID;
                return RedirectToPage("./Details", new { id = this.jobid});
            }
            //JobValues = new Dictionary<string, string>();
            //JobValues.Add("WorkId", workid);
            //JobValues.Add("PropertyArea", PropertyArea);
            //JobValues.Add("WorkArea", WorkArea);
            //JobValues.Add("Surface", surface);
            //JobValues.Add("ExpectedHours", ExpectedHours);
            //JobValues.Add("ProjectID", ProjectID);
            //JobValues.Add("ProjectStart", ProjectStart);
            //JobValues.Add("ProjectEnd", ProjectEnd);
           

            ViewData["SelfEmployedPainterID"] = new SelectList(_context.SelfEmployedPainters, "PainterID", "PainterID");
            ViewData["WorkID"] = new SelectList(_context.PaintingDecoratingWorks, "WorkID", "WorkID");
            
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
                this.PaintingJob.JobImage = imageName; //set db value


            }

            _context.PaintingDecoratingJobs.Add(PaintingJob);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
