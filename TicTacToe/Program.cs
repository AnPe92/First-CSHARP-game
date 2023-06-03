namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean running = true;
            Console.WriteLine("Lets play tic tac toe!");

            Player player1 = new Player('X');
            Player player2 = new Player('O');

            Boolean player1Turn = true;

            GameBoard board = new GameBoard();

            board.ResetGameBoard();
            while (running)
            {
                board.DisplayBoard();
                if (player1Turn)
                {
                    Console.WriteLine("Player 1's turn: ");
                    Console.WriteLine("Enter Column: ");
                    int column = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Row: ");
                    int row = Convert.ToInt32(Console.ReadLine());
                    if (board.UpdateBoard(row, column, player1.Mark))
                    {
                        if (board.CheckWin(player1.Mark))
                        {
                            board.DisplayBoard();
                            Console.WriteLine("##############");
                            Console.WriteLine("Player 1 WINS!");
                            Console.WriteLine("##############");
                            running = false;
                        } else
                        {
                            player1Turn = false;
                        }
                        
                    }

                }
                else
                {   
                    
                    Console.WriteLine("Player 2's turn: ");
                    Console.WriteLine("Enter Column: ");
                    int column = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Row: ");
                    int row = Convert.ToInt32(Console.ReadLine());
                    if(board.UpdateBoard(row, column, player2.Mark))
                    {
                        if (board.CheckWin(player2.Mark))
                        {
                            board.DisplayBoard();
                            Console.WriteLine("##############");
                            Console.WriteLine("Player 2 WINS!");
                            Console.WriteLine("##############");
                            running = false;
                        }
                        else
                        {
                            player1Turn = true;
                        }
                    }
                    
                }
                
            }
            
            
        }
    }
}