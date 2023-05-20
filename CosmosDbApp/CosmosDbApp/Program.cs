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
            CosmosHelper cosmos = new CosmosHelper(connectionString);


            //string databaseName = "appdb";
            //await cosmos.CreateDatabase(databaseName);


            //string containerName = "course";
            //string partitionKey = "/courseid";
            //await cosmos.CreateContainer(databaseName, containerName, partitionKey);


            string databaseName = "appdb";
            string containerName = "course";
            Course course = new Course()
            {
                id = "1000",
                courseid = "AZERTT",
                coursename = "new Test AZ-204",
                rating = 4.5m
            };
            await cosmos.AddItem(databaseName, containerName, course);


            //string databaseName = "appdb";
            //string containerName = "course";
            //List<Course> courses = new List<Course>()
            //{
            //    new Course() { id="1",courseid="Course0001", coursename = "AZ-204 Developing Azure solutions", rating = 4.5m },
            //    new Course() { id="2",courseid="Course0002", coursename = "AZ-303 Architecting Azure solutions", rating = 4.6m },
            //    new Course() { id="3", courseid="Course0003", coursename = "DP-203 Azure Data Engineer", rating = 4.7m },
            //    new Course() { id="4",courseid="Course0004", coursename = "AZ-900 Azure Fundamentals", rating = 4.6m },
            //    new Course() { id="5",courseid="Course0005", coursename = "AZ-104 Azure Administrator", rating = 4.5m }
            //};
            //await cosmos.Bulkinsert(databaseName, containerName, courses);


            //string databaseName = "appdb";
            //string containerName = "course";
            //string query = "SELECT * FROM c WHERE c.courseid = 'Course0002'";
            //List<Course> courses = await cosmos.ReadData<Course>(databaseName, containerName, query);
            //foreach (Course course in courses)
            //{
            //    Console.WriteLine($"Id is {course.id}");
            //    Console.WriteLine($"Course id is {course.courseid}");
            //    Console.WriteLine($"Course name is {course.coursename}");
            //    Console.WriteLine($"Course rating is {course.rating}");
            //}


            //string databaseName = "appdb";
            //string containerName = "course";
            //var newItem = new Course()
            //{
            //    id = "2",
            //    courseid = "Course0002",
            //    coursename = "new AZ-303 Architecting Azure solutions",
            //    rating = 4.8m
            //};
            //await cosmos.UpdateData<Course>(databaseName, containerName, newItem);


            //string databaseName = "appdb";
            //string containerName = "course";
            //var itemToDelete = new Course()
            //{
            //    id = "1000",
            //    courseid = "AZERTT",
            //    coursename = "new AZ-303 Architecting Azure solutions",
            //    rating = 4.8m
            //};
            //await cosmos.DeleteData<Course>(databaseName, containerName, itemToDelete);
        }
    }
}
