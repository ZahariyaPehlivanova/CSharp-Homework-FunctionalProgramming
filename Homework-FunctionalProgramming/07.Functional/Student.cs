using System;
using System.Collections.Generic;
public class Student
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string FacultyNumber { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public IList<int> Marks { get; set; }
    public int GroupNumber { get; set; }
    public string GroupName { get; set; }

    public Student(string firstName, string lastName, int age, string facultyNumber, string phone, string email, List<int> marks, int groupNumber, string groupName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.FacultyNumber = facultyNumber;
        this.Phone = phone;
        this.Email = email;
        this.Marks = marks;
        this.GroupNumber = groupNumber;
        this.GroupName = groupName;

    }
    public static void Main()
    {
        var students = new List<Student>
               {
                   new Student("Gosho","Petkov",20,"2255332","088436619","Gosho@yahoo.com",new List<int>{3,5,6,2,4},2,"Second level"),
                   new Student("Mariq","Ivanova",18,"3597415","+359 2357 234","Mariq@abv.bg",new List<int>{2,6,6,5,6},3,"Third level"),
                   new Student("Ana","Dimitrova",17,"8534697","028 5369 328","Ana@abv.bg",new List<int>{6,3,5,4,2},4,"Third level"),
                   new Student("Ivan","Dimitrov",23,"6324875","088935471","Ivan@Gmail.com",new List<int>{3,6,5,4,2},2,"First level"),
                   new Student("Geri","Georgieva",21,"5369554","029 2354 715","Geri@abv.bg",new List<int>{3,2,5,6,4},3,"Second level"),
                   new Student("Pesho","Peshov",20,"8546541","+359 2325 472","Pesho@abv.bg",new List<int>{5,6,5,4,2},4,"First level")
                };
    }
}