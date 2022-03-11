using System.Linq;
using WSCLabb2.DAL.Models;

namespace WSCLabb2.DAL
{
    public class StudentStorage
    {

        private readonly IDictionary<int, Student> _students;

        private int _id;

        public StudentStorage()
        {

            _students = new Dictionary<int, Student>();

        }

        //Metod för att hitta en användare efter deras email
        public Student? GetUser(int id)
        {
            if (!_students.Keys.Contains(id))
                return null;
            return _students[id];
        }


        //Metod för att skapa en användare
        public bool CreateStudent(Student student)
        {
            if (_students.Values.Contains(student))
            {
                return false;
            }
            _students.Add(_id++, student);
            return true;
        }
        //Icollection för att hämta alla användare

        public ICollection<Student> GetAllUsers()
        {
            return _students.Values;
        }

        //metod för att updatera användaren
        public bool UpdateUser(int id, Student student)
        {
            if (!_students.Keys.Contains(id))
            {
                return false;
            }

            _students[id] = student;

            return true;
        }

        //metod för att ta bort en användare

        public bool DeleteUser(int id)
        {
            if (!_students.Keys.Contains(id))
            {
                return false;
            }

            _students.Remove(id);

            return true;
        }
    }
}
