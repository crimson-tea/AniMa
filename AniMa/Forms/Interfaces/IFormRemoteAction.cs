using AniMa.Models;

namespace AniMa.Forms.Interfaces;

public interface IFormRemoteAction
{
    void Refresh();
    void Done(Anime anime);
}
