## TESTS

1. Create an instance of NumberWords that would take a int user input
2. Given a number between (0-19), the method will return the corresponding word (via our array)
3. Given a number between (20 - 99), The method will return the corresponding word (via our dictionary AND array for numbers not ending in 0)
4. The method will return the corresponding words for three digit numbers
5. The method will return the corresponding words for four digit numbers


array 0-19
{"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}

dictionary tens place 20-90
{2, "Twenty"}, {3, "Thirty"}, {4, "Forty"}, {5, "Fifty"}, {6, "Sixty"}, {7, "Sevety"}, {8, "Eighty"}, {9, "Ninety"}

append + Hundred for hundreds place numbers


///////// 
### dictionary 
1 - 9 reg number words
10, 11, 12, 13 - unique words (ten, eleven, twelve, thirteen)
15 - 19 - number + "teen"
20 - twenty, 21 - 29 twenty + number
thirty, forty, fifty
60 - six + ty
70 - seven + ty
80 - eighty
90 - nine + ty
etc..
three digits
first part is always the first number + hundred - one hundred
----> 1,000,000,000,000