//https://edabit.com/challenge/thXMEAWNWyk9cCZcM
import 'Student.dart';
import 'Testpaper.dart';

void main() {
  var paper1 = Testpaper(
    "Maths",
    ["1A", "2C", "3D", "4A", "5A"],
    "60%",
  );
  var paper2 = Testpaper(
    "Chemistry",
    ["1C", "2C", "3D", "4A"],
    "75%",
  );
  var paper3 = Testpaper(
    "Computing",
    ["1D", "2C", "3C", "4B", "5D", "6C", "7A"],
    "75%",
  );

  var student1 = Student();
  var student2 = Student();

  print(student1.testsTaken); // ➞ { "No tests taken" }
  student1.TakeTest(paper1, ["1A", "2D", "3D", "4A", "5A"]);
  print(student1.testsTaken); //➞ { "Maths: Passed! (80%)" }

  student2.TakeTest(paper1, ["1A", "2C", "3A", "5A", "4G"]);
  student2.TakeTest(paper2, ["1C", "2D", "3A", "4C"]);
  student2.TakeTest(paper3, ["1A", "2C", "3A", "4C", "5D", "6C", "7B"]);

  print(student2.testsTaken);
}
