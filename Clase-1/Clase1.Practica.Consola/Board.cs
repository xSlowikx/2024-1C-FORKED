using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.TicTacToe.Consola;

public class Board
{
    //making array and
    //by default I am providing 0-9 where no use of zero
    public char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    public string DisplayBoard()
    {
        // StringBuilder para construir el tablero
        StringBuilder board = new StringBuilder();

        board.AppendLine("     |     |      ");
        board.AppendLine($"  {arr[1]}  |  {arr[2]}  |  {arr[3]}");
        board.AppendLine("_____|_____|_____ ");
        board.AppendLine("     |     |      ");
        board.AppendLine($"  {arr[4]}  |  {arr[5]}  |  {arr[6]}");
        board.AppendLine("_____|_____|_____ ");
        board.AppendLine("     |     |      ");
        board.AppendLine($"  {arr[7]}  |  {arr[8]}  |  {arr[9]}");
        board.AppendLine("     |     |      ");

        // Devolver el tablero como un string
        return board.ToString();
    }

    public char[] checkPositions()
    {
        return this.arr;
    }

    public int CheckWin()
    {
        // Comprobación de filas
        for (int i = 1; i <= 7; i += 3)
        {
            if (arr[i] == arr[i + 1] && arr[i + 1] == arr[i + 2])
            {
                return 1;
            }
        }

        // Comprobación de columnas
        for (int i = 1; i <= 3; i++)
        {
            if (arr[i] == arr[i + 3] && arr[i + 3] == arr[i + 6])
            {
                return 1;
            }
        }

        // Comprobación de diagonales
        if ((arr[1] == arr[5] && arr[5] == arr[9]) ||
            (arr[3] == arr[5] && arr[5] == arr[7]))
        {
            return 1;
        }

        // Comprobación de empate
        bool isDraw = true;
        for (int i = 1; i <= 9; i++)
        {
            if (arr[i] != 'X' && arr[i] != 'O')
            {
                isDraw = false;
                break;
            }
        }
        if (isDraw)
        {
            return -1;
        }

        return 0;
    }

    public void resetBoard()
    {
        // Restablecer el tablero a su estado inicial
        arr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    }
}
