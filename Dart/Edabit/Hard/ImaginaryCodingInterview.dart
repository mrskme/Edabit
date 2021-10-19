//https://edabit.com/challenge/dZeNE4BJhyNgA99Fq
void main() {
  var candidate1 = [5, 5, 10, 10, 15, 15, 20, 20];
  var candidate2 = [2, 3, 8, 6, 5, 12, 10, 18];
  var candidate3 = [5, 5, 10, 10, 25, 15, 20, 20];
  var candidate4 = [5, 5, 10, 10, 15, 15, 20];
  var candidate5 = [5, 5, 10, 10, 15, 15, 20, 20];
  List<List<int>> candidateScores = [
    candidate1,
    candidate2,
    candidate3,
    candidate4,
    candidate5,
  ];
  List<int> candidatesTotalTimes = [
    120,
    64,
    120,
    120,
    130,
  ];
  for (var i = 0; i < candidateScores.length; i++) {
    var result = interview(candidateScores[i], candidatesTotalTimes[i]);
    print(result);
  }
}

String interview(List<int> candidateScores, int totalTime) {
  var maximumTimes = [5, 5, 10, 10, 15, 15, 20, 20];
  if (candidateScores.length != maximumTimes.length || totalTime > 120)
    return "disqualified";
  for (var i = 0; i < candidateScores.length; i++) {
    if (candidateScores[i] > maximumTimes[i]) return "disqualified";
  }
  return "qualified";
}
