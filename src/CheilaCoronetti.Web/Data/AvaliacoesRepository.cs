namespace CheilaCoronetti.Web.Data;

public sealed record Avaliacao(string Nome, string Texto, int Estrelas, string? Foto = null);

public static class AvaliacoesRepository
{
    // Há 17 avaliações reais no perfil Google do escritório.
    // Cole os textos reais abaixo, um por entrada, seguindo o padrão:
    // new("Nome do cliente", "Texto da avaliação", 5),
    // Para usar foto real, adicione o 4º argumento: new("Nome", "Texto", 5, "url-da-foto")
    // Sem foto, o carrossel mostra as iniciais do nome.
    public static readonly Avaliacao[] Todas =
    {
        new("Cliente 1",
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            5),
        new("Cliente 2",
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore.",
            5),
        new("Cliente 3",
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore.",
            5),
        new("Cliente 4",
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
            5),
        new("Cliente 5",
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt.",
            5),
        new("Cliente 6",
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis aute irure dolor in reprehenderit.",
            5)
    };
}