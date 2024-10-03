# dPeriodos (Power Query M)  

Essa é a versão oficial em português brasileiro "pt-BR".  
See [here](https://github.com/alisonpezzott/dperiods-powerquery) for English Version "en-US".  


## Download PBIX pronto
[dcalendario-v6.0.pbix](https://github.com/alisonpezzott/dcalendario-powerquery/releases/tag/v6.0) 

Esta versão já inclui a tabela de [dCalendario](https://github.com/alisonpezzott/dcalendario-powerquery)

## Usando o código no Power Query + Script Tabular Editor
1. Efetue os passos a seguir somente após já ter concluído o processo da [dCalendario](https://github.com/alisonpezzott/dcalendario-powerquery);
2. Copie o código em [dperiodos.pq](dperiodos.pq);
3. No Power Query crie uma nova consulta nula;
4. Abra o editor avançado e cole o código;
5. Ajuste as configurações nas etapas;
6. Renomeie a consulta para dPeriodos;
7. Feche e aplique;
8. Clique no menu `Ferramentas Externas`;
9. Abra o [Tabular Editor](https://www.sqlbi.com/tools/tabular-editor) previamente instalado;
10. Vá em `File > Preferences > Features` e habilite `Allow unsupported Power BI features` e clique em `OK`;
11. Copie o código em [dperiodos-tabular-editor.cs](dperiodos-tabular-editor.cs) e cole na janela `C# Script` e clique em `Run` ou pressione `F5`;
12. Depois vá em `File > Save` ou pressione `Ctrl+S`;
13. Pronto, volte para o Power BI e sua tabela dPeriodos estará completa, classificada e organizada.

## Usando o código no Power Query + Ordenação Manual
1. Efetue os passos a seguir somente após já ter concluído o processo da [dCalendario](https://github.com/alisonpezzott/dcalendario-powerquery);
2. Copie o código em [dperiodos.pq](dperiodos.pq);
3. No Power Query crie uma nova consulta nula;
4. Abra o editor avançado e cole o código;
5. Ajuste as configurações nas etapas;
6. Renomeie a consulta para dPeriodos;
7. Feche e aplique;
8. Com base no arquivo [dperiodos-ordenacao.xlsx](dperiodos-ordenacao.xlsx) faça a ordenação das colunas
9. Relacione as colunas dCalendario[Data] com dPeriodos[Data] com cardinalidade muitos para muitos, porém com sentido único da dPeriodos filtrando a dCalendario


