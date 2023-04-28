# TicTacToeAPI

TicTacToeAPI is a RESTful web service built using C#, ASP.NET Core 6.0, and implements TicTacToe turn-based game logic for 2 players(X and O).

##Features

-All necessary game logic to play the game
 -Initializing the players
 -Making moves
 -Finding a winner
-RESTful API for easy integration with other applications
-Swagger/OpenAPI documentation for easy testing and integration

## Prerequisites

- .NET 6.0 SDK
- Visual Studio or Visual Studio Code (with C# extension)

## Installation

1. Clone the repository
2. Navigate to the project folder
3. Restore dependancies: dotnet restore

## Usage
To run the project locally, use the following command: dotnet run
This will usually start the API at `http://localhost:5000` or `https://localhost:5001`, but in case it chooses a different port, pay attention to the powershell output

## API Endpoints

-`GET /api/game/board` gets information about the board as a jagged array of strings. Each string has 3 characters that are empty "" by default.
-`GET /api/game/currentPlayer` gets information about the current player (O or X) to use that character to make a move in the jagged array of strings.
-`POST /api/game/makeMove` choose where you place your character (O or X) in any string of the array(index 0 to 2).
-`GET /api/game/isGameOver` checks if the game is over.
-`GET /api/game/isBoardFull` checks if the board is full.
-`GET /api/game/getWinner` gets a winner player if there is any.

## Testing

You can test the API using tools like Postman or Swagger UI by importing the OpenAPI specification available at http://localhost:5000/swagger/v1/swagger.json or https://localhost:5001/swagger/v1/swagger.json.
