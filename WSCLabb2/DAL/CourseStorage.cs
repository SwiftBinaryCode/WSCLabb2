using WSCLabb2.DAL.Models;

namespace WSCLabb2.DAL
{
    public class CourseStorage
    {

        private readonly IDictionary<int, Course> _courses;

        private int _id;

        public CourseStorage()
        {

            _courses = new Dictionary<int, Course>();

        }
        //Metod som skapar en ny kurs

        //metod som registrerar en användare på en kurs

        //Metod som uppdaterar en kurs

        //Metod som hämtar en list av alla kurser

        //Metod som hämtar en kurs efter specifik id

        //Metod som hämtar en lista av alla anvöndare som är registrerad på den kursen

        //Metod som tar bort en kurs


    }
}
