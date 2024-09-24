// Este script realiza as seguintes operações:
// 1. Faz a ordenação das colunas de texto pelas colunas numéricas
// 2. Aplica o formato short date para colunas do tipo data
// 3. Remove agregações das colunas numéricas
// 4. Efetua o relacionamento entre dPeriodos e dCalendario

// Acesse a tabela dPeriodos
var dperiodos = Model.Tables["dPeriodos"];  

// Cria um mapeamento das colunas de texto e suas respectivas colunas numéricas para ordenação
var columnPairs = new Dictionary<string, string>
{
    {"Periodo", "PeriodoOrdinal"}, 
    {"PeriodoGrupo", "PeriodoGrupoOrdinal"}
};

// Aplica a ordenação para cada coluna de texto
foreach (var pair in columnPairs)
{
    var textColumn = dperiodos.Columns[pair.Key];  // Coluna de texto
    var sortColumn = dperiodos.Columns[pair.Value];  // Coluna numérica correspondente

    // Verifica se ambas as colunas existem e aplica a ordenação
    if (textColumn != null && sortColumn != null)
    {
        textColumn.SortByColumn = sortColumn;  // Ordena a coluna de texto pela coluna numérica
    }
}

// Desabilitar agregações para todas as colunas da tabela
foreach (var column in dperiodos.Columns)
{
    column.SummarizeBy = AggregateFunction.None;  // Desabilitar agregação
}

// Definir o formato para as colunas do tipo Data
var dateColumns = new[] { "Data" };  // Colunas que contêm datas
foreach (var columnName in dateColumns)
{
    var column = dperiodos.Columns[columnName];
    if (column != null)
    {
        column.FormatString = "Short Date";  // Aplica o formato de data curta
    }
}

// Definição das colunas envolvidas no relacionamento
var daColuna = Model.Tables["dCalendario"].Columns["Data"];
var paraColuna = dperiodos.Columns["Data"];

// Verificar se o relacionamento já existe
if (!Model.Relationships.Any(r => r.FromColumn == daColuna && r.ToColumn == paraColuna))
{
    // Criar um novo relacionamento
    var rel = Model.AddRelationship();
        rel.FromColumn = daColuna;  // Coluna de origem
        rel.ToColumn = paraColuna;      // Coluna de destino

    // Definir comportamento de filtro cruzado unidirecional
    rel.CrossFilteringBehavior = CrossFilteringBehavior.OneDirection;
    
    // Definir cardinalidade muitos para muitos
    rel.FromCardinality = RelationshipEndCardinality.Many;
    rel.ToCardinality = RelationshipEndCardinality.Many;
    
    // Ativar o relacionamento
    rel.IsActive = true;
}
