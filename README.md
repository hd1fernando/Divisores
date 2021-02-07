# Divisores
![main](https://github.com/hd1fernando/Divisores/workflows/main/badge.svg)

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
A Api iniciará sua execução.

Abra o seu navegador e acesse a url: https://localhost:5001/api/divisores/45

O seguinte resultado deve aparecer no seu navegador

``` chrome
{"numeroDeEntrada":"45","numerosDivisores":["1","3","5","9","15","45"],"divisoresPrimos":["3","5"]}
````

## Detalhes do projeto
* [GitFlow](https://www.atlassian.com/br/git/tutorials/comparing-workflows/gitflow-workflow) para fluxo de trabalho com Git.

* [Udacity Style Guide](https://udacity.github.io/git-styleguide/) para descrição de commits.

* [GitHub Actions](https://github.com/hd1fernando/Divisores/actions) para execução automática de CI.

## Bibliotecas utilizadas
- [XUnit](https://xunit.net/) para criação de testes de automatizado.

- [Fluent Assertions](https://fluentassertions.com/) para realizar assert nos testes automatizados.

-[AutoMapper](https://automapper.org/) para mapear objetos.
