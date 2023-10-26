# CapiFiscal
Gerador de Cupom fiscal via arquivo CSV

## Ideia do Projeto
O Projeto surge como uma forma de estudar e aprimorar os conceitos da Programação Orientada a Objetos(POO). E então temos **CapiFiscal**, um gerador de nota fiscal que contará com duas versões uma versão que roda via console e outra que gera um arquivo de texto com as informações da nota fiscal. O Projeto permite uma vasta possibilidade de melhoria e expansão, então idealmente terão muitas versões com novas funcionalidades e correções.

## Versão para Console
Link do repositório: [ConsoleVersion](https://github.com/lucasApalosqui/CapiFiscal/tree/ConsoleVersion)

Versão Atual: 0.1

### Como Funciona?
1. Instancie a Classe **CupomFiscal** e no seu construtor defina as informações referentes ao cabeçalho da nota fiscal

![image](https://github.com/lucasApalosqui/CapiFiscal/assets/70145530/43994bb8-75c0-408b-8ffa-bed0c9a1454a)

2. Crie um Arquivo Csv separado por virgulas contendo as informações dos produtos que devem ser imprimidos na nota fiscal

![image](https://github.com/lucasApalosqui/CapiFiscal/assets/70145530/af2c7542-2329-48df-bbf7-aa8acb48b026)

3. Chame o método **AdicionarCsv** e adicione o nome do arquivo Csv criado anteriormente

![image](https://github.com/lucasApalosqui/CapiFiscal/assets/70145530/38eba854-d5cc-435c-a6b2-ca58f186b8cc)

4. Chame o método **GerarCupom** que irá imprimir no Console o Cupom Fiscal e as informações sobre os itens que foram comprados

![image](https://github.com/lucasApalosqui/CapiFiscal/assets/70145530/8e8625f5-ee20-4884-a640-b751cfbb9f9d)

![image](https://github.com/lucasApalosqui/CapiFiscal/assets/70145530/d25bfb6c-98e0-4d8d-b647-0036514ab7bb)

### Ferramentas e Conceitos utilizados
- Herança
- Polimorfismo
- Sobrecarga
- Membros Estáticos
- Manipulação de Strings
- Biblioteca CsvHelper

### Proximas Atualizações
- Tratamento de exceções
- Versão com retorno para arquivo txt
- Escolha de forma de pagamento
- Documentação Completa do Programa

### Conclusão
CapiFiscal é um programa simples, mas que permite rever e reencontrar os conceitos do POO de forma que podemos entender e estudar de forma prática e recompensadora a linguagem C#.








