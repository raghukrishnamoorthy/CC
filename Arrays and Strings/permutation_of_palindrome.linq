<Query Kind="Program" />

// Check if a string is a permutation of a palindrome
// For e.g 'atc otca is a permutation because 'taco cat' is a palindrome made out of it.


void Main()
{
	string inputString = "madama";
	var resultDict = BuildDictionary(inputString);
	bool result = CheckIfPalindrome(resultDict);
	Console.WriteLine(result.ToString().ToUpper());
}

bool CheckIfPalindrome(Dictionary<char, int> inputDict) {
	bool OddFound = false;
	foreach(var item in inputDict) {
		if (item.Value %2 != 0) {
			if (OddFound) {
				return false;
			}
			OddFound = true;
		}
	}
	return true;
}

Dictionary<char, int> BuildDictionary(string inputString) {
	
	Dictionary<char, int> newDict = new Dictionary<char, int>();
	
	foreach(char c in inputString) {
		if(newDict.ContainsKey(c)) {
			newDict[c]++;
		}
		else {
			newDict[c] = 1;
		}
	}
	
	return newDict;
	
}