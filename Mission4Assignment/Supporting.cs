namespace Mission4Assignment;


using System;

public class Supporting
{
    /// <summary>
    /// Prints the current Tic-Tac-Toe board to the console.
    /// </summary>
    /// <param name="board">A string array of length 9 representing the game board.</param>
    public void PrintBoard(string[] board)
    {
        Console.WriteLine();
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]}");
        Console.WriteLine();
    }

    /// <summary>
    /// Checks the board for a winning condition.
    /// </summary>
    /// <param name="board">A string array of length 9 representing the game board.</param>
    /// <returns>
    /// "X" if player X has won,
    /// "O" if player O has won,
    /// or an empty string if there is no winner.
    /// </returns>
    public string CheckWinner(string[] board)
    {
        int[,] winningCombos =
        {
            {0, 1, 2}, // rows
            {3, 4, 5},
            {6, 7, 8},
            {0, 3, 6}, // columns
            {1, 4, 7},
            {2, 5, 8},
            {0, 4, 8}, // diagonals
            {2, 4, 6}
        };

        for (int i = 0; i < winningCombos.GetLength(0); i++)
        {
            string first = board[winningCombos[i, 0]];
            string second = board[winningCombos[i, 1]];
            string third = board[winningCombos[i, 2]];

            // Ensure the spot is taken by a player, not a number
            if (first == second && second == third &&
                (first == "X" || first == "O"))
            {
                return first;
            }
        }

        // No winner found
        return "";
    }
}