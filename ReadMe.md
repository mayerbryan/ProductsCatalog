

# Catálogo  de Produtos
Projeto de API criado usando ASP.Net

## Instalando os componentes necessários para executar a aplicação:

- Instalar Visual Studio ou Visual Studio Code https://visualstudio.microsoft.com/pt-br/downloads/
- Instalar DotNet Runtime https://dotnet.microsoft.com/en-us/download/dotnet/6.0/runtime
- Instalar o Docker https://docs.docker.com/desktop/windows/install/
- Instalar o Postman https://www.postman.com/downloads/


## Inicializando o Banco de Dados
Este app utiliza SQL Server para armazenar os dados durante o desenvolvimento.
Abra o Docker que foi instalado anteriormente e deixe o mesmo em execução
Inicialize o CMD ou PowerShell
Navegue até o local onde foi salvo o projeto e execute o seguinte comando:
```
docker pull mcr.microsoft.com/mssql/server:2019-latest
```
Deverá retornar: Status: Downloaded newer image for mcr.microsoft.com/mssql/server:2019-latest

Para inicializar o container que irá guardar as informações utilize o comando:

'''
docker-compose up
'''

## Instalando componentes necessarios para o funcionamento da aplicação:
Após o download do projeto abra o CMD ou PowerShell
Navegue até a pasta onde esta localizado o projeto
- Instale o `dotnet-ef` / 'EF SqlServer' / 'EF Design' usando os seguintes comandos:

```
dotnet tool install --global dotnet-ef
```
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
```
dotnet add package Microsoft.EntityFrameworkCore.Design
```

## Executando a aplicação
Para iniciar a aplicação, execute o seguinte comando no terminal:
```
dotnet run
```
O resultado desse comando incluirá as URLs a serem utilizadas para acessar a API. Exemplo abaixo:
```
Now listening on: https://localhost:7143
Now listening on: http://localhost:5133
```

# Documentação da API

## Criação de produtos

Rota: `/v1/products`
Método: `POST`
Exemplo do corpo requisição para criar um novo produto:
```json
{
    "Name": "Produto teste",
    "SKU": "UTV12U1D2",
    "Price": "12.99",
    "Description": "Produto de teste"
}
```
Exemplo de resposta:
```json
{
    "Id": 1,
    "Name": "Produto teste",
    "SKU": "UTV12U1D2",
    "Price": "12.99",
    "Description": "Produto de teste"
}
```

## Listar todos os produtos
Rota: `/v1/products`
Método: `GET`

Exemplo de resposta:
```json
{
    "Id": 1,
    "Name": "Produto teste",
    "SKU": "UTV12U1D2",
    "Price": "12.99",
    "Description": "Produto de teste"
}
```

## Listar produtos pelo Id
Rota: `/v1/products/{int:id}`
Método: `GET`

Exemplo de resposta:
```json
{
    "Id": 1,
    "Name": "Produto teste",
    "SKU": "UTV12U1D2",
    "Price": "12.99",
    "Description": "Produto de teste"
}
```

## Atualizar produtos pelo Id
Rota: `/v1/products/{int:id}`
Método: `PUT`

Exemplo do corpo requisição para atualizar um novo produto:
```json
{
    "Name": "Produto teste",
    "SKU": "UTV12U1D2",
    "Price": "12.99",
    "Description": "Produto de teste"
}
```

## Deletar produtos pelo Id
Rota: `/v1/products/{int:id}`
Método: `Delete`

Basic catalog products for back end study version 1
