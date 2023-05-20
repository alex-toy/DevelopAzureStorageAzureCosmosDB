using CosmosDbApp.Models;
using Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CosmosDbApp
{
    class Program
    {
        public static Course MapCourse(Course oldCourse)
        {
            return oldCourse;
        }

        static async Task Main(string[] args)
        {
            string connectionString = "AccountEndpoint=https://alexeiaccount.documents.azure.com:443/;AccountKey=kzM4Se9xmMk6OomcHp4mOeI0bJ95K9cbGQvxsIYfJGmZB6HmrkcmyG6kBOyaVlvFyfQl8rcC7PB3ACDbR4XJTg==;";
            CosmosHelper cosmos = new CosmosHelper(connectionString, false);


            string databaseName = "appdb";
            //await cosmos.CreateDatabase(databaseName);


            string containerName = "course";
            //string partitionKey = "/courseid";
            //await cosmos.CreateContainer(databaseName, containerName, partitionKey);


            //Course course = new Course()
            //{
            //    id = "1000",
            //    courseid = "AZERTT",
            //    coursename = "new Test AZ-204",
            //    rating = 4.5m
            //};
            //await cosmos.AddItem(databaseName, containerName, course);


            //List<Course> courses = new List<Course>()
            //{
            //    new Course() { id="1",courseid="Course0001", coursename = "AZ-204 Developing Azure solutions", rating = 4.5m },
            //    new Course() { id="2",courseid="Course0002", coursename = "AZ-303 Architecting Azure solutions", rating = 4.6m },
            //    new Course() { id="3", courseid="Course0003", coursename = "DP-203 Azure Data Engineer", rating = 4.7m },
            //    new Course() { id="4",courseid="Course0004", coursename = "AZ-900 Azure Fundamentals", rating = 4.6m },
            //    new Course() { id="5",courseid="Course0005", coursename = "AZ-104 Azure Administrator", rating = 4.5m }
            //};
            //await cosmos.Bulkinsert(databaseName, containerName, courses);


            //string query = "SELECT * FROM c WHERE c.courseid = 'Course0002'";
            //List<Course> courses = await cosmos.ReadData<Course>(databaseName, containerName, query);
            //foreach (Course course in courses)
            //{
            //    Console.WriteLine($"Id is {course.id}");
            //    Console.WriteLine($"Course id is {course.courseid}");
            //    Console.WriteLine($"Course name is {course.coursename}");
            //    Console.WriteLine($"Course rating is {course.rating}");
            //}


            //var newItem = new Course()
            //{
            //    id = "2",
            //    courseid = "Course0002",
            //    coursename = "new AZ-303 Architecting Azure solutions",
            //    rating = 4.8m
            //};
            //await cosmos.UpdateData<Course>(databaseName, containerName, newItem);


            //var item1 = new Course() { id = "1", courseid = "Course0001" };
            //await cosmos.DeleteData<Course>(databaseName, containerName, item1);
            //var item2 = new Course() { id = "2", courseid = "Course0002" };
            //await cosmos.DeleteData<Course>(databaseName, containerName, item2);
            //var item3 = new Course() { id = "3", courseid = "Course0003" };
            //await cosmos.DeleteData<Course>(databaseName, containerName, item3);
            //var item4 = new Course() { id = "4", courseid = "Course0004" };
            //await cosmos.DeleteData<Course>(databaseName, containerName, item4);
            //var item5 = new Course() { id = "5", courseid = "Course0005" };
            //await cosmos.DeleteData<Course>(databaseName, containerName, item5);


            //string procedureName = "Additem";
            //dynamic[] courses = new dynamic[]
            //{
            //    new {id="5", courseid="Course0007", coursename="AZ-500 Azure Security", rating=4.4m}
            //};
            //string result = await cosmos.ExecuteStoredProcedure(databaseName, containerName, procedureName, courses);
            //Console.WriteLine(result);


            Course course = new Course()
            {
                id = "1000",
                courseid = "AZERTT",
                coursename = "new Test AZ-204",
                rating = 4.5m
            };
            await cosmos.AddItemWithTimestamp(databaseName, containerName, course);
        }
    }
}
