# KnightTour
A knight's tour is a sequence of moves of a knight on a chessboard such that the knight visits every square only once. If the knight ends on a square that is one knight's move from the beginning square (so that it could tour the board again immediately, following the same path), the tour is closed, and otherwise it is open.
The earliest known reference to the knight's tour problem dates back to the 9th century AD. In Rudraṭa's Kavyalankara , a Sanskrit work on Poetics, the pattern of a knight's tour on a half-board has been presented as an elaborate poetic figure ("citra-alaṅkāra") called the "turagapadabandha" or 'arrangement in the steps of a horse.' 
One of the first mathematicians to investigate the knight's tour was Leonhard Euler. The first procedure for completing the Knight's Tour was Warnsdorf's rule, first described in 1823 by H. C. von Warnsdorf.
	The assignment develops a GUI (based on Windows Forms) and two approaches to choose the movement of the knight on the board. It has a simple or non-intelligent approach which chooses the next movement based solely on random approach. It also has an intelligent approach which uses algorithm to prioritize certain positions on the board.

# Usage

Steps to use the program:
	1. Run the file.
	2. Select the number of times you want to run the program using numeric up and down
	(the number of times is between 1 to 100, in order to keep 
	 the runtime time-limited.)
	3. Select the method you want to use, there are two radio button options i.e. 'Intelligent' and 'Non-intelligent'.
	   Non-intelligent method selects the position of the knight on random basis. It is selected by default.
	   Intelligent method prioritize the positions on the board and selects the position of the knight on that basis.
	4. If you want to specify the initial position, then select the 'Yes' option and specify initial the row and column for the knight using 
	   numeric up and downs. (The value for row and col is between 1 and 8 (included).
		-When you click on the radio button to set the position of the knight, the invisible numeric up and down
	 	 for the position of rows. Before you click the 'Yes' option, the numeric up and down will remain hidden.
	  If you don't want to specify the positon, then select the 'No' option and the program will randomize the initial position of the knight.
	  The random positioning is selected by default.
	5. Hit the 'Go!' button to launch the program.
	6. The steps taken by the knight would be displayed in the rich text box (1 is the initial position and 0 means that knight never touched that square)
	   and the output is sent to 'simple.txt' file if non-intelligent method was used or 'intelligent.txt' if intelligent method was used in the project folder.
