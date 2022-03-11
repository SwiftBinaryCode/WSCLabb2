using Microsoft.AspNetCore.Mvc;
using WSCLabb2.DAL;
using WSCLabb2.DAL.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");


//List of all the courses
app.MapGet("/courses", ([FromServices] CourseStorage storage) =>
{

});

//Get a course with a specific id
app.MapGet("/courses/{id}", ([FromServices] CourseStorage storage, int id) =>
{

});

//Get a list of all users registered on the course with a specific id
app.MapGet("/courses/{id}/students", ([FromServices] CourseStorage storage, int id) =>
{

});

//List of all the users
app.MapGet("/students", ([FromServices] StudentStorage storage) =>
{
   
});

//Find a user by their email
app.MapGet("/students/email", ([FromServices] StudentStorage storage, int id) =>
{
    
});

//List of all registered courses
app.MapGet("/students/{id}/courses", ([FromServices] StudentStorage storage, int id) =>
{

});


//List of all registered courses
app.MapGet("/students/{id}/courses", ([FromServices] StudentStorage storage, int id) =>
{

});

//Store a new course
app.MapPost("/courses", ([FromServices] CourseStorage storage, Course course) =>
{
    
});

//Register a user on a course with a specific id
app.MapPost("/courses/{id}", ([FromServices] CourseStorage storage, Student student) =>
{

});

//Edit a course with a specific id
app.MapPut("/courses/{id}", ([FromServices] CourseStorage storage, int id, Course course) =>
{
  
});

//Edit a Student with a specific id
app.MapPut("/students/{id}", ([FromServices] StudentStorage storage, int id, Student student) =>
{
   
});

//Delete a student with a specific id
app.MapDelete("/student/{id}", ([FromServices] StudentStorage storage, int id) =>
{
    
});

//Delete a student with a specific id
app.MapDelete("/course/{id}", ([FromServices] CourseStorage storage, int id) =>
{

});
app.Run();
