# Ideagen_Calculator
Candidate: Iman Zarifah Zahurin

Time taken to complete the test: 07 hrs 30 mins

Solution:
1.	User key-in the value in a WinForm.
2.	Receive input in string type, then split the whitespace and stored in a list.
3.	Use LINQ to find if there is any values inside bracket that need to be performed first.
4.	Find first bracket (“(“) and store values after the bracket (until close bracket (“)”)) in a new list.
5.	Solved all the operations inside the bracket (with first priority of multiply and divide, then proceed with add or subtract).
6.	Replace the value in the bracket with the amount obtained in Step 4.
7.	Obtain the value.

Exceptions included in the code:
1.	Number divided by zero will display error message.

Solved:
1.	Calculate the inputs without bracket(s), by solving with first priority of multiply and divide, then proceed with add or subtract.
2.	Calculate the inputs with bracket, by solving the values inside the bracket following the priority mentioned in Solved (1).
3.	Calculate the inputs with nested brackets.

Unsolve:
1.	All numbers, operators and brackets must separated by spaces.
2.	Calculate inputs with multiple brackets (e.g. (5+3)/(5*10))
