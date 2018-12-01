<Query Kind="Program" />

// Check if a string is permutation of the other

void Main()
{
	string a = "dama";
	string b = "adam";
	Console.WriteLine(IsPermutation2(a, b));
	
}

// Solution 1: Sort the string array and check if characters are same
// at each index
bool IsPermutation(string original, string valueToTest) {
	
	if(original.Length != valueToTest.Length) {
		return false;
	}
	
    var originalArray = original.ToCharArray();
	Array.Sort(originalArray);
	
	var valueToTestArray = valueToTest.ToCharArray();
	Array.Sort(valueToTestArray);
	
	return new String(originalArray).Equals(new String(valueToTestArray));
	
}

// Solution 2: Check if they have the same counts of characters
bool IsPermutation2(string original, string valueToTest) {
	
	if (original.Length != valueToTest.Length) {
		return false;
	}
	
	var letterCount = new Dictionary<char, int>();
	
	foreach(var letter in original) {
		if (letterCount.ContainsKey(letter)) {
			letterCount[letter]++;
		}
		else {
			letterCount[letter] = 1;
		}
	}
	
	foreach(var letter in valueToTest) {
		if (letterCount.ContainsKey(letter)){
			letterCount[letter]--;
			if (letterCount[letter] < 0) {
				return false;
			}
		}
		else {
		    return false;
		}
	}
	
	return true;
}