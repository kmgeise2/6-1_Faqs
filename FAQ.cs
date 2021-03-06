namespace Faqs.Models
{
    public class FAQ
    {
        public int Id { get; set; }                // Primary Key - generated by database
        public string Question { get; set; }
        public string Answer { get; set; }

        public string TopicId { get; set; }        // Foreign Key pg 156 textbook
        public Topic Topic { get; set; }           // Navigation property

        public string CategoryId { get; set; }     // Foreign Key pg 156 textbook
        public Category Category { get; set; }     // Navigation property
    }
}
