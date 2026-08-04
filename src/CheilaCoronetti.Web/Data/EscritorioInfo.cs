namespace CheilaCoronetti.Web.Data;

public static class EscritorioInfo
{
    public const string Nome = "Cheila Coronetti Advogada";
    public const string Slogan = "Direito Previdenciário com quem entende de benefício";
    public const string TelefoneExibicao = "(49) 99971-5330";
    public const string TelefoneWhatsApp = "5549999715330"; // DDI + DDD + número, sem espaços
    public const string WhatsAppMensagem = "Olá! Gostaria de falar com a Dra. Cheila sobre meu caso.";
    public const string Endereco = "R. Mal. Floriano Peixoto, 199 - Pte. Serrada";
    public const string Cidade = "Ponte Serrada - SC, 89683-000";
    public const string InstagramUrl = "https://www.instagram.com/cheila.coronettiadv";
    public const string FacebookUrl = "https://www.facebook.com/advogadacheilacoronetti";
    public const string AnosAtuacao = "13";

    public static string LinkWhatsApp =>
        $"https://wa.me/{TelefoneWhatsApp}?text={Uri.EscapeDataString(WhatsAppMensagem)}";

    public const string DesenvolvedorNome = "Rafael Coronetti";
    public const string DesenvolvedorUrl = "https://github.com/Rcoronetti";
}