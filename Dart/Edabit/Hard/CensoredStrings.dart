//https://edabit.com/challenge/wunaXvZw3WctYioeC
void main() {
  var string = "Wh*r* d*d my v*w*ls g*?";
  var vowels = "eeioeo";
  var result = insertVowels("*PP*RC*S*", "UEAE");
  print(result);
}

insertVowels(String string, String vowels) {
  var result = "";
  var vowelIndex = 0;
  for (var stringIndex = 0; stringIndex < string.length; stringIndex++) {
    var currentLetter = string[stringIndex];
    if (currentLetter == "*") {
      result += currentLetter.replaceAll("*", vowels[vowelIndex]);
      vowelIndex++;
    } else
      result += currentLetter;
  }
  return result;
}
