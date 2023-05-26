
# Desafio - Programação Orientada ao Objeto

Desenvolver um projeto Windows Forms ou Console Application, conforme o apresentado a seguir.

Suponha uma estrutura de classes (conforme diagrama), para realizar os métodos matemáticos: multiplicar, somar, subtrair e dividir, além de um método para calcular a média aritmética de uma coleção de valores. 

- A classe Basico representa uma classe de calcular, que armazena internamente dois operandos (X e Y), que devem ser representados por duas propriedades e um resultado R (herdado da classe Calculo). Os valores X e Y podem ser alterados, porém, não podem ser lidos. O valor de R é alterado, de acordo com as chamadas dos métodos que realizam as operações matemáticas. 

- A classe Calculo fornece o valor de R que armazena os resultados dos cálculos. Note que essa classe é abstrata. 

- A propriedade Valoresda classe Estatistico, recebe um Array de valores e Calcula a média aritmética, que será armazenado no R (herdado da classe Calculo). 

- Exemplo de operação: Ao realizar a chamada do método Multiplicar(), deve ser realizado R = X * Y.

- Note que pode ocorrer erro ao realizar a divisão de X por Y, caso o valor de Y seja igual a zero. Então, adicione um tratamento de exceção para tratar este problema.

- Perceba que o usuário deverá adicionar os valores de X e Y ou os Valores do vetor e escolher o tipo do cálculo que será realizado.

- Implemente esta estrutura, observando as especificações, inclusive as restrições de encapsulamento referidas neste enunciado. 


## Aluno

- Nome: Jeison Espindola Tomio
- Matrícula: 045882
- Curso: Programação Orientada ao Objeto


## Desenvolvimento

Este código implementa as classes Calculo, Basico e Estatistico de acordo com as especificações dadas. Também é fornecido um menu para o usuário selecionar o tipo de cálculo que deseja realizar e inserir os valores necessários.

- Ao selecionar o cálculo básico, o usuário pode fornecer os valores de X e Y e escolher uma das operações: multiplicação, soma, subtração ou divisão. O resultado da operação é exibido no console.

- Ao selecionar o cálculo estatístico, o usuário pode fornecer a quantidade de valores que deseja calcular a média aritmética e, em seguida, inserir cada valor. A média aritmética é calculada e exibida no console.

- Caso ocorra uma tentativa de divisão por zero, uma exceção será lançada e uma mensagem de erro será exibida.

 
## Support

Compilar e executar esse código em um ambiente de desenvolvimento C# compatível, como o Visual Studio. Certifique-se de criar um novo projeto do tipo "Console Application" e substituir o conteúdo do arquivo Program.cs pelo código fornecido.

