# Objetivo

O desafio consiste em criar uma aplicação desktop simples em WPF. A construção dessa aplicação tem como objetivo avaliar as seguintes habilitades do candidato:

- Entrosamento com programação orientada a objetos
- Preocupação com encapsulamento, coesão e acoplamento
- Organização e manutenabilidade do código
- Conhecimento e uso de GUI Architectures *MVVM | MPV | MVP(PV)*
- Conhecimento básico de git
- Conhecimento da linguagem C# e XAML

# Instruções

- Faça um fork do repositório
- Desenvolva a aplicação
- Faça um pull request deste repositório com a sua implementação 

# A aplicação

Em resumo, trata-se de uma aplicação de janela única com a funcionalidade de visualizar curvas de dados (X e Y) em um gráfico e  alterar sua visualização: escala, cor, espessura, etc.

##  Requisitos

Os requisitos foram desenvolvidos como histórias de usuário:

*Legenda*
- **US** -> User Stories -> História de usuário
- **AT** -> Acceptance Test -> Teste de aceitação

```
US1. COMO usuário POSSO visualizar uma curva em um gráfico PARA QUE eu possa conhecer seu comportamento.

AT1. DADO que o programa ainda não foi executado
	 QUANDO abro o programa
	 ENTAO o programa inicia exibindo uma curva no gráfico
	 E a curva é somente linha (ou seja, não possui marcadores)
	 E a linha é vermelha
	 E a escala do gráfico é do tipo linear.

```

```
US2. COMO usuário POSSO alterar a cor da curva plotada no gráfico PARA QUE eu possa melhor ajustar sua aparência a diferentes projetores.

AT1. DADO que existe uma curva plotada no gráfico
	 QUANDO seleciono outra cor
	 ENTAO a curva muda para a cor selecionada.
```

```
US3. COMO usuário POSSO alterar o tipo da linha do gráfico PARA QUE eu possa visualizar de uma forma diferente.

AT1. DADO que existe uma curva plotada no gráfico com tipo de linha normal
	 QUANDO seleciono a opção de linha tracejada
	 ENTAO a curva muda seu desenho para tracejado.

AT2. DADO que existe uma curva plotada no gráfico com tipo de linha tracejada
 	 QUANDO seleciono a opção de linha normal
 	 ENTAO a curva muda seu desenho para linha normal.
```

```
US4. COMO usuário POSSO alterar o tipo de escala do gráfico PARA QUE eu possa visualizar de uma forma diferente.

AT1. DADO que existe uma curva plotada no gráfico em escala linear
	 QUANDO seleciono a opção de tipo de escala logarítimica
	 ENTAO a escala do gráfico muda para logarítimica.

AT2. DADO que existe uma curva plotada no gráfico em escala logarítimica
 	 QUANDO seleciono a opção de tipo de escala linear
 	 ENTAO a escala do gráfico muda para linear.

```

```
US5. COMO usuário POSSO alterar os valores de escala min e max x e min e max y PARA QUE eu possa visualizar melhor um pedaço da curva.

AT1. DADO que existe uma curva plotada
	 QUANDO configuro um valor de minX para 3
	 ENTAO o gráfico ajusta o eixo com o x começando em 3

AT2. DADO que existe uma curva plotada
 	 QUANDO configuro um valor de maxX para 20
 	 ENTAO o gráfico ajusta o eixo com o x terminando em 20

AT3. DADO que existe uma curva plotada
  	 QUANDO configuro um valor de minY para 200
  	 ENTAO o gráfico ajusta o eixo com o y começando em 200

AT4. DADO que existe uma curva plotada
   	 QUANDO configuro um valor de maxY para 600
   	 ENTAO o gráfico ajusta o eixo com o y terminando em 600

AT5. DADO que existe uma curva plotada
   	 QUANDO configuro um valor de maxY/maxX/minY/minX para valores negativos
   	 ENTAO uma mensagem é mostrada ao usuário "Não é permitido valores negativos."
   	 E o eixo do gráfico não é alterado.

OBS: Os valores literais usados neste teste de aceitação são meramente ilustrativos. Esses valores vão depender do dado de entrada.

```

```
US6. COMO usuário POSSO restaurar os valores de escala min e max x e min e max y PARA QUE eu possa retornar a visualização original.

AT1. DADO que existe uma curva plotada
	 E valores de min e max setados
	 QUANDO clico no botão de restaurar
	 ENTAO os valores de min e max voltam para o estado original
	 E o gráfico é atualizado para esses valores.
```

```
US7. COMO usuário POSSO filtrar dados que compõe a curva PARA QUE possa visualizar uma porção mais relevante da curva.

AT1. DADO que existe uma curva plotada
	 QUANDO configuro um valor de minX para 3
	 ENTAO todos os valores de X, do conjunto de dados que compõem a curva, que forem menores que 3 serão retidados do conjunto de dados
	 E a curva será atualizada com o novo conjunto de dados filtrado.

AT2. DADO que existe uma curva plotada
	 QUANDO configuro um valor de maxX para 20
 	 ENTAO todos os valores de X,do conjunto de dados que compõem a curva, que forem maiores que 20 serão retidados do conjunto de dados
 	 E a curva será atualizada com o novo conjunto de dados filtrado.

AT3. DADO que existe uma curva plotada
 	 QUANDO configuro um valor de minY para 200
  	 ENTAO todos os valores de Y,do conjunto de dados que compõem a curva, que forem menores que 200 serão retidados do conjunto de dados
  	 E a curva será atualizada com o novo conjunto de dados filtrado.

AT4. DADO que existe uma curva plotada
  	 QUANDO configuro um valor de maxY para 600
   	 ENTAO todos os valores de Y,do conjunto de dados que compõem a curva, que forem maiores que 600 serão retidados do conjunto de dados
   	 E a curva será atualizada com o novo conjunto de dados filtrado.

AT5. DADO que existe uma curva plotada
   	 QUANDO configuro um valor de maxY/maxX/minY/minX do filtro para valores negativos
   	 ENTAO uma mensagem é mostrada ao usuário "Não é permitido valores negativos."
   	 E e o conjunto de dados que compõe a curva não é alterado.
   	 
OBS: Os valores literais usados neste teste de aceitação são meramente ilustrativos. Esses valores vão depender do dado de entrada.
   	 
```

```
US8. COMO usuário POSSO restaurar o filtro dos dados que compõe a curva PARA QUE eu possa visualizar o dado original.

AT1. DADO que existe uma curva plotada
	 E valores de min e max foram setados
	 QUANDO clico no botão restaurar
	 ENTAO o filtro é desfeito
	 E o gráfico é atualizado.
```

## Wireframe

Nós desenvolvemos um wireframe como sugestão de layout mas sinta-se à vontade para usar outro em sua implementação, o importante é atender os requisitos.

![wireframe](https://cloud.githubusercontent.com/assets/5368452/5074901/031e72b0-6e76-11e4-8891-9e51ea87a452.png)

### Requisitos técnicos

- Cada groupbox deverá ser um UserControl separado e controlado por uma classe separada(ViewModel/Presenter/etc).
- A Window principal deverá incluir os UserControls
- UserControls não conhecem outros UserControls
- Classes controladoras não conhecem outras classes controladoras
- Para o gráfico você deverá usar alguma biblioteca gráfica. Nós recomendamos a biblioteca infragistics:http://www.infragistics.com/products/wpf/charts/data-chart
  - Você pode usar a versão trial.
  - Ela contém o chart *Scatter Line* que será suficiente para realizar o desafio.
  - A documentação é bem tranquila e a API não é dificil de usar.
  - Novamente, se prefirir, é permitido usar outras bibliotecas.

### Observação

**Na pasta *Dados de entrada*, do repositório, existe um XML que contém os dados para a curva a ser visualizada no aplicação.**
 
 *Boa Sorte!*
  

