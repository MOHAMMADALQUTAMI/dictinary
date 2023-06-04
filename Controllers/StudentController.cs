using System.Security.Cryptography;
using System.Net;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Generics.Models;
using System.Linq;
using Generics.Models;
namespace Generics.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public  class StudentController:ControllerBase{
public static readonly List<string> student = new List<string>(){
    "m1", "I1", "A1", "E1", "S1"
};
[HttpGet()]
 public int Getfirst(int key )
 {
     IList<int> d = new List<int>(){ 7, 10, 21, 30, 45, 50, 87 };
        if (d.Contains(key))
        {
            return d.First();// O(1)
        }
    else{
        return d.Single();
    }
}
[HttpGet()]
public string Getfirstordefault(string key ){
    IList<string> s = new List<string>() { null, "Two", "Three", "Four", "Five" };
    if (s.Contains(key)){
     return s.FirstOrDefault();
    }
    else{
        return s.SingleOrDefault();
    }
}
[HttpGet()]
public bool AnyAndALL(int key ){
    IList<Student> studentList = new List<Student>() { 
        new Student() { Id = 1, Name = "John", Age = 18 } ,
        new Student() { Id= 2, Name = "Steve",  Age = 15 } ,
        new Student() { Id = 3, Name = "Bill",  Age = 25 } ,
        new Student() { Id = 4, Name = "Ram" , Age = 20 } ,
        new Student() { Id = 5, Name = "Ron" , Age = 19 } 
    };
    bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);
    return areAllStudentsTeenAger;
    //bool isAnyStudentTeenAger = studentList.Any(s => s.age > 12 && s.age < 20);
//true
}


}