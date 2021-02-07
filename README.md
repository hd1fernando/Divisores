# Divisores

## Tipo de Projeto
Web Api em .Net 5

## Download & execução

No poweshell execute os comandos abaixo
```powershell
git clone https://github.com/hd1fernando/Divisores.git
cd .\Divisores\
dotnet build .\src\Divisores.Api\Divisores.Api.csproj --configuration release
.\src\Divisores.Api\bin\release\net5.0\Divisores.Api.exe
```
A Api iniciará sua execução
Abra o seu navegador e acesse a url:
https://localhost:5001/api/divisores/45

## Detalhes do projeto
* [GitFlow](https://www.atlassian.com/br/git/tutorials/comparing-workflows/gitflow-workflow) para fluxo de trabalho com Git.

* [Udacity Style Guide](https://udacity.github.io/git-styleguide/) para descrição de commits.

## Bibliotecas utlizadas
- [XUnit](https://xunit.net/) para criação de testes de automatizado.

- [Fluent Assertions](https://fluentassertions.com/) para realizar assert nos testes automatizados.

-[AutoMapper](https://automapper.org/) para mapear objetos.
