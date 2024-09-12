using myNameSpace;

Alumno sophia = new("Sophia", 93, 87, 98, 95, 100);
Alumno nicolas = new("Nicolas", 80, 83, 82, 88, 85);
Alumno zahirah = new("Zahirah", 84, 96, 73, 85, 79);
Alumno jeong = new("Jeong", 90, 92, 98, 100, 97);

Console.WriteLine("Student\tGrade");
Console.WriteLine(sophia.GetGradeString());
Console.WriteLine(nicolas.GetGradeString());
Console.WriteLine(zahirah.GetGradeString());
Console.WriteLine(jeong.GetGradeString());

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
            return GetGradesAvg() switch{
                >= 97 => "A+",
                >= 93 and <= 96 => "A",
                >= 90 and <= 92 => "A-",
                >= 87 and <= 89 => "B+",
                >= 83 and <= 86 => "B",
                _ => "C"
            };
        }//End GetGradeLetter

        public string GetGradeString(){
            return $"{this.nombre}\t{this.GetGradesAvg()}\t{this.GetGradeLetter()}";
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
