using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_PREFINAL_EXAM.Models;
using System.Collections.Generic;

namespace IT_ELECTIVE_2_PREFINAL_EXAM.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<ExamQuestion> ExamQuestions = new List<ExamQuestion>
        {
            new ExamQuestion {
                Number = 1,
                QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?",
                Options = new List<string>{ "A. It makes C# code shorter", "B. It prevents the application from restarting", "C. It allows data to persist after the application stops", "D. It removes the need for MVC" },
                CorrectOption = "C",
                CorrectAnswerText = "It allows data to persist after the application stops",
                Explanation = "In-memory data is volatile and lost when the application stops. A database provides persistent storage.",
                Topic = "Relational Data Modeling"
            },
            new ExamQuestion {
                Number = 2,
                QuestionText = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                Options = new List<string>{ "A. Code-First", "B. Database-First", "C. Model-First", "D. Controller-First" },
                CorrectOption = "B",
                CorrectAnswerText = "Database-First",
                Explanation = "Database-First scaffolding generates C# entity models directly from an existing database schema.",
                Topic = "Relational Data Modeling"
            },
            new ExamQuestion {
                Number = 3,
                QuestionText = "What is the primary purpose of Entity Framework Core?",
                Options = new List<string>{ "A. To create HTML pages automatically", "B. To replace the MVC Controller", "C. To map objects in code to relational database data", "D. To replace the C# compiler" },
                CorrectOption = "C",
                CorrectAnswerText = "To map objects in code to relational database data",
                Explanation = "EF Core acts as an Object-Relational Mapper (ORM) translating C# objects to relational database tables.",
                Topic = "Relational Data Modeling"
            },
            new ExamQuestion {
                Number = 4,
                QuestionText = "Which EF Core component is primarily responsible for communicating with the database?",
                Options = new List<string>{ "A. DbContext", "B. DbSetView", "C. ControllerContext", "D. RazorContext" },
                CorrectOption = "A",
                CorrectAnswerText = "DbContext",
                Explanation = "DbContext coordinates EF Core functionality and manages sessions with the underlying database.",
                Topic = "Relational Data Modeling"
            },
            new ExamQuestion {
                Number = 5,
                QuestionText = "What does the following command primarily do?\ndotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                Options = new List<string>{ "A. Deletes the database", "B. Creates a new MVC project", "C. Generates EF Core models and a DbContext from an existing database", "D. Starts the MVC application" },
                CorrectOption = "C",
                CorrectAnswerText = "Generates EF Core models and a DbContext from an existing database",
                Explanation = "The scaffold command reverse-engineers a database schema into model classes and a DbContext class.",
                Topic = "Relational Data Modeling"
            },
            new ExamQuestion {
                Number = 6,
                QuestionText = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                Options = new List<string>{ "A. Program.cs only", "B. appsettings.json", "C. Index.cshtml", "D. Student.cs" },
                CorrectOption = "B",
                CorrectAnswerText = "appsettings.json",
                Explanation = "appsettings.json is the standard configuration file used to store application settings like connection strings.",
                Topic = "Conceptual Data Architecture"
            },
            new ExamQuestion {
                Number = 7,
                QuestionText = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                Options = new List<string>{ "A. One-to-One", "B. One-to-Many", "C. Many-to-Many", "D. Many-to-One only" },
                CorrectOption = "B",
                CorrectAnswerText = "One-to-Many",
                Explanation = "From Section to Student, it is a One-to-Many relationship (one section has many students).",
                Topic = "Conceptual Data Architecture"
            },
            new ExamQuestion {
                Number = 8,
                QuestionText = "In the following example, what is SectionId?\npublic int SectionId { get; set; }\npublic Section Section { get; set; }",
                Options = new List<string>{ "A. Primary key of Student", "B. Foreign key referencing Section", "C. Navigation property", "D. Database connection string" },
                CorrectOption = "B",
                CorrectAnswerText = "Foreign key referencing Section",
                Explanation = "SectionId holds the key value linking the entity to its parent Section table record.",
                Topic = "Conceptual Data Architecture"
            },
            new ExamQuestion {
                Number = 9,
                QuestionText = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                Options = new List<string>{ "A. It stores the database password", "B. It represents a relationship to another entity", "C. It creates a new database", "D. It validates the student's name" },
                CorrectOption = "B",
                CorrectAnswerText = "It represents a relationship to another entity",
                Explanation = "Navigation properties enable traversal across relationships between entity objects.",
                Topic = "Conceptual Data Architecture"
            },
            new ExamQuestion {
                Number = 10,
                QuestionText = "What does .Include() generally allow EF Core to do?",
                Options = new List<string>{ "A. Delete the Section table", "B. Load related Section data together with Students", "C. Create a new Student", "D. Validate Student input" },
                CorrectOption = "B",
                CorrectAnswerText = "Load related Section data together with Students",
                Explanation = ".Include() specifies related entities to be included in query results (eager loading).",
                Topic = "Conceptual Data Architecture"
            },
            new ExamQuestion {
                Number = 11,
                QuestionText = "Why might a ViewModel be used when displaying Student and Section information?",
                Options = new List<string>{ "A. To replace the database", "B. To combine or shape the data specifically needed by the view", "C. To automatically create database tables", "D. To prevent controllers from using LINQ" },
                CorrectOption = "B",
                CorrectAnswerText = "To combine or shape the data specifically needed by the view",
                Explanation = "ViewModels optimize and shape domain models specifically for presentation in the UI.",
                Topic = "Data Normalization & Integrity"
            },
            new ExamQuestion {
                Number = 12,
                QuestionText = "Consider this query:\nvar students = _context.Students.Include(s => s.Section).ToList();\nWhat is the main benefit of Include(s => s.Section)?",
                Options = new List<string>{ "A. It loads the related Section navigation property", "B. It creates a Section object manually", "C. It removes the foreign key", "D. It prevents the query from accessing the database" },
                CorrectOption = "A",
                CorrectAnswerText = "It loads the related Section navigation property",
                Explanation = "It ensures that the Section entity attached to each Student is fetched in the SQL query.",
                Topic = "Data Normalization & Integrity"
            },
            new ExamQuestion {
                Number = 13,
                QuestionText = "Which type of validation occurs in the browser before a request is sent to the server?",
                Options = new List<string>{ "A. Database-level validation", "B. Client-side validation", "C. Server-side validation", "D. EF Core migration validation" },
                CorrectOption = "B",
                CorrectAnswerText = "Client-side validation",
                Explanation = "Client-side validation executes in the browser using JavaScript before form submission.",
                Topic = "Data Normalization & Integrity"
            },
            new ExamQuestion {
                Number = 14,
                QuestionText = "Why is server-side validation still necessary if client-side validation exists?",
                Options = new List<string>{ "A. Client-side validation can be bypassed", "B. Client-side validation automatically modifies the database", "C. Server-side validation only works with SQLite", "D. Client-side validation cannot display messages" },
                CorrectOption = "A",
                CorrectAnswerText = "Client-side validation can be bypassed",
                Explanation = "Attackers or modified clients can bypass browser validation; server validation ensures data security.",
                Topic = "Data Normalization & Integrity"
            },
            new ExamQuestion {
                Number = 15,
                QuestionText = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                Options = new List<string>{ "A. Student Number should always be nullable", "B. Student Number should be unique", "C. Student Number should always be the same", "D. Student Number should contain only spaces" },
                CorrectOption = "B",
                CorrectAnswerText = "Student Number should be unique",
                Explanation = "Unique constraints ensure no two records share identical identifiers.",
                Topic = "Data Normalization & Integrity"
            },
            new ExamQuestion {
                Number = 16,
                QuestionText = "Which is the best reason for having a database-level unique constraint on StudentNumber?",
                Options = new List<string>{ "A. It protects data integrity even if application-level validation is bypassed", "B. It makes Razor Views render faster", "C. It removes the need for a Controller", "D. It automatically creates a ViewModel" },
                CorrectOption = "A",
                CorrectAnswerText = "It protects data integrity even if application-level validation is bypassed",
                Explanation = "Database constraints serve as the final line of defense for structural data integrity.",
                Topic = "SQL & In-Memory Operations"
            },
            new ExamQuestion {
                Number = 17,
                QuestionText = "What is the purpose of a try...catch block in a controller?",
                Options = new List<string>{ "A. To create navigation properties", "B. To catch and handle exceptions that may occur during execution", "C. To generate database tables", "D. To perform client-side validation" },
                CorrectOption = "B",
                CorrectAnswerText = "To catch and handle exceptions that may occur during execution",
                Explanation = "Try-catch blocks intercept runtime errors to prevent application crashes and handle errors gracefully.",
                Topic = "SQL & In-Memory Operations"
            },
            new ExamQuestion {
                Number = 18,
                QuestionText = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?",
                Options = new List<string>{ "A. UseDatabase()", "B. UseExceptionHandler()", "C. UseValidationHandler()", "D. UseMvcDatabase()" },
                CorrectOption = "B",
                CorrectAnswerText = "UseExceptionHandler()",
                Explanation = "UseExceptionHandler configures global exception handling middleware in the pipeline.",
                Topic = "SQL & In-Memory Operations"
            },
            new ExamQuestion {
                Number = 19,
                QuestionText = "A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?",
                Options = new List<string>{ "A. Display the student's information anyway", "B. Display a Not Found (404) response/page", "C. Delete Student 999", "D. Create Student 999 automatically" },
                CorrectOption = "B",
                CorrectAnswerText = "Display a Not Found (404) response/page",
                Explanation = "HTTP 404 indicates that the server cannot locate the requested resource.",
                Topic = "SQL & In-Memory Operations"
            },
            new ExamQuestion {
                Number = 20,
                QuestionText = "A student already belongs to Section A for a particular subject. The application attempts to assign the same student to Section A again. What is the primary concern?",
                Options = new List<string>{ "A. Data integrity", "B. HTML formatting", "C. CSS inheritance", "D. Razor syntax" },
                CorrectOption = "A",
                CorrectAnswerText = "Data integrity",
                Explanation = "Duplicate assignments violate business rules and compromise relational data integrity.",
                Topic = "SQL & In-Memory Operations"
            }
        };

        public IActionResult Index()
        {
            return View(ExamQuestions);
        }
    }
}