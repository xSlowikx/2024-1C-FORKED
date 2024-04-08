using System;

namespace Clase1.ITicTacToe.Consola;

public interface ConsoleIO
{
    void writeLine(string format, params object[] args);
    void writeLine(string message);
    String readLine();
    // void clear();
}

public class ConsoleIOImplementation : ConsoleIO
{
    public virtual String readLine()
    {
        return Console.ReadLine();
    }

    public virtual void writeLine(string format, params object[] args)
    {
        Console.WriteLine(format, args);
    }

    /* public void clear()
    {
        // Console.Clear();
    } */

    public virtual void writeLine(string message)
    {
        Console.WriteLine(message);
    }
}
