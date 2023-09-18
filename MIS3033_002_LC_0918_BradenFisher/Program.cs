// MIS3033 002
// September 18, 2023
// Braden Fisher 113492081

using a;

Console.WriteLine("Create grades database");

StudentGradeDB db;
db = new StudentGradeDB();// create databse connection

double r1 = db.StuGradeTable.Average(s => s.Grade);
Console.WriteLine(r1);

double r2 = db.StuGradeTable.Max(s => s.Grade);
Console.WriteLine(r2);

double r3 = db.StuGradeTable.Min(s => s.Grade);
Console.WriteLine(r3);
