# Atividade 5

UTILIZE O DIAGRAMA DE CLASSES APRESENTADO À SEGUIR PARA DESENVOLVER UMA APLICAÇÃO COM AS OPÇÕES ABAIXO:

***

### Diagrama de classes


| Livro                                        | 
|----------------------------------------------|
| - isbn: int                                  |
| - titulo: string                             |
| - autor: string                              |
| - editora: string                            |
| - exemplares: List<Exemplar>                 |
|----------------------------------------------|
| + adicionarExemplar(Exemplar exemplar): void |
| + qtdeExemplares(): int                      |
| + qtdeDisponiveis(): int                     |
| + qtdeEmprestimos(): int                     |
| + percDisponibilidade(): double              |

| Exemplar                         | 
|----------------------------------|
| - tombo: int                     |
| - emprestimos: List<Emprestimo>  |
|----------------------------------|
| + emprestar(): bool              |
| + devolver(): bool               |
| + disponivel(): bool             |
| + qtdeEmprestimos(): int         |


| Emprestimo                 |
|----------------------------|
| - dtEmprestimo: DateTime   |
| - dtDevolucao: DateTime    |


| Livros                           |
|----------------------------------|
| - acervo: List<Livro>            |
|----------------------------------|
| + adicionar(Livro livro): void   |
| + pesquisar(Livro livro): Livro  |

***

### Opções no seletor:

O PROJETO DEVERÁ SER DESENVOLVIDO EM C# CONSOLE APPLICATION, OFERECENDO AS SEGUINTES OPÇÕES PARA O USUÁRIO:

|Codigo | Opção                           |
|-------|---------------------------------|
|   0   | Sair                            |
|   1   | Adicionar livro                 |
|   2   | Pesquisar livro (sintético)¹    |
|   3   | Pesquisar livro (analítico)²    |
|   4   | Adicionar exemplar              |
|   5   | Registrar empréstimo            |
|   6   | Registrar devolução             |

¹ Informar dos dados básicos do livro com as quantidades: total de exemplares, de exemplares disponíveis, de empréstimos e o respectivo percentual de disponibilidade do título

² Informando, além dos dados acima, os detalhes dos seus exemplares e respectivos empréstimos


