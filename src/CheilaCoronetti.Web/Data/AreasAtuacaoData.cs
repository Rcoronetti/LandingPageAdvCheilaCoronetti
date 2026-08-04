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
            "Recursos junto ao INSS e ao CRPS para reverter indeferimentos, com estratégia definida caso a caso.")
    };
}