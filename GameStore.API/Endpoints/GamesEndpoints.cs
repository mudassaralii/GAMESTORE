using GameStore.API.Dtos;
namespace GameStore.API.Endpoints;
public static class GamesEndpoints
{
    const string GetGameEndpointName = "GetName";


 private static readonly List<GameDtos> games = [
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
//extension method - 
public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app)
    {
        //group build
        //all of my route start with games
        var group = app.MapGroup("games")
                    .WithParameterValidation(); //minimalAPIs extensions for applying endpoint parameters validations to all endpoints;

        //GET /games
        group.MapGet("/", () => games);

        // GET /games/1
        group.MapGet("/{id}", (int id) =>
         {
             GameDtos? game = games.Find(game => game.Id == id);

             return game is null ? Results.NotFound() : Results.Ok(game);
         })
        .WithName(GetGameEndpointName);

        // POST /games
        group.MapPost("/", (CreateGameDto newGame) =>
        {
        GameDtos game = new (
        games.Count + 1,
        newGame.Name,
            newGame.Genre,
            newGame.Price,
            newGame.ReleaseDate);
        games.Add(game);

        return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game);  //return id with paylod of the newly created record
    });
    

    //PUT /games
    group.MapPut("/{id}", (int id, UpdateGameDto updatedGame) =>
    {
        var index = games.FindIndex(game => game.Id == id);

        if(index == -1)
        {
            return Results.NotFound();
        }
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
    group.MapDelete("/{id}", (int id) =>
    {
        games.RemoveAll(game => game.Id == id);

        return Results.NoContent();
    });

   return group;

}
}