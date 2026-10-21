namespace Lab2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Branch { get; set; }
        public Gender Gender { get; set; }
        public bool IsRegular { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
    }
}
