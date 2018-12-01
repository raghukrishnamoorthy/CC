<Query Kind="Program" />

// Urlify the string
// Input: "Mr John Smith", 13
// Output: "Mr%20John%20Smith%20"

void Main()
{
	const string input = "Mr John Smith";
	var charArray = new Char[input.Length + 4];
	
	for(int i = 0; i < input.Length; i++) {
		charArray[i] = input[i];
	}
	
	ReplaceSpaces(charArray, 13);
	
}

int Count_the_number_of_spaces(char[] input)
        {
            var spaceCount = 0;
            foreach (var character in input)
            {
                if (character == ' ')
                    spaceCount++;
            }
            return spaceCount;
        }


void ReplaceSpaces(char[] input, int length) {
	var fillChars = new [] {'0', '2', '%'};
	var entireCharArrayLength = 17;
	entireCharArrayLength = entireCharArrayLength - 1;
	Console.WriteLine(entireCharArrayLength);
	void SetCharsAndMoveIndex(params char[] chars) {
		foreach(var c in chars) {
			input[entireCharArrayLength--] = c;
		}
	}
	
	for (int indexSource = length - 1; indexSource >= 0; indexSource--) {
		if (input[indexSource] == ' ') {
			SetCharsAndMoveIndex(fillChars);
		}
		else {
			SetCharsAndMoveIndex(input[indexSource]);
		}
		
	}
	
	Console.WriteLine(new String(input));
	
}