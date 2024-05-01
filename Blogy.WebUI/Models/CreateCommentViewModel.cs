namespace Blogy.WebUI.Models
{
    public class CreateCommentViewModel
    {
        public int ArticleID { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Message { get; set; }
    }
}
