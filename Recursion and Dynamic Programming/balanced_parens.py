def generateParens(mainList, parenString, leftRem, rightRem, count):
    
    if(leftRem < 0 or rightRem < leftRem):
        return
    
    if(leftRem == 0 and rightRem == 0):
        balancedParens = ''.join(parenString)
        mainList.append(balancedParens)
    else:
        if leftRem > 0:
            print(count)
            parenString[count] = '('
            generateParens(mainList, parenString, leftRem - 1, rightRem, count + 1)

        if rightRem > leftRem:
            parenString[count] = ')'
            generateParens(mainList, parenString, leftRem, rightRem - 1, count + 1)





number_of_parens = 5
parenString = list(' ' * number_of_parens * 2)
print(len(parenString))
mainList = []
generateParens(mainList, parenString, number_of_parens, number_of_parens, 0)
print(mainList)





