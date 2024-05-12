using Extensions;

string fox = "The quick brown fox jumps over the lazy dog";

int countO = fox.CountOccuranciesOfChar('o');
int countA = fox.CountOccuranciesOfChar('a');

Console.WriteLine($"O: {countO}, A: {countA}"); // O: 4, A: 1
