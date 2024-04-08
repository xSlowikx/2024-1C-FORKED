using Clase1.ITicTacToe.Consola;
using Moq;

namespace Clase1.ITicTacToe.UnitTesting;

public class TicTacToeTest
{
    [Fact]
    public void quePuedaGanarElJugadorUnoEnCincoIntentosTest()
    {
        var consoleMock = new Mock<ConsoleIOImplementation>();

        consoleMock.SetupSequence(mockedConsole => mockedConsole.readLine())
            .Returns("1")
            .Returns("2")
            .Returns("5")
            .Returns("3")
            .Returns("9")
            .Returns("N");

        // Aquí usamos TicTacToe como el tipo de la instancia de TicTacToe
        var ticTacToeGame = new TicTacToe(consoleMock.Object,
                                          new Board(),
                                          new Player[] { new Player("Player1", 'X'),
                                                     new Player("Player2", 'O')
                                                        });

        // Act
        ticTacToeGame.StartGame();

        // Assert
        consoleMock.Verify(x => x.writeLine("Player {0} Chance",1), Times.Exactly(3));
        consoleMock.Verify(x => x.writeLine("Player {0} Chance", 2), Times.Exactly(2));
        consoleMock.Verify(x => x.writeLine("Player {0} has won", 1), Times.Once);
        consoleMock.Verify(x => x.writeLine("Do you want to play again? (Y/N)"), Times.Once);
        consoleMock.Verify(x => x.writeLine("Thanks for playing! Goodbye."), Times.Once);
    }

    [Theory]
    [InlineData("1", "4", "2", "5", "3", "N")]
    [InlineData("4", "1", "5", "2", "6", "N")]
    [InlineData("7", "1", "8", "2", "9", "N")]
    public void queGaneElJugadorUnoCadaFilaPorCompletoTest(string choice1, string choice2, string choice3, string choice4, string choice5, string choice6)
    {
        var consoleMock = new Mock<ConsoleIOImplementation>();

        consoleMock.SetupSequence(mockedConsole => mockedConsole.readLine())
            .Returns(choice1)
            .Returns(choice2)
            .Returns(choice3)
            .Returns(choice4)
            .Returns(choice5)
            .Returns(choice6);

        // Aquí usamos TicTacToe como el tipo de la instancia de TicTacToe
        var ticTacToeGame = new TicTacToe(consoleMock.Object,
                                                     new Board(),
                                                     new Player[] { 
                                                                    new Player("Player1", 'X'),
                                                                    new Player("Player2", 'O')
                                                                   });

        // Act
        ticTacToeGame.StartGame();

        // Assert
        consoleMock.Verify(x => x.writeLine("Player {0} Chance", 1), Times.Exactly(3));
        consoleMock.Verify(x => x.writeLine("Player {0} Chance", 2), Times.Exactly(2));
        consoleMock.Verify(x => x.writeLine("Player {0} has won", 1), Times.Once);
        consoleMock.Verify(x => x.writeLine("Do you want to play again? (Y/N)"), Times.Once);
        consoleMock.Verify(x => x.writeLine("Thanks for playing! Goodbye."), Times.Once);
    }

    [Theory]
    [InlineData("1", "2", "4", "5", "7", "N")]
    [InlineData("2", "1", "5", "3", "8", "N")]
    [InlineData("3", "1", "6", "2", "9", "N")]
    public void queElJugadorUnoGaneCadaColumnaPorCompletoTest(string choice1, string choice2, string choice3, string choice4, string choice5, string choice6)
    {
        var consoleMock = new Mock<ConsoleIOImplementation>();

        consoleMock.SetupSequence(mockedConsole => mockedConsole.readLine())
            .Returns(choice1)
            .Returns(choice2)
            .Returns(choice3)
            .Returns(choice4)
            .Returns(choice5)
            .Returns(choice6);

        // Aquí usamos TicTacToe como el tipo de la instancia de TicTacToe
        var ticTacToeGame = new TicTacToe(consoleMock.Object,
                                                                new Board(),
                                                                new Player[]
                                                                            {
                                                                                new Player("Player1", 'X'),
                                                                                new Player("Player2", 'O')
                                                                            });

        // Act
        ticTacToeGame.StartGame();

        // Assert
        consoleMock.Verify(x => x.writeLine("Player {0} Chance", 1), Times.Exactly(3));
        consoleMock.Verify(x => x.writeLine("Player {0} Chance", 2), Times.Exactly(2));
        consoleMock.Verify(x => x.writeLine("Player {0} has won", 1), Times.Once);
        consoleMock.Verify(x => x.writeLine("Do you want to play again? (Y/N)"), Times.Once);
        consoleMock.Verify(x => x.writeLine("Thanks for playing! Goodbye."), Times.Once);
    }

}