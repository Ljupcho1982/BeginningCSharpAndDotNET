string[] MySkills = {
                "C#.net",
                "Asp.net",
                "MVC",
                "Linq",
                "EntityFramework",
                "Swagger",
                "Web-Api",
                "OrcharCMS",
                "Jquery",
                "Sqlserver",
                "Docusign"
            };
var commaSeperatedString = MySkills.Aggregate((s1, s2) => s1 + ", " + s2);
Console.WriteLine("Aggregate : " + commaSeperatedString);
