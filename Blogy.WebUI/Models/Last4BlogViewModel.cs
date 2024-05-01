namespace Blogy.WebUI.Models
{
    public class Last4BlogViewModel
    {
        public int ArticleID { get; set; }
        public string CoverImageUrl { get; set; }
        public string Title { get; set; }   
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public int WriterID { get; set; }
    }
}
