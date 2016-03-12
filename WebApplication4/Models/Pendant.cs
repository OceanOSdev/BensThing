using System.Web.UI.HtmlControls;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace WebApplication4.Models
{
    public class Pendant
    {
        [Key]
        public int Id { get; set; }
        public decimal Price { get; }
        public string Description { get; set; }
        public Size PendantSize { get; set; }
        public string PendantImage { get; set; }
        public HttpPostedFileBase UploadedFile { get; set; }
    }

    public enum Size
    {
        Small,
        Medium,
        Large
    }
}