//https://edabit.com/challenge/aQWAAz6SiApZBA8A8
void main() {
  var result = isIsogram("abcc");
  print(result);
}

bool isIsogram(String text) {
  Map<String, int> map = Map.fromIterable(text.split(""),
      key: (letter) => letter, value: (value) => 0);
  for (var i = 0; i < text.length; i++) {
    map[text[i]] = map[text[i]]! + 1;
  }
  print(map);
  for (var i = 0; i < text.length; i++) {
    if (map[text[i]]! > 1) return false;
  }
  return true;
}
