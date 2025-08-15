using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages0.Pages;

public class PokemonModel : PageModel
{
    private readonly ILogger<PokemonModel> _logger;

    public PokemonModel(ILogger<PokemonModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }

    public class PokemonInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Emoji { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Height { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public int Popularity { get; set; }
        public string CardClass { get; set; } = string.Empty;
        public string ButtonClass { get; set; } = string.Empty;
    }

    public List<PokemonInfo> PokemonList { get; set; } = new List<PokemonInfo>
    {
        new PokemonInfo
        {
            Name = "Pikachu",
            Emoji = "⚡",
            Type = "Eléctrico",
            Height = "0.4 m",
            Weight = "6.0 kg",
            Popularity = 95,
            CardClass = "border-warning",
            ButtonClass = "btn-warning"
        },
        new PokemonInfo
        {
            Name = "Charizard",
            Emoji = "🔥",
            Type = "Fuego/Volador",
            Height = "1.7 m",
            Weight = "90.5 kg",
            Popularity = 92,
            CardClass = "border-danger",
            ButtonClass = "btn-danger"
        },
        new PokemonInfo
        {
            Name = "Blastoise",
            Emoji = "🌊",
            Type = "Agua",
            Height = "1.6 m",
            Weight = "85.5 kg",
            Popularity = 87,
            CardClass = "border-primary",
            ButtonClass = "btn-primary"
        },
        new PokemonInfo
        {
            Name = "Venusaur",
            Emoji = "🌿",
            Type = "Planta/Veneno",
            Height = "2.0 m",
            Weight = "100.0 kg",
            Popularity = 85,
            CardClass = "border-success",
            ButtonClass = "btn-success"
        },
        new PokemonInfo
        {
            Name = "Gengar",
            Emoji = "👻",
            Type = "Fantasma/Veneno",
            Height = "1.5 m",
            Weight = "40.5 kg",
            Popularity = 89,
            CardClass = "border-dark",
            ButtonClass = "btn-dark"
        },
        new PokemonInfo
        {
            Name = "Dragonite",
            Emoji = "🐲",
            Type = "Dragón/Volador",
            Height = "2.2 m",
            Weight = "210.0 kg",
            Popularity = 91,
            CardClass = "border-info",
            ButtonClass = "btn-info"
        }
    };
}