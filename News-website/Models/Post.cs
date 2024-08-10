namespace News_website.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; } // Thêm trường Description
        public string Image { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; } // Khóa ngoại đến danh mục
    }

}
