//https://edabit.com/challenge/JYEufqRvkusjr5R58
void main() {
  var result1 = findTheBomb("There is a bomb.");
  var result2 = findTheBomb("This goes boom!!!");
  print(result1);
  print(result2);
}

findTheBomb(String string) => string.toLowerCase().contains("bomb")
    ? "Duck!!!"
    : "There is no bomb, relax.";
