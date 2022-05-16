

Instalando Componentes necessarios para executar o programa

- Instalar Visual Studio ou Visual Studio Code https://visualstudio.microsoft.com/pt-br/downloads/

- Instalar DotNet Runtime https://dotnet.microsoft.com/en-us/download/dotnet/6.0/runtime

- isntalar o Postman https://www.postman.com/downloads/

- Abrir o projeto

- Abrir o Terminal

- Executar o comando: dotnet run

-------------------------------------------------------------------------------------------

CRIANDO UM PRODUTO

- Dentro do Postmand Desktop App clicar no botão de "+" ao lado de overview

- abaixo trocar a função de Get para Post

- digitar o localhost informado ao rodar a aplicação incluindo "/post" depois do endereço

- abaixo selecionar a opção body

- selecionar a opção raw

- digitar as informações no seguinte formato:
{
    "Id": "xxxxx",
    "Name": "xxxxx",
    "SKU": "xxxx",
    "Price": "xxxxx",
    "Description": "xxxxx"
}

- clicar em send para salvar o produto no banco.
