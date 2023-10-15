using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace uppgift1
{
    internal class Student
    {
        private int _id;
        private string _name;    
        private int _age;    
        private string _class;
        private string _gender;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string Class { get { return _class;} set { _class = value; } }

        public string Gender { get { return _gender; } set { _gender= value; } }

        public Student(int Id, string Name, int Age, string Class,string Gender)
        {
            _id = Id;
            _name = Name;
            _age = Age;
            _class = Class;
            _gender = Gender;

        }

       
    }
}
