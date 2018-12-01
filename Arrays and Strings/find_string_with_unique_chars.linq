<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Linq.dll</Reference>
</Query>

bool CheckUniqueChars(string str)
{
	// Find if a string has all unique characters
	
	// Use Ascii based arrays?
	
	bool[] char_set = new bool[128];
	
	for(int i = 0; i < str.Length; i++ ) {
		int val = str[i];
		
		if(char_set[val]) {
			return false;
		}
		else {
			char_set[val] = true;
		}
		
	}
	
	return true;
}


void Main() {
	string s = "Waterm";
	bool unique = CheckUniqueChars(s);
	
	if(unique) {
		Console.WriteLine("Unique characters");
	}
	else {
		Console.WriteLine("Unique characters not found");
	}
	
}