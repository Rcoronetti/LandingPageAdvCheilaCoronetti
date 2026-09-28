namespace CheilaCoronetti.Web.Data;

public sealed record AreaAtuacao(string Titulo, string Descricao);

public static class AreasAtuacaoData
{
    public static readonly AreaAtuacao[] Todas =
    {
        new("Aposentadorias",
            "Aposentadoria por idade, tempo de contribuição, especial e rural, com análise completa do seu histórico junto ao INSS."),
        new("Revisão de benefícios",
            "Verificação de erros de cálculo, períodos não computados e direitos que podem aumentar o valor do seu benefício."),
        new("Auxílios por incapacidade",
            "Auxílio-doença e aposentadoria por invalidez, com acompanhamento em perícias e recursos."),
        new("Auxílio-acidente",
            "Garantia do benefício para quem sofreu acidente e ficou com sequelas que reduzem a capacidade de trabalho."),
        new("Auxílio-reclusão",
            "Amparo à família do segurado preso, assegurando o benefício aos dependentes que preenchem os requisitos."),
        new("Auxílio-inclusão",
            "Benefício destinado a pessoas com deficiência que passam a exercer atividade remunerada."),
        new("Pensão por morte",
            "Benefício devido aos dependentes do segurado falecido, com análise correta da qualidade de segurado."),
        new("Salário-maternidade",
            "Benefício para seguradas empregadas, contribuintes individuais, facultativas, rurais e desempregadas."),
        new("Benefícios rurais",
            "Aposentadorias, pensões e auxílios para trabalhadores rurais, com comprovação da atividade por documentos e testemunhas."),
        new("Recursos administrativos",
            "Recursos junto ao INSS e ao CRPS para reverter indeferimentos, com estratégia definida caso a caso."),
        new("BPC/LOAS",
            "Benefício assistencial a idosos e pessoas com deficiência em situação de vulnerabilidade, sem exigência de contribuição prévia."),
        new("Planejamento previdenciário",
            "Simulação e orientação sobre a estratégia mais vantajosa para requerer a aposentadoria, evitando perda de direitos."),
        new("Restabelecimento de benefício",
            "Reativação de auxílio-doença ou outro benefício cessado ou suspenso indevidamente pelo INSS."),
        new("Tempo especial e rural",
            "Reconhecimento de períodos de atividade especial ou rural não computados pelo INSS, por via administrativa ou judicial."),
        new("Isenção de Imposto de Renda",
            "Isenção de IR sobre proventos de aposentados e pensionistas portadores de doença grave prevista em lei."),
        new("Certidão de tempo de contribuição (CTC)",
            "Emissão de certidão para averbação de tempo em outro regime previdenciário, como o RPPS.")
    };
}