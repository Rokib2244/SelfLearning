// See https://aka.ms/new-console-template for more information
using InterviewProblemSolve;
using Newtonsoft.Json;
//LINQ Query
var number = 12345;
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 };
//var arr2 = (int[])arr.Where(x => x > 20).Cast<Int32>();
IEnumerable<int> myList = (from value in arr where value > 15 select value).Cast<Int32>();
foreach (int i in myList)
{
    // Console.WriteLine(i);
}

string v = number.ToString();
// string[] digits = v;
//Console.WriteLine("Hello, World!");

//JSON 
Student student = new Student
{
    Id = 1,
    StudentName = "Arafat",
    Degree = "BSc in Cse",
    Hobbies = new List<string>() { "Reading", "Gardening" }
};
var jsonconvertedStudent = JsonConvert.SerializeObject(student);
//Console.WriteLine(jsonconvertedStudent);
File.WriteAllText(@"student.json", jsonconvertedStudent);
Console.WriteLine("Stored");
Console.WriteLine("Hello, World!");
