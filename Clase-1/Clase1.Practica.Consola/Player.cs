using System;

namespace Clase1.TicTacToe.Consola;

public class Player
{
    private string name;
    private char symbol; // Nuevo campo para almacenar el símbolo del jugador

    public Player(string name, char symbol)
    {
        this.name = name;
        this.symbol = symbol; // Inicializar el símbolo del jugador
    }

    // Método para obtener el símbolo del jugador
    public char GetSymbol()
    {
        return symbol;
    }

    public void FinalizeTurn()
    {
        // Implementación de la lógica para finalizar el turno si es necesario
    }
}
