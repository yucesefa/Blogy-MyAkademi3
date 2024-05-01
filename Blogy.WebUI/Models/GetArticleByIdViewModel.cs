namespace Blogy.WebUI.Models
{
    public class GetArticleByIdViewModel
    {
        public int ArticleID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }
        public string CoverImageUrl { get; set; }
        public string Name { get; set; }
        public string NameSurname { get; set; }
        public string UserImageUrl { get; set; }
        public string UserDescription { get; set; }
    }
}
