using System.ComponentModel.Design;
using myNameSpace;


Alumno[] alumnos = [new("Sophia", 90, 86, 87, 98, 100),
                    new("Andrew", 92, 89, 81, 96, 90), 
                    new("Emma", 90, 85, 87, 98, 68), 
                    new("Logan", 90, 95, 87, 88, 96),
                    new("Luismi", 99,94,99,100,100)];

Console.WriteLine("Student\tGrade");
foreach(Alumno alumno in alumnos){
    Console.WriteLine(alumno.GetGradeString());
}//End foreach


namespace myNameSpace{
    class Alumno{

        string nombre;
        int[] grades = new int[5];

        int GetGradesSum(){
            return grades.Sum();
        }//End GetGradesSum

        double GetGradesAvg(){
            return ((double) GetGradesSum())/grades.Length;
        }//End GetGradesAvg

        string GetGradeLetter(){
            return GetGradeLetter(GetGradesAvg());
        }//End GetGradeLetter

        public static string GetGradeLetter(double _avgGrade){
            string letra = _avgGrade switch{
                >= 97 => "A+",
                >= 93 and < 97 => "A",
                >= 90 and < 93 => "A-",
                >= 87 and < 90 => "B+",
                >= 83 and < 87 => "B",
                >= 80 and < 83 => "B-",
                >= 77 and < 80 => "C+",
                >= 73 and < 77 => "C",
                >= 70 and < 73 => "C-",
                >= 67 and < 70 => "D+",
                >= 63 and < 67 => "C",
                >= 60 and < 63 => "D-",
                _ => "F"
            };
            return letra;
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