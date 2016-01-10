using System;
using System.Collections.Generic;
using System.Linq;

    class ExcellentStudents
        {
        static void Main(string[] args)
        {
            var students = new List<Student>
               {
                   new Student("Gosho","Petkov",20,"2255332","088436619","Gosho@yahoo.com",new List<int>{3,5,6,2,4},2,"Second level"),
                   new Student("Mariq","Ivanova",18,"3597415","0896357417","Mariq@abv.bg",new List<int>{2,6,6,5,6},3,"Third level"),
                   new Student("Ana","Dimitrova",17,"8534697","0885369428","Ana@abv.bg",new List<int>{6,3,5,4,2},4,"Third level"),
                   new Student("Ivan","Dimitrov",23,"6324875","088935471","Ivan@Gmail.com",new List<int>{3,6,5,4,2},2,"First level"),
                   new Student("Geri","Georgieva",21,"5369554","0892354715","Geri@abv.bg",new List<int>{3,2,5,6,4},3,"Second level"),
                   new Student("Pesho","Peshov",20,"8546541","0896325472","Pesho@abv.bg",new List<int>{5,6,5,4,2},4,"First level")
               };

             var studentsByPhone =
                from student in students
                where student.Marks.Max() == 6
                select student;
            foreach (var student in studentsByPhone)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} ({6}), {7}", student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.Phone, student.Email, string.Join(" ", student.Marks), student.GroupNumber);
            }
        }
    }

