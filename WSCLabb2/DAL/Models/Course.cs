namespace WSCLabb2.DAL.Models
{
    public class Course
    {
        
        public int Id { get; set; }
        
        public int courseNumber { get; set; }
        
        public string? courseTitle { get; set; }
       
        public string? courseDescription { get; set; }
        
        public int courseLength { get; set; }
        
        public string? courseLevel { get; set; }
        
        public string? courseStatus { get; set; }
    }
}
