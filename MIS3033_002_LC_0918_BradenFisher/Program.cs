// MIS3033 002
// September 18, 2023
// Braden Fisher 113492081

using a;
using System.Text.Json;

Console.WriteLine("Create grades database");

StudentGradeDB db; // complex
db = new StudentGradeDB(); // db connection

var opt = new JsonSerializerOptions();
opt.WriteIndented = true;

string filePath = "data.json";
string jsonStr;

bool CheckGrade(StudentGrade x)
{
    if (x.Grade>= 80 && x.Grade<= 90)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// lamda expression
{
    // var r = db.StuGradeTable;// collection, table
    // var r = db.StuGradeTable.Where(x => x.Age == 20);// collection, table
    // var r = db.StuGradeTable.Where(CheckGrade);// collection, table


    // where() in list, collection, table
    // where() work on collection, list, table
    // var r = db.StuGradeTable.Where(s => s.Grade >= 80 && s.Grade <= 90);

    // var r = db.StuGradeTable.Where(s => s.Grade >= 80 && s.Grade <= 90 && s.Age == 20);
    //var r = db.StuGradeTable.Where(s => s.Grade >= 80 && s.Grade <= 90).Where(s => s.Age == 18);

    //FirstOrDefault() work on collections
    // var r = db.StuGradeTable.Where(x => x.Grade>90).Where(x => x.Grade < 95);
    //StudentGrade r = db.StuGradeTable.Where(x => x.Grade > 90).FirstOrDefault();

    var r = db.StuGradeTable.FirstOrDefault();

    r.Age = 100;

    db.StuGradeTable.Remove(r);

    db.SaveChanges();

    jsonStr = JsonSerializer.Serialize(r,opt);
    File.WriteAllText(filePath,jsonStr);
}

//complex
{
    StudentGrade s1;
    StudentGrade s2;

    s1 = new StudentGrade(); // student 1
    s2 = new StudentGrade(); // student 2

    s1 = s2;
}





//StudentGradeDB db;
//db = new StudentGradeDB();// create databse connection

//double r1 = db.StuGradeTable.Average(s => s.Grade);
//Console.WriteLine(r1);

//double r2 = db.StuGradeTable.Max(s => s.Grade);
//Console.WriteLine(r2);

//double r3 = db.StuGradeTable.Min(s => s.Grade);
//Console.WriteLine(r3);
