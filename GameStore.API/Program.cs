using GameStore.API.Dtos;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



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
    .WithName("GetGame");

// POST /games
app.MapPost("games", (CreateGameDto newGame) => {
    GameDtos game= new(
        games.Count+1,
        newGame.Name,
        newGame.Genre,
        newGame.Price,
        newGame.ReleaseDate);
    games.Add(game);

    return Results.CreatedAtRoute("GetGame",new {id=game.Id},game);  //return id with paylod of the newly created record
});

app.MapGet("/", () => "Hello World!");

app.Run();
