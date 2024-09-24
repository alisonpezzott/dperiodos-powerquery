let
    //Gera uma tabela
    periodos = #table (

        //Declaração das colunas e tipos
        type table [
            Periodo = text,
            PeriodoOrdinal = Int64.Type,
            PeriodoGrupo = text,
            PeriodoGrupoOrdinal = Int64.Type,
            Data = list
        ],

        //Armazena em buffer a dCalendario
        let dCalendario = Table.Buffer ( dCalendario ) in


        //Lista das listas dos valores de cada campo
        {

        //Todo período
            { "Todo o período",         1, "Todo o período",  1, dCalendario[Data]                                                                                },        

        //Dia
            { "Hoje",                   2, "Dia",             2, Table.SelectRows ( dCalendario, each [DataOffset] =     0                       )[Data]          },
            { "Ontem",                  3, "Dia",             2, Table.SelectRows ( dCalendario, each [DataOffset] =    -1                       )[Data]          },   
            { "Anteontem",              4, "Dia",             2, Table.SelectRows ( dCalendario, each [DataOffset] =    -2                       )[Data]          },
            { "Últimos 7 dias",         5, "Dia",             2, Table.SelectRows ( dCalendario, each [DataOffset] >=   -6 and [DataOffset] <= 0 )[Data]          },
            { "Últimos 15 dias",        6, "Dia",             2, Table.SelectRows ( dCalendario, each [DataOffset] >=  -14 and [DataOffset] <= 0 )[Data]          },
            { "Últimos 30 dias",        7, "Dia",             2, Table.SelectRows ( dCalendario, each [DataOffset] >=  -29 and [DataOffset] <= 0 )[Data]          },
            { "Últimos 60 dias",        8, "Dia",             2, Table.SelectRows ( dCalendario, each [DataOffset] >=  -59 and [DataOffset] <= 0 )[Data]          },
            { "Últimos 90 dias",        9, "Dia",             2, Table.SelectRows ( dCalendario, each [DataOffset] >=  -89 and [DataOffset] <= 0 )[Data]          },
            { "Últimos 180 dias",      10, "Dia",             2, Table.SelectRows ( dCalendario, each [DataOffset] >= -179 and [DataOffset] <= 0 )[Data]          },
            { "Últimos 365 dias",      11, "Dia",             2, Table.SelectRows ( dCalendario, each [DataOffset] >= -364 and [DataOffset] <= 0 )[Data]          },

        //Semana
            { "Esta semana",           12, "Semana",          3, Table.SelectRows ( dCalendario, each [SemanaOffset] =    0  )[Data]                              },
            { "Semana passada",        13, "Semana",          3, Table.SelectRows ( dCalendario, each [SemanaOffset] =   -1  )[Data]                              },
            { "Semana retrasada",      14, "Semana",          3, Table.SelectRows ( dCalendario, each [SemanaOffset] =   -2  )[Data]                              },
            { "Últimas 3 semanas",     15, "Semana",          3, Table.SelectRows ( dCalendario, each [SemanaOffset] >=  -2 and [SemanaOffset] <= 0 )[Data]       },
            { "Últimas 6 semanas",     16, "Semana",          3, Table.SelectRows ( dCalendario, each [SemanaOffset] >=  -5 and [SemanaOffset] <= 0 )[Data]       },
            { "Últimas 9 semanas",     17, "Semana",          3, Table.SelectRows ( dCalendario, each [SemanaOffset] >=  -8 and [SemanaOffset] <= 0 )[Data]       },
            { "Últimas 12 semanas",    18, "Semana",          3, Table.SelectRows ( dCalendario, each [SemanaOffset] >= -11 and [SemanaOffset] <= 0 )[Data]       },

        //Quinzena
            { "Esta Quinzena",         19, "Quinzena",       5, Table.SelectRows ( dCalendario, each [QuinzenaOffset] =    0 )[Data]                               },
            { "Quinzena passada",      20, "Quinzena",       5, Table.SelectRows ( dCalendario, each [QuinzenaOffset] =   -1 )[Data]                               },
            { "Quinzena retrasada",    21, "Quinzena",       5, Table.SelectRows ( dCalendario, each [QuinzenaOffset] =   -2 )[Data]                               },
            { "Últimas 3 Quinzenas",   22, "Quinzena",       5, Table.SelectRows ( dCalendario, each [QuinzenaOffset] >=  -2 and [QuinzenaOffset] <= 0 )[Data]     },
            { "Últimas 6 Quinzenas",   23, "Quinzena",       5, Table.SelectRows ( dCalendario, each [QuinzenaOffset] >=  -5 and [QuinzenaOffset] <= 0 )[Data]     },
            { "Últimas 9 Quinzenas",   24, "Quinzena",       5, Table.SelectRows ( dCalendario, each [QuinzenaOffset] >=  -8 and [QuinzenaOffset] <= 0 )[Data]     },
            { "Últimas 12 Quinzenas",  25, "Quinzena",       5, Table.SelectRows ( dCalendario, each [QuinzenaOffset] >= -11 and [QuinzenaOffset] <= 0 )[Data]     },

        //Mês
            { "Este mês",              26, "Mês",             4, Table.SelectRows ( dCalendario, each [MesOffset] =    0 )[Data]                                  },
            { "Mês passado",           27, "Mês",             4, Table.SelectRows ( dCalendario, each [MesOffset] =   -1 )[Data]                                  },
            { "Mês retrasado",         28, "Mês",             4, Table.SelectRows ( dCalendario, each [MesOffset] =   -2 )[Data]                                  },
            { "Últimos 3 meses",       29, "Mês",             4, Table.SelectRows ( dCalendario, each [MesOffset] >=  -2 and [MesOffset] <= 0 )[Data]             },
            { "Últimos 6 meses",       30, "Mês",             4, Table.SelectRows ( dCalendario, each [MesOffset] >=  -5 and [MesOffset] <= 0 )[Data]             },
            { "Últimos 9 meses",       31, "Mês",             4, Table.SelectRows ( dCalendario, each [MesOffset] >=  -8 and [MesOffset] <= 0 )[Data]             },
            { "Últimos 12 meses",      32, "Mês",             4, Table.SelectRows ( dCalendario, each [MesOffset] >= -11 and [MesOffset] <= 0 )[Data]             },

        //Trimestre
            { "Este trimestre",        33, "Trimestre",       5, Table.SelectRows ( dCalendario, each [TrimestreOffset] =    0 )[Data]                            },
            { "Trimestre passado",     34, "Trimestre",       5, Table.SelectRows ( dCalendario, each [TrimestreOffset] =   -1 )[Data]                            },
            { "Trimestre retrasado",   35, "Trimestre",       5, Table.SelectRows ( dCalendario, each [TrimestreOffset] =   -2 )[Data]                            },
            { "Últimos 3 trimestres",  36, "Trimestre",       5, Table.SelectRows ( dCalendario, each [TrimestreOffset] >=  -2 and [TrimestreOffset] <= 0 )[Data] },
            { "Últimos 6 trimestres",  37, "Trimestre",       5, Table.SelectRows ( dCalendario, each [TrimestreOffset] >=  -5 and [TrimestreOffset] <= 0 )[Data] },
            { "Últimos 9 trimestres",  38, "Trimestre",       5, Table.SelectRows ( dCalendario, each [TrimestreOffset] >=  -8 and [TrimestreOffset] <= 0 )[Data] },
            { "Últimos 12 trimestres", 39, "Trimestre",       5, Table.SelectRows ( dCalendario, each [TrimestreOffset] >= -11 and [TrimestreOffset] <= 0 )[Data] },
            
        //Ano    
            { "Este ano",              40, "Ano",             6, Table.SelectRows ( dCalendario, each [AnoOffset] =    0 )[Data]                                  },
            { "Ano passado",           41, "Ano",             6, Table.SelectRows ( dCalendario, each [AnoOffset] =   -1 )[Data]                                  },
            { "Ano retrasado",         42, "Ano",             6, Table.SelectRows ( dCalendario, each [AnoOffset] =   -2 )[Data]                                  },
            { "Últimos 2 anos",        43, "Ano",             6, Table.SelectRows ( dCalendario, each [AnoOffset] >=  -2 and [AnoOffset] <= 0 )[Data]             },
            { "Últimos 3 anos",        44, "Ano",             6, Table.SelectRows ( dCalendario, each [AnoOffset] >=  -5 and [AnoOffset] <= 0 )[Data]             },
            { "Últimos 4 anos",        45, "Ano",             6, Table.SelectRows ( dCalendario, each [AnoOffset] >=  -8 and [AnoOffset] <= 0 )[Data]             },
            { "Últimos 5 anos",        46, "Ano",             6, Table.SelectRows ( dCalendario, each [AnoOffset] >= -11 and [AnoOffset] <= 0 )[Data]             },

        //Até             
            { "Até hoje",              47, "Até",             7, Table.SelectRows ( dCalendario, each [DataOffset] <= 0 )[Data]                                   },
            { "Até ontem",             48, "Até",             7, Table.SelectRows ( dCalendario, each [DataOffset] <= -1 )[Data]                                  },
            { "Até anteontem",         49, "Até",             7, Table.SelectRows ( dCalendario, each [DataOffset] <= -2 )[Data]                                  }
        }
    ),

    //Expande a coluna de lista Data
    datasPeriodoExpandido = Table.ExpandListColumn ( periodos, "Data" ),
    
    //Altera o tipo da coluna Data para data
    tipoAlterado = Table.TransformColumnTypes ( datasPeriodoExpandido, {{"Data", type date}} )
    
in
    tipoAlterado
