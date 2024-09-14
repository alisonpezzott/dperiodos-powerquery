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