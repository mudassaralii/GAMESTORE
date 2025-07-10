using GameStore.API;
using GameStore.API.Dtos;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string GetGameEndpointName = "GetName";


List <GameDtos> games = [
    new(
        1,
        "Game1 Name",
        "Fighting",
        19.99M,
        new DateOnly(1972,7,15)),
    new(
        2,
        "Game2 Name",
        "Fighting",
        59.99M,
        new DateOnly(2010,7,15)),
    new(
        3,
        "Game3 Name",
        "Fighting",
        69.99M,
        new DateOnly(2012,7,15))
];

//GET /games
app.MapGet("games", () => games);

// GET /games/1
app.MapGet("games/{id}",(int id) => games.Find(game => game.Id == id))
    .WithName(GetGameEndpointName);

// POST /games
app.MapPost("games", (CreateGameDto newGame) => {
    GameDtos game= new(
        games.Count+1,
        newGame.Name,
        newGame.Genre,
        newGame.Price,
        newGame.ReleaseDate);
    games.Add(game);

    return Results.CreatedAtRoute(GetGameEndpointName,new {id=game.Id},game);  //return id with paylod of the newly created record
});

//PUT /games
app.MapPut("games/{id}", (int id, UpdateGameDto updatedGame) =>
{
    var index = games.FindIndex(game => game.Id == id);

    games[index] = new GameDtos(
        id,
        updatedGame.Name,
        updatedGame.Genre,
        updatedGame.Price,
        updatedGame.ReleaseDate
    );
    return Results.NoContent();
});


//DELETE /games/1
app.MapDelete("games/{id}", (int id) =>
{
    games.RemoveAll(game => game.Id == id);

    return Results.NoContent();
});

app.MapGet("/", () => "Hello World!");

app.Run();
