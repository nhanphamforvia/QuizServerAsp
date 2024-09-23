namespace QuizApi.DTOs
{
    public class QuestionToCreate
    {
        public int Id { get; set; }

        public string QuestionInWords { get; set; }

        public string? ImageName { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }

        public string Option4 { get; set; }

        public int Answer { get; set; }
    }
}