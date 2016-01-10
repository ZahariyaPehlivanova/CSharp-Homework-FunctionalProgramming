
using System.Collections.Generic;

class excellentClasssec
{
    private List<int> list;
    private string v;

    public excellentClasssec(string v, List<int> list) : this(v, list)
    {
    }

    public excellentClasssec(string v, List<int> list)
    {
        this.v = v;
        this.list = list;
    }

    public class Excellent
    {
        public string FullName { get; set; }

        public IList<int> Marks { get; set; }


        public Excellent(string fullName, List<int> marks)
        {
            this.FullName = fullName;
            this.Marks = marks;
        }
        public static void Main()
        {
            var students = new List<Excellent>
               {
                   new Excellent("Gosho Petkov",new List<int>{3,5,6,2,4}),
                   new Excellent("Mariq Ivanova",new List<int>{2,6,6,5,6}),
                   new Excellent("Ana Dimitrova",new List<int>{6,3,5,4,2}),
                   new Excellent("Ivan Dimitrov",new List<int>{3,6,5,4,2}),
                   new Excellent("GeriGeorgieva",new List<int>{5,6,5,4,2})
                };
        }
    }
}