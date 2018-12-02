<Query Kind="Program" />

// Generate combination of Balanced parentheses


void Main()
{
	var list = generateParens(2);
	Console.WriteLine(list);
}

// Define other methods and classes here
List<string> generateParens(int count) {
	char[] str = new char[count * 2];
	List<string> list = new List<string>();
	AddParen(list, count, count, str, 0);
	return list;
}

void AddParen(List<string> list, int leftRem, int rightRem, char[] str, int count) {
	
	
	if(leftRem < 0 || rightRem < leftRem) {
		return;
	}

	if(leftRem == 0 && rightRem == 0) {
		String s = new String(str);
		list.Add(s);
	}
	else {
		if(leftRem > 0) {
			str[count] = '(';
			AddParen(list, leftRem - 1, rightRem, str, count + 1);
		}
		
		if(rightRem > leftRem) {
			str[count] = ')';
			AddParen(list, leftRem, rightRem - 1, str, count + 1);
		}
	
	}
	
}