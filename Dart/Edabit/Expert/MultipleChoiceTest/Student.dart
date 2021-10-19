import 'Testpaper.dart';

class Student {
  List<String>? _testsTaken;

  get testsTaken => _testsTaken;

  Student() {
    _testsTaken = ["No tests taken"];
  }

  void TakeTest(Testpaper paper, List<String> answers) {
    var correctCount = 0;
    for (var i = 0; i < answers.length; i++) {
      if (answers[i] == paper.MarkScheme[i]) {
        correctCount++;
      }
    }
    int percentageCorrect =
        ((correctCount / paper.MarkScheme.length) * 100).ceil();
    int percentageToPass = int.parse(paper.PassMark.replaceAll("%", ""));

    String passedOrFailed =
        percentageCorrect < percentageToPass ? "Failed!" : "Passed!";

    String result = "${paper.subject} : $passedOrFailed ($percentageCorrect%)";
    if (_testsTaken![0].contains("No tests taken")) {
      _testsTaken = [result];
    } else {
      _testsTaken!.add(result);
    }
    _testsTaken!.sort();
  }
}
