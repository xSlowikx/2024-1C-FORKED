using System;
using System.Threading.Tasks;

namespace Clase1.TicTacToe.Consola;

public class TicTacToe
{
    private int currentPlayerIndex = 0; // Indice del jugador actual en el arreglo de jugadores
    private int choice; // Esta variable almacena la posición elegida por el jugador para marcar
    private int flag = 0; // Este indicador verifica el estado del juego: 1 si alguien ganó, -1 si es un empate, 0 si el juego sigue
    private ConsoleIO console;
    private Board board;
    private Player[] players;

    public TicTacToe(ConsoleIO console, Board board, Player[] players)
    {
        this.console = console;
        this.board = board;
        this.players = players;
    }

    public void StartGame()
    {
        do
        {
            console.clear();
            console.writeLine("Player1:X and Player2:O");
            console.writeLine("\n");
            console.writeLine("Player {0} Chance", currentPlayerIndex + 1);
            console.writeLine("\n");
            console.writeLine(board.DisplayBoard());

            choice = console.readLine(); // Tomar la elección del usuario

            if (!IsValidInput(choice))
            {
                console.writeLine("Invalid input. Please enter a number between 1 and 9.");
                continue; // Volver al inicio del bucle
            }

            // Verificar si la posición elegida está disponible
            if (board.checkPositions()[choice] != 'X' && board.checkPositions()[choice] != 'O')
            {
                // Marcar la posición elegida con el símbolo del jugador actual
                board.checkPositions()[choice] = players[currentPlayerIndex].GetSymbol();
                // Cambiar al siguiente jugador
                currentPlayerIndex = (currentPlayerIndex + 1) % players.Length;
            }
            else
            {
                console.writeLine("Sorry, the row {0} is already marked with {1}", choice, board.checkPositions()[choice]);
                console.writeLine("\n");
                console.writeLine("Please wait 2 seconds, board is reloading...");
                Task.Delay(2000).Wait();
            }

            flag = board.CheckWin(); // Verificar el estado del juego
        }
        while (flag != 1 && flag != -1);

        console.clear();
        console.writeLine(board.DisplayBoard());

        if (flag == 1)
        {
            console.writeLine("Player {0} has won", (currentPlayerIndex % 2) + 1);
        }
        else
        {
            console.writeLine("Draw");
        }

        console.writeLine("Do you want to play again? (Y/N)");
        string playAgainChoice = console.readLine().ToString().ToUpper(); // Convertir a cadena y luego a mayúsculas
        if (playAgainChoice == "Y")
        {
            // Reiniciar el juego
            ResetGame();
        }
        else
        {
            console.writeLine("Thanks for playing! Goodbye.");
            // Salir del juego
            Environment.Exit(0);
        }
    }

    private bool IsValidInput(int choice)
    {
        return choice >= 1 && choice <= 9;
    }

    private void ResetGame()
    {
        // Reiniciar el tablero y las condiciones del juego
        board.resetBoard();
        currentPlayerIndex = 0;
        flag = 0;
    }
}