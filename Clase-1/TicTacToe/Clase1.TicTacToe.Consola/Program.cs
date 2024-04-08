using Clase1.ITicTacToe.Consola;

// Crear una instancia de la clase ConsoleIOImplementation
ConsoleIO console = new ConsoleIOImplementation();

// Crear una instancia de la clase Board
Board board = new Board();

// Crear un arreglo de jugadores
Player[] players = new Player[2];
// Inicializar los jugadores
players[0] = new Player("Player1", 'X');
players[1] = new Player("Player2", 'O');

// Crear una instancia de la clase TicTacToe
TicTacToe game = new TicTacToe(console, board, players);

// Iniciar el juego
game.StartGame();
