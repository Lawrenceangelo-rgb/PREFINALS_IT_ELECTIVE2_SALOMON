namespace IT_ELECTIVE_2_PREFINAL_EXAM.Models
{
    public class ExamQuestion
    {
        public int Number { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new List<string>();
        public string CorrectOption { get; set; } = string.Empty; // e.g. "A", "B", "C", or "D"
        public string CorrectAnswerText { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
        public string Topic { get; set; } = string.Empty;
    }
}