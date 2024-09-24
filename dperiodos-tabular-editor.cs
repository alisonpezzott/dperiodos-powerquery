// Este script realiza as seguintes operações:
// Faz a ordenação das colunas de texto pelas colunas numéricas
// Aplica o formato short date para colunas do tipo data

// Acesse a tabela dPeriodos
var tb = Model.Tables["dPeriodos"];  

// Cria um mapeamento das colunas de texto e suas respectivas colunas numéricas para ordenação
var columnPairs = new Dictionary<string, string>
{
    {"Periodo", "PeriodoOrdinal"}, 
    {"PeriodoGrupo", "PeriodoGrupoOrdinal"}
};

// Aplica a ordenação para cada coluna de texto
foreach (var pair in columnPairs)
{
    var textColumn = tb.Columns[pair.Key];  // Coluna de texto
    var sortColumn = tb.Columns[pair.Value];  // Coluna numérica correspondente

    // Verifica se ambas as colunas existem e aplica a ordenação
    if (textColumn != null && sortColumn != null)
    {
        textColumn.SortByColumn = sortColumn;  // Ordena a coluna de texto pela coluna numérica
    }
}

// Desabilitar agregações para todas as colunas da tabela
foreach (var column in tb.Columns)
{
    column.SummarizeBy = AggregateFunction.None;  // Desabilitar agregação
}

// Definir o formato para as colunas do tipo Data
var dateColumns = new[] { "Data" };  // Colunas que contêm datas
foreach (var columnName in dateColumns)
{
    var column = tb.Columns[columnName];
    if (column != null)
    {
        column.FormatString = "Short Date";  // Aplica o formato de data curta
    }
}

// Referência às tabelas no modelo
var fromTb = Model.Tables["dCalendario"];
var toTb = tb;

// Definição das colunas envolvidas no relacionamento
var fromCol = fromTb.Columns["Data"];
var toCol = toTb.Columns["Data"];

// Verificar se o relacionamento já existe
if (!Model.Relationships.Any(r => r.FromColumn == fromCol && r.ToColumn == toCol))
{
    // Criar um novo relacionamento
    var rel = Model.AddRelationship();
        rel.FromColumn = fromCol;  // Coluna de origem
        rel.ToColumn = toCol;      // Coluna de destino

    // Definir comportamento de filtro cruzado unidirecional
    rel.CrossFilteringBehavior = CrossFilteringBehavior.OneDirection;
    
    // Definir cardinalidade muitos para muitos
    rel.FromCardinality = RelationshipEndCardinality.Many;
    rel.ToCardinality = RelationshipEndCardinality.Many;
    
    // Ativar o relacionamento
    rel.IsActive = true;
}
