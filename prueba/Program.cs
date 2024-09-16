using myNameSpace;

Alumno sophia = new("Sophia", 90, 86, 87, 98, 100);
Alumno andrew = new("Andrew", 92, 89, 81, 96, 90);
Alumno emma = new("Emma", 90, 85, 87, 98, 68);
Alumno logan = new("Logan", 90, 95, 87, 88, 96);

Console.WriteLine("Student\tGrade");
Console.WriteLine(sophia.GetGradeString());
Console.WriteLine(andrew.GetGradeString());
Console.WriteLine(emma.GetGradeString());
Console.WriteLine(logan.GetGradeString());

namespace myNameSpace{
    class Alumno{

        string nombre;
        int[] grades = new int[5];

        int GetGradesSum(){
            return grades.Sum();
        }//End GetGradesSum

        decimal GetGradesAvg(){
            return ((decimal) GetGradesSum())/grades.Length;
        }//End GetGradesAvg

        string GetGradeLetter(){
            return GetGradeLetter(GetGradesAvg());
        }//End GetGradeLetter

        public static string GetGradeLetter(decimal _avgGrade){
            return _avgGrade switch{
                >= 97 => "A+",
                >= 93 and <= 96 => "A",
                >= 90 and <= 92 => "A-",
                >= 87 and <= 89 => "B+",
                >= 83 and <= 86 => "B",
                >= 80 and <= 82 => "B-",
                >= 77 and <= 79 => "C+",
                >= 73 and <= 76 => "C",
                >= 70 and <= 72 => "C-",
                >= 67 and <= 69 => "D+",
                >= 63 and <= 66 => "C",
                >= 60 and <= 62 => "D-",
                _ => "F"
            };
        }//End GetGradeLetter

        public string GetGradeString(){
            return $"{nombre}\t{GetGradesAvg()}\t{GetGradeLetter()}";
        }//End GradeString

        public Alumno(string _nombre, int _g0, int _g1, int _g2, int _g3, int _g4){
            nombre = _nombre;
            grades[0] = _g0;
            grades[1] = _g1;
            grades[2] = _g2;
            grades[3] = _g3;
            grades[4] = _g4;
        }//End constructor

    }//End Alumno
}//End myNameSpace