//https://edabit.com/challenge/GLbuMfTtDWwDv2F73
void main() {
  var result = HowMuchIsTrue([]);
  print(result);
}

HowMuchIsTrue(List<bool> list) {
  return list.where((boolean) => boolean == true).length;
}
