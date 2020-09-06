using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PJSrenovationWeb.Models
{
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(8, ErrorMessage = "Project ID must be 8 characters only")]
        [Display(Name = "Project ID")]
        public string ProjectID { get; set; }
        [ForeignKey("Property")]
        [Display(Name = "Property ID")]
        public string PropertyID { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EndDate { get; set; }
         #nullable enable
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ActualEndDate { get; set; }
        public string? ProjectScope { get; set; }
        public string? ProjectImage { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ImageDate { get; set; }
        public int duration
        {
            get
            {
                TimeSpan duration = EndDate - StartDate;
                return duration.Days;
            }
        }
        //public int? ActualDuration
        //{
        //    get
        //    {
        //        TimeSpan? d = ActualEndDate - StartDate;
        //        if( d == null)
        //        {
        //            return 0;
        //        }
        //        return d.Days;
        //    }
        //}
        //public string Schedule
        //{
        //    get
        //    {
        //        int onTime = duration - ActualDuration;
        //        if (onTime == 0)
        //        {
        //            return "On Target";
        //        }
        //        if (onTime < 0)
        //        {
        //            return " Overrun of" + " " + onTime;
        //        }
        //        return "Underrun of " + " " + onTime;
        //    }
        //}
#nullable disable
        public virtual Property Property { get; set; }
        public virtual ICollection<PaintingDecoratingWork> PaintingDecoratingWorks { get; set; }
       // public virtual ICollection<PlumbingWork> PlumbingWorks { get; set; }
       // public virtual ICollection<WallPaperWork> WallPaperWorks { get; set; }
       // public virtual ICollection<ElectricalWork> ElectricalWorks { get; set; }
       // public virtual ICollection<CarpentryWork> CarpentryWorks { get; set; }
        
       


        }
    }
