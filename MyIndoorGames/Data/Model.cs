
namespace MyIndoorGames.Data
{
    public class Games
    {
        public int ID { get; set; }
        public string GameName { get; set; } = string.Empty;
        public string CountryOrigin { get; set; } = string.Empty;
        public int NumberOfPlayers { get; set; }
    }
}