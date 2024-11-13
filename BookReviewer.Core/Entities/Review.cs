namespace BookReviewer.Core.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public int IdUser { get; set; }
        public int IdBook { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
