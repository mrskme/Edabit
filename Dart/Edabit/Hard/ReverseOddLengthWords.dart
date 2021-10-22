void main() {
  var res =
      ReverseOddLengthWords("Make sure uoy only esrever sdrow of ddo length");

  print(res);
}

String ReverseOddLengthWords(String string) {
  var words = string.split(" ");
  var reversedString = "";
  words.forEach((word) {
    if (word.length % 2 == 1) {
      var reversedWord = "";
      for (var i = word.length - 1; i >= 0; i--) {
        reversedWord += word[i];
      }
      if (words != words.last) reversedString += reversedWord + " ";
    } else
      print(word);
  });
  return "";
}
