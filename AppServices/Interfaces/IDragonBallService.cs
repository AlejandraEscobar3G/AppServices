using AppServices.DTOs;

namespace AppServices.Interfaces
{
    public interface IDragonBallService
    {
        Task<DragonBallCharactersResponse?> GetAllCharactersAsync(int? page = null, int? limit = null);
        Task<DragonBallCharacterResponse?> GetCharacterAsync(int id);
    }
}
