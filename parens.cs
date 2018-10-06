using System;
using System.Collections.Generic;

namespace CC 
{
    class Parens {

        public static HashSet<string> generateParens(int remaining) {
            HashSet<string> set = new HashSet<string>();
            if(remaining == 0) {
                set.Add("");
            }
            else {
                HashSet<string> prev = generateParens(remaining -1);
                foreach (string str in prev)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == '(') {
                            string s = insertInside(str, i);
                            set.Add(s);
                        }
                    }
                    set.Add("()" + str);
                }
            }
            return set;
        }

        static string insertInside(string str, int leftIndex) {
            string left = str.Substring(0, leftIndex + 1);
            string right = str.Substring(leftIndex + 1);
            return left + "()" + right;
        }
    }

    class ParensOptimized {

        static void addParen(List<string> list, int leftRem, int rightRem, char[] str, int count) {
            
            if(leftRem < 0 || rightRem < leftRem) return;

            if(leftRem == 0 && rightRem == 0) {
                string s = new string(str);
                list.Add(s);
            }
            else {
                if(leftRem > 0) {
                    str[count] = '(';
                    Console.WriteLine($"addParen(list, {leftRem - 1}, {rightRem}, {new String(str)}, {count + 1}");
                    addParen(list, leftRem - 1, rightRem, str, count + 1);
                }
                if(rightRem > leftRem) {
                    str[count] = ')';
                    Console.WriteLine($"addParen(list, {leftRem - 1}, {rightRem}, {new String(str)}, {count + 1}");
                    addParen(list, leftRem, rightRem - 1, str, count + 1);
                }
            }
        }
        public static List<string> generateParens(int count) {
            char[] str = new char[count * 2];
            List<string> list = new List<string>();
            addParen(list, count, count, str, 0);
            return list;
        }
    }
}