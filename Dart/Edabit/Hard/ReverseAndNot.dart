//https://edabit.com/challenge/YGhgctqPsKQxQQCFS
void main() {
  var result = reverseAndNot(123);
  print(result);
}

String reverseAndNot(int numbers) =>
    numbers.toString().split('').reversed.join() + numbers.toString();
