
using System.Security.Cryptography;
using System.Net;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Generics.Models;
using System.Linq;

namespace Generics.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public  class EmployeeController:ControllerBase
{
    public static readonly List<string> employee = new List<string>()
    {
        "DEVELOPER", "IT", "ACCOUNTENT", "ENGINEERING", "SALES"
    };
    
    [HttpGet(Name="Add")]
    public string GetDictionaryValue(int key )
    {
        var d = new Dictionary<int, string>();
        d.Add(1,"Developer");
        d.Add(2,"IT");
        d.Add(3,"ACCOUNTENT");
        d.Add(4,"ENGINEERING");
        d.Add(5,"SALES");
        var strings = new HashSet<string>(employee);
           var result= d.Where(p=> strings.Contains(p.Value))
        .ToDictionary(p=> p.Key, p=> p.Value);
        if (d.ContainsKey(key))
        {
            return d[key];// O(1)
        }

        return "Not Found";
    
    }

    [HttpPost(Name = "Remove Employee")]
    public string RemoveDictionary(int key)
    {
        var d = new Dictionary<int, string>();
          foreach(var ele in employee)
          {
             if (d.ContainsKey(1)){
                d.Remove(key);
             }                            //   Console.WriteLine("{0} and {1}",
                                               //               ele.Key, ele.Value);
          }
          return $"Employee Deleted {key}";

    }
    [HttpGet(Name="GetALLEmployee")]
    public List<string> GetALLEmployee( ){
        return employee;
    }
    [HttpGet(Name ="Updated Employee")]
    public static void CreateNewOrUpdateExisting<TKey, TValue>(
     IDictionary<TKey, TValue> map, TKey key, TValue value)
{            
    if (map.ContainsKey(key))
    {
        map[key] = value;
    }
    else
    {
        map.Add(key, value);
    }
}// public static void Update(int key,string Value)
    // {
    // var newdictionary = new Dictionary<int,string>();
    // newdictionary[1] = "maneger";
    // newdictionary[3] = "CEO";
    // foreach(var Updates in employee)
    // newdictionary= (Dictionary<int, string>)newdictionary.Where(p => p.Key == 1)////filter data using where
    //  .ToDictionary(p => p.Key, p => p.Value);
    //  if (newdictionary.ContainsKey(key))
    // {
    //        [key] = value;
    
    // }
   
}
