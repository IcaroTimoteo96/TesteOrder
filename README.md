# TesteOrder

O TesteOrder é um desafio técnico onde estou fazendo o desenvolvimento de testes automatizados utilizando o xUnit.

# Tarefa

O desafio solicitou a criação de testes automatizados para garantir a qualidade de uma API de gestão de pedidos para uma loja online.

# Especificações Técnicas

## 1. Tecnologias:
  xUnit
## 2. Entidades:

### Order:

- public int Id { get; set; }
- public string CustomerName { get; set; }
- public List<string> Products { get; set; } = new List<string>();
- public decimal TotalAmount { get; set; }
- public bool IsProcessed { get; private set; }


## 3. Teste do seguintes cenários:
- Implemente testes para os seguintes cenários:
- Adicionar um produto válido.
- Adicionar um produto inválido (nome vazio ou preço zero/negativo).
- Processar um pedido com produtos.
- Tentar processar um pedido vazio (deve lançar exceção).

# Desenvolvimento

## O que foi feito:

- Implemente testes para os seguintes cenários:
- Adicionar um produto válido.
- Adicionar um produto inválido (nome vazio ou preço zero/negativo).
- Processar um pedido com produtos.
- Tentar processar um pedido vazio (deve lançar exceção).

## Resultados
