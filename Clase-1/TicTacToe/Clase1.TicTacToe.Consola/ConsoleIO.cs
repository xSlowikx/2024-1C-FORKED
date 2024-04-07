using System;

namespace Clase1.TicTacToe.Consola;

public interface ConsoleIO
{
    void writeLine(string format, params object[] args);
    int readLine();
    void clear();
}

public class ConsoleIOImplementation : ConsoleIO
{
    public int readLine()
    {
        int choice = int.Parse(s: Console.ReadLine());
        return choice;
    }

    public void writeLine(string format, params object[] args)
    {
        Console.WriteLine(format, args);
    }

    public void clear()
    {
        Console.Clear();
    }
}
