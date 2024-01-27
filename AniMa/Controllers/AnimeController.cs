using AniMa.Forms.Interfaces;
using AniMa.Models;
using Microsoft.AspNetCore.Mvc;

namespace AniMa;

[ApiController]
[Route("[controller]")]
public class AnimeController(AnimeManager manager, IFormRemoteAction formAction) : ControllerBase
{
    private readonly AnimeManager _animeManager = manager;
    private readonly IFormRemoteAction _formAction = formAction;

    [HttpPost(template: "Watched/{watchId}/{numberOfEpisodes}", Name = "WatchedPost")]
    public ObjectResult WatchedPost(string watchId, int numberOfEpisodes)
    {
        var anime = _animeManager.GetAnime(watchId, numberOfEpisodes);
        if (anime is null)
        {
            return NotFound(new { status = "not found" });
        }

        _formAction.Done(anime);

        return Ok(new { status = "ok" });
    }
}
