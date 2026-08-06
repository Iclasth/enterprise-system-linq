# Employee Data Processor

## 💻 Sobre o Projeto
Este é um projeto de aplicação de console desenvolvido em **C# / .NET** focado no processamento e análise de dados de funcionários. A aplicação lê um arquivo `.csv` contendo informações (nome, email e salário) e realiza filtragens e cálculos específicos com base em critérios fornecidos pelo usuário.

Apesar de ser uma aplicação de console de escopo simples, este projeto foi desenvolvido com o intuito de aplicar e demonstrar o domínio sobre uma ampla gama de conceitos do ecossistema .NET. A construção transita desde fundamentos de lógica de programação e pilares da Orientação a Objetos (POO), até recursos mais avançados e idiomáticos da linguagem C#, como manipulação de arquivos e expressões Lambda com LINQ.

## 🚀 Funcionalidades
- **Sistema de Login:** Um loop de autenticação (email e senha) implementado no *entry point* da aplicação utilizando lógica estruturada.
- **Leitura de Arquivos:** Importação de dados de funcionários a partir de arquivos `.csv` utilizando as classes `File` e `StreamReader`.
- **Filtragem Avançada:** Busca e exibição (em ordem alfabética) dos emails de funcionários cujo salário seja superior a um valor dinâmico informado pelo usuário.
- **Agregação de Dados:** Cálculo automático da soma dos salários de todos os funcionários cujo nome começa com a letra 'M'.

## 🛠️ Tecnologias e Conceitos Aplicados
- **C# e .NET:** Plataforma e linguagem base do projeto.
- **Lógica de Programação:** Estruturas de repetição (loops) e condicionais aplicadas no sistema de login e validações.
- **POO (Programação Orientada a Objetos):** Aplicação dos pilares da POO para a modelagem das entidades (ex: `Employee`).
- **Manipulação de Arquivos (I/O):** Leitura de fluxos de dados de forma segura com `StreamReader`.
- **LINQ e Expressões Lambda:** Utilizados para realizar consultas, ordenações (`OrderBy`) e agregações (`Sum`, `Where`) diretamente nas coleções de dados de forma funcional e declarativa.

## 📋 Exemplo de Uso

**Arquivo de entrada (employees.txt / employees.csv):**
```text
Maria,maria@gmail.com,3200.00
Alex,alex@gmail.com,1900.00
Marco,marco@gmail.com,1700.00
Bob,bob@gmail.com,3500.00
Anna,anna@gmail.com,2800.00
```

## Execução no Console:

```text
[Login]
Email: admin@admin.com
Senha: ***

Enter full file path: c:\temp\in.txt
Enter salary: 2000.00

Email of people whose salary is more than 2000.00:
anna@gmail.com
bob@gmail.com
maria@gmail.com

Sum of salary of people whose name starts with 'M': 4900.00
````
## 💡 Reflexão
O desenvolvimento deste projeto foi um excelente exercício técnico. Ele representa de forma clara o meu nível atual de proficiência com o ecossistema .NET, mostrando que consigo aliar perfeitamente lógicas elementares com soluções modernas, eficientes e limpas, fundamentais para a rotina de um desenvolvedor back-end.
