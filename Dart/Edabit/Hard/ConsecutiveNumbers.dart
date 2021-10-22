//https://edabit.com/challenge/TAZywz6R2hu9tDQWc
void main() {
  var res = consecutiveNumbers([5, 1, 4, 3, 2, 6]);
  print(res);
}

bool consecutiveNumbers(List<int> numbers) {
  numbers.sort();
  for (var i = 0; i < numbers.length - 1; i++) {
    var currentPlusOne = numbers[i] += 1;
    var next = numbers[i + 1];
    if (currentPlusOne != next) return false;
  }
  return true;
}
