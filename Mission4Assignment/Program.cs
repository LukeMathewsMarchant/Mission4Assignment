// See https://aka.ms/new-console-template for more information

// Welcome the user to the game
   // • Create a game board array to store the players’ choices
   // • Ask each player in turn for their choice and update the game board array
    //• Print the board by calling the method in the supporting class
//PrintBoard
   // • Check for a winner by calling the method in the supporting class, and notify the players
//CheckWinner
// when a win has occurred and which player won the game

using Mission4Assignment;

//Welcome to the game
Console.WriteLine("Welcome to Tik-Tac-Toe!");
string [] board = ["0", "1", "2", "3", "4", "5" , "6" ,"7" ,"8"];
string[] invalid = ["X", "O"];


Supporting supporting = new Supporting();

//Print Board
supporting.PrintBoard(board);

//Get inputs in a loop until someone wins
do
{
    int player1;
    int player2;
    bool isValid = false;
    
    //get guess from Player 1
    do
    {
        Console.WriteLine("Player 1, please make your choice");
        string input = Console.ReadLine();
        //Validate inputs
        if (board.Contains(input) && !invalid.Contains(input))
        {
            player1 = int.Parse(input);
            board[player1] = "X";
            isValid = true;
        }
        else
        {
            Console.WriteLine("Please enter an available number on the board");
        }

    } while (isValid == false);
    //Reset check variable
    isValid = false;
    supporting.PrintBoard(board);

    //Check if Player 1 won
    if (supporting.CheckWinner(board) != "")
    {
        Console.WriteLine("Player 1 Wins!");
    }
    // If they didn't win, then get Player 2s inputs. 
    else
    {
        do
        {
            Console.WriteLine("Player 2, please make your choice");
            string input = Console.ReadLine();
            //Validate inputs
            if (board.Contains(input) && !invalid.Contains(input))
            {
                player2 = int.Parse(input);
                board[player2] = "O";
                isValid = true;
            }
            else
            {
                Console.WriteLine("Please enter an available number on the board");
            }
            
            //Check if Player 2 won
            if (supporting.CheckWinner(board) != "")
            {
                supporting.PrintBoard(board);
                
                Console.WriteLine("Player 2 Wins!");
            }

        } while (isValid == false);
    }
    
    //Check if someone won and if so leave the loop
} while (supporting.CheckWinner(board) == "");

