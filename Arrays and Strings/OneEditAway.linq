<Query Kind="Program" />

void Main()
{
	String a = "cats";
	String b = "cab";
	
	bool IsOneEdit = OneEditAway(a, b);
	Console.WriteLine(IsOneEdit);
	
}

bool OneEditAway(string first, string second)
{
	if(first.Length == second.Length) {
		return OneEditReplace(first, second);
	}
	else if (first.Length + 1 == second.Length) {
		return OneEditInsert(first, second);
	}
	else if (first.Length == second.Length + 1) {
		return OneEditInsert(second, first);
	}
	return false;
}

bool OneEditReplace(string first, string second) {
	
	bool differenceFound = false;
	for (int i = 0; i < first.Length; i++) {
		if (first[i] != second[i]) {
			if (differenceFound) {
				return false;
			}
			differenceFound = true;
		}
	}
	
	return true;
}

bool OneEditInsert(string s1, string s2) {
	
	int index1 = 0;
	int index2 = 0;
	
	while(index2 < s2.Length && index1 < s1.Length) {
		if( s1[index1] != s2[index2]) {
			
			if(index1 != index2) {
				return false;
			}
			
			index2++;
		}
		else {
			index1++;
			index2++;
		}
	}
	
	return true;
}