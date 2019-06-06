DROP TABLE comestiveis;
CREATE TABLE comestiveis(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	valor DECIMAL(10,2),
	data_vencimento DATETIME2,
	quantidade INT,
	marca VARCHAR(100)
);
DROP TABLE remedios;
CREATE TABLE remedios(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	generico BIT,
	categoria VARCHAR(100),
	solido BIT,
	contra_indicacoes VARCHAR(200),
	bula VARCHAR(500),
	faixa VARCHAR(50),
	precisa_receita BIT 
);

SELECT * FROM remedios;
