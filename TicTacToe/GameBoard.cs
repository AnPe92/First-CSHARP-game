using System.Reflection.Metadata.Ecma335;

public class GameBoard
{
    private char[,] board = new char[3, 3];

    public GameBoard()
    {
    }

    public void DisplayBoard()
    {
        Console.WriteLine("  {0} | {1}  | {2}  ", GetPosition(0, 0), GetPosition(0, 1), GetPosition(0, 2));
        Console.WriteLine("--- --- ---");
        Console.WriteLine("  {0} | {1}  | {2}  ", GetPosition(1, 0), GetPosition(1, 1), GetPosition(1, 2));
        Console.WriteLine("--- --- ---");
        Console.WriteLine("  {0} | {1}  | {2}  ", GetPosition(2, 0), GetPosition(2, 1), GetPosition(2, 2));
    }

    public void ResetGameBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
    }

    public Boolean UpdateBoard(int row, int column, char mark)
    {
        if (GetPosition(row, column).Equals(' '))
        {
            board[row, column] = mark;
            return true;
        }
        else
        {
            return false;
        }
    }

    public char GetPosition(int row, int column)
    {
        return board[row, column];
    }

    public Boolean CheckWin(char mark)
    {
        //Rows
        for(int i = 0;i < 3;i++)
        {
            if (this.board[i,0].Equals(mark) && this.board[i, 1].Equals(mark) && this.board[i, 2].Equals(mark)) {
                return true;
        }
        }

        //Columns
        for (int i = 0; i < 3; i++)
        {
            if (this.board[0, i].Equals(mark) && this.board[1, i].Equals(mark) && this.board[2, i].Equals(mark))
            {
                return true;
            }
        }
        // Diagonals
        if (board[0, 0] == mark && board[1, 1] == mark && board[2, 2] == mark)
            return true;

        if (board[0, 2] == mark && board[1, 1] == mark && board[2, 0] == mark)
            return true;
    
        //No Win
        return false;
    }
    
}