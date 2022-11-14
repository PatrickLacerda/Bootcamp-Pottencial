--select * from Clientes where Nome = 'Patrick' and Sobrenome = 'Lacerda'

--select * from Clientes

--INSERT INTO Clientes 
--VALUES ('Grazielle','Lacerda','grazielelacerda@gmail.com',0, GETDATE())

--UPDATE Clientes 
--SET Email = 'patricklacerda@yahoo.com.br',
--	AceitaComunicados =1
--WHERE Id = 1003

--BEGIN TRAN -- ( SALVA ANTES DA ALTERAÇÃO) TRABALHANDO EM UM MODO QUE PODE DESFAZER ALTERAÇÕES
--ROLLBACK -- ( RESTAURA A BASE DE DADOS ALTES DA ALTERAÇÃO)

--UPDATE Clientes 
--SET Email = 'patricklacerda@yahoo.com.br',
--AceitaComunicados =1

--BEGIN TRAN 
--ROLLBACK

--DELETE  Clientes
--WHERE ID = 1004


--CREATE TABLE Produtos1 (
--	id int IDENTITY(1,1) PRIMARY KEY  NOT NULL, -- PRIMARY KEY GARANTE QUE O NUMERO VAI SER UNICO
--	Nome varchar(255) NOT NULL, 
--	Cor varchar(50) NULL, 
--	Preco decimal(13,2) NOT NULL, -- quantidade de numero com 2 casas decimais 
--	Tamanho varchar(5) NULL,
--	Genero char(1) NULL		,
	
--)

SELECT * FROM Produtos

SELECT COUNT(*) as  QuantidadedeProdutos FROM Produtos -- CONTAGEM DE LINHA ANTES DO ASTERISTICO
SELECT COUNT(*) QuantidadeProdutosTamanhoM FROM Produtos
WHERE Tamanho = 'M'

SELECT SUM(Preco) PrecoTotal from Produtos

SELECT SUM(Preco) PrecoTotalProdutosTamanhoM from Produtos
where Tamanho='M'

SELECT MAX(Preco) ProdutoMaisCaroTamanhoM FROM Produtos
SELECT MAX(Preco) ProdutoMaisCaroTamanhoM FROM Produtos WHERE Tamanho='M'

SELECT MIN(Preco) ProdutoMaisBarato FROM Produtos
SELECT MIN(Preco) ProdutoMaisBaratoTamanhoM FROM Produtos WHERE Tamanho='M'

SELECT AVG(Preco) FROM Produtos

SELECT AVG(Preco) FROM Produtos 
WHERE Tamanho='M'

-- CONCATENAÇÃO utiliza o +

SELECT
	Nome + ', Cor: ' + Cor + ' - '+ Genero  NomeProduto
FROM Produtos

--DEIXAR TEXTO EM MAIUSCULO  UPPER E LOWER 

-- pode repetir colunas 
SELECT
	Nome + ', Cor: ' + Cor + ' - '+ Genero  NomeProdutoCompleto,
	UPPER(Nome) Nome,
	LOWER(Cor) Cor
FROM Produtos



-- ADICIONAR COLUNAS NO BANCO DE DADOS

ALTER TABLE Produtos 
ADD DataCadastro DATETIME2

-- APAGAR COLUNAS

--ALTER TABLE Produtos
--DROP COLUMN DataCadastro



UPDATE Produtos SET DataCadastro = GETDATE()

--FORMATAÇÃO DE DATA

SELECT
	Nome + ', Cor: ' + Cor + ' - '+ Genero  NomeProdutoCompleto,
	UPPER(Nome) Nome,
	LOWER(Cor) Cor,
	FORMAT(DataCadastro,'dd/MM/yyyy HH:mm') Data

FROM Produtos

-- AGRUPAMENTO DE DADOS



select 
	Tamanho,
	COUNT(*) Quantidade 
FROM Produtos
WHERE Tamanho <> '' -- tamanho é diferente de vazio != OU <> significa diferente
GROUP BY Tamanho  --- não pode deixar order by antes do group by vai da erro 
ORDER BY Quantidade DESC

--PRIMARY KEY CHAVE UNICA NA TABELA , GARANTIA QUE NÃO VAI REPETIR A ID
--FOREIGN KEY CHAVE QUE INDENTIFICA UM REGISTRO EXISTENTE EM OUTRA TABELA


select * from enderecos
select * from Clientes where Id = 4
select * from Enderecos where IdCliente = 4

CREATE TABLE Enderecos (

Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
IdCliente int NULL,
Rua varchar(255) NULL,
Bairro varchar(255) NULL,
Cidade varchar(255) NULL,
Estado char(2) NULL,

CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY (IdCliente) -- comando para referenciar uma tabela com outra
REFERENCES Clientes(Id) 

)

INSERT INTO Enderecos VALUES (4,'Rua Teste','Bairro Teste','Cidade teste','SP')


SELECT  
C.Nome,
C.Sobrenome,
C.Email,
E.Rua,
E.Bairro,
E.Cidade,
E.Estado
FROM Clientes C -- Alias de Clients para C
INNER JOIN Enderecos E ON c.Id = E.IdCliente
WHERE c.Id = 4



INSERT INTO Produtos (Nome,Preco,Tamanho,Genero)
VALUES ('Patrick1, H', 10, 'G', 'M')



SELECT * FROM Produtos

ALTER TABLE Produtos
-- deixando itens unicos . GARANTINDO QUE NÃO TENHA NOME DUPLICADO
ADD UNIQUE(Nome)


-- CONSTRAINT DO TIPO CHECK 
--ADD CONSTRAINT CHK_ColunaGenero  da um nome para CONSTRAINT

ALTER TABLE Produtos
ADD CONSTRAINT CHK_ColunaGenero CHECK(Genero = 'U' OR Genero = 'M' OR Genero = 'F')

-- ESTIPULAR VALOR PADRÃO NA TABELA
ALTER TABLE Produtos	
ADD DEFAULT GETDATE() FOR DataCadastro -- VALOR PADRÃO GETDATA PARA CADASTRO

--APAGANDO UMA CONSTRAINT 

--ALTER TABLE Produtos
--DROP CONSTRAINT  Nomedaconstraint

-- CRIAR UM PROCEDURE 
-- para criar a PROCEDURE, precisa criar variavel com os mesmo tipo da tabela
CREATE PROCEDURE InserirNovoProduto 
@Nome varchar(255),
@Cor varchar(50),
@Preco decimal,
@Tamanho varchar(5),
@Genero char(1)

AS

INSERT INTO Produtos (Nome,Cor,Preco,Tamanho,Genero)
VALUES (@Nome, @Cor, @Preco, @Tamanho, @Genero)


-- executando sua PROCEDURE

EXEC InserirNovoProduto -- COMANDO EXEC E NOME DA PROCEDURE
-- não é obrigado colocar as variaveis da PROCEDURE , EX @Nome
@Nome = 'NOVO PRODUTO PROCEDURE1',
@Cor = 'COLORIDO',
@Preco= 50,
@Tamanho = 'G',
@Genero = 'U'


--PROCEDURE OUTROS COMANDOS 

SELECT * FROM Produtos WHERE Tamanho = 'G'

CREATE PROCEDURE ObeterProdutosPorTamanho
@Tamanho varchar(5)

AS

SELECT * FROM Produtos WHERE Tamanho = 'G'

-- chamar procedure

EXEC ObeterProdutosPorTamanho 'G'

-- PROCEDURE SEM PARAMETROS
CREATE PROCEDURE ObterTodosProdutos
AS
SELECT * FROM Produtos

EXEC ObterTodosProdutos

-- FUNCTIONS PODE SER SALVO DIRETAMENTE NO SQL
-- ELA É MUITO PARECIDA COM UM PROCEDURE, A DIFERENÇA
--ELA É OBRIGADA A RETORNAR UM VALOR


SELECT
Nome,
Preco, --formatando o preco e calculando desconto
DBO.CalcularDesconto(Preco, 50)  PrecoComDesconto -- DBO.CalcularDesconto chamada da functor e os parametros da variavel
FROM Produtos WHERE Tamanho ='M'

CREATE FUNCTION CalcularDesconto(@Preco DECIMAL(13,2), @Porcentagem INT)
RETURNS  DECIMAL (13, 2) -- RETURNS É O TIPO DE RETORNO DA SUA FUNÇÃO NO CASO DO TIPO DECIMAL 

BEGIN
	RETURN @Preco - @Preco / 100 * @Porcentagem -- RETURN -- retorno da sua função
END