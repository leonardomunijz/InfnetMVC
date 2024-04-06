# InfnetMVC
Este é um projeto ASP.NET Core Web App MVC que visa demonstrar a implementação de um sistema de gestão de funcionários e departamentos, utilizando o template InfnetMVC e autenticação de Contas Individuais.

## Funcionalidades Implementadas
* Cadastro, edição, exclusão e listagem de funcionários.
* Cadastro, edição, exclusão e listagem de departamentos.
* Relação entre departamentos e funcionários (um departamento pode ter vários funcionários).
* Visual agradável utilizando Bootstrap.
* Inserção de funcionário associado a um departamento existente.
* Mensagens sobre a disciplina e sugestões de melhorias na página inicial.
* Validações e formatações na classe Funcionario.
* Busca por nome de funcionário na página de índice.

## Classes Implementadas
### Funcionario
* Id: Identificador único do funcionário.
* Nome: Nome do funcionário (máximo de 50 caracteres).
* Endereco: Endereço do funcionário.
* Telefone: Número de telefone do funcionário.
* Email: Endereço de e-mail do funcionário.
* Data de Nascimento: Data de nascimento do funcionário.
### Departamento
* Id: Identificador único do departamento.
* Nome: Nome do departamento.
* Local: Localização do departamento.
### InfnetDbContext
Contexto do banco de dados que contém as tabelas de Funcionario e Departamento.

## Passos para Execução
1. Clone este repositório.
2. Abra o projeto no Visual Studio.
3. Execute o comando Add-Migration no Console do Gerenciador de Pacotes para criar a migração.
4. Execute o comando Update-Database para aplicar a migração e criar o banco de dados.
5. Execute o projeto pressionando F5 ou clicando em "Iniciar".

## Sugestões de Melhoria
* Implementar paginação na listagem de funcionários e departamentos para melhorar a performance em casos de muitos registros.
* Adicionar mais campos de informações relevantes aos funcionários e departamentos, conforme necessidade.
* Implementar testes automatizados para garantir a qualidade do código.
* Melhorar o design e a usabilidade da interface do usuário para uma experiência mais intuitiva.

## Contato
Para mais informações ou sugestões, entre em contato através do e-mail: leonardo.muniz@al.infnet.edu.br .

