create database pizzaria_ze;

use pizzaria_ze;

CREATE TABLE tb_enderecos (
    id_endereco INT PRIMARY KEY auto_increment,
    logradouro VARCHAR(100),
    cidade_id INT,
    cep VARCHAR(8) UNIQUE
);

CREATE TABLE cad_cidades (
    id_cidade INT PRIMARY KEY auto_increment,
    nome_cidade VARCHAR(50),
    uf_id INT
);

CREATE TABLE cad_uf (
    id_uf INT PRIMARY KEY auto_increment,
    nome_uf VARCHAR(30),
    pais_id INT
);

CREATE TABLE tb_funcionarios (
    id_funcionario INT PRIMARY KEY auto_increment,
    nome_funcionario VARCHAR(45),
    cpf VARCHAR(11),
    matricula VARCHAR(15),
    senha VARCHAR(256),
    grupo VARCHAR(25),
    motorista VARCHAR(15),
    validade_motorista DATETIME,
    observacao VARCHAR(45),
    telefone VARCHAR(11),
    email VARCHAR(45),
    endereco_id INT,
    numero VARCHAR(10),
    complemento VARCHAR(45),
    UNIQUE (matricula, cpf, motorista)
);

CREATE TABLE tb_clientes (
    id_cliente INT PRIMARY KEY auto_increment,
    nome_cliente VARCHAR(50),
    cpf VARCHAR(11) UNIQUE,
    telefone VARCHAR(11),
    email VARCHAR(45),
    endereco_id INT,
    numero VARCHAR(10),
    complemento VARCHAR(45)
);

CREATE TABLE cad_ingredientes (
    id_ingrediente INT PRIMARY KEY auto_increment,
    descricao_ingrediente VARCHAR(100) UNIQUE
);
CREATE TABLE tb_sabores (
    id_sabor INT PRIMARY KEY auto_increment,
    descricao_sabor VARCHAR(50) UNIQUE,
    foto blob,
    categoria VARCHAR(15),
    tipo VARCHAR(15)
);

CREATE TABLE itens_sabores (
    id_itens_sabor INT PRIMARY KEY auto_increment,
    ingrediente_id INT,
    sabor_id INT
);
CREATE TABLE cad_paises (
    id_pais INT PRIMARY KEY auto_increment,
    nome_pais VARCHAR(45)
);

CREATE TABLE cad_produtos (
    id_produto INT PRIMARY KEY auto_increment,
    descricao_produto VARCHAR(45),
    valor DECIMAL(11,2),
    tipo VARCHAR(18),
    medida_unitaria VARCHAR(20)
);

------------------------
CREATE TABLE lista_produtos (
    id_lista_produtos INT PRIMARY KEY auto_increment,
	pedido_id INT NOT NULL,
    produto_id INT NOT NULL,
    constraint FK_produto_id foreign key (produto_id) references cad_produtos(id_produto),
	constraint FK_pedido_id foreign key (pedido_id) references tb_pedidos(id_pedido)
);

CREATE TABLE tb_pizza (
	id_pizza INT PRIMARY KEY auto_increment,
    tamanho VARCHAR(15)NOT NULL,
    categoria VARCHAR(15)NOT NULL,
    com_borda BIT NOT NULL,
    valor_borda DECIMAL(11,2),
	valor_total DECIMAL(11,2) NOT NULL,
	sabor_borda varchar(15)
);
CREATE TABLE sabores_pizza (
	id_sabores_pizza INT PRIMARY KEY auto_increment,
	sabor_id INT NOT NULL,
    pizza_id INT NOT NULL,
    CONSTRAINT FK_sabor_id FOREIGN KEY (sabor_id) REFERENCES tb_sabores(id_sabor),
    CONSTRAINT FK_pizza_id FOREIGN KEY (pizza_id) REFERENCES tb_pizza(id_pizza)
);
CREATE TABLE lista_pizzas (
	id_lista_pizza INT PRIMARY KEY auto_increment,
	pizza_id INT NOT NULL,
	pedido_id INT NOT NULL,
    CONSTRAINT FK_lp_pizza_id FOREIGN KEY (pizza_id) REFERENCES tb_pizza(id_pizza),
	constraint FK_lp_pedido_id foreign key (pedido_id) references tb_pedidos(id_pedido)
);

CREATE TABLE tb_pedidos (
    id_pedido INT PRIMARY KEY auto_increment,
    cliente_id INT NOT NULL,
    funcionario_id INT,
    status VARCHAR(45) NOT NULL,
    entrega BIT NOT NULL,
    pago BIT NOT NULL,
    valor_total DECIMAL(11,2) NOT NULL,
    data_pedido DATETIME DEFAULT current_timestamp() NOT NULL,
    CONSTRAINT FK_cliente_id foreign key (cliente_id) references tb_clientes(id_cliente),
    CONSTRAINT FK_funcionario_id foreign key (funcionario_id) references tb_funcionarios(id_funcionario)
);

CREATE TABLE cad_pagamentos (
    id_pagamento INT PRIMARY KEY auto_increment,
    descricao VARCHAR(45) NOT NULL,
    pedido_id INT NOT NULL,
    constraint FK_pag_pedido_id foreign key (pedido_id) references tb_pedidos(id_pedido)
);

------------------------
 
ALTER TABLE tb_enderecos ADD CONSTRAINT FK_endereco_cidade
    FOREIGN KEY (cidade_id)
    REFERENCES cad_cidades (id_cidade);
 
ALTER TABLE cad_cidades ADD CONSTRAINT FK_cidade_uf
    FOREIGN KEY (uf_id)
    REFERENCES cad_uf (id_uf);
 
ALTER TABLE cad_uf ADD CONSTRAINT FK_uf_pais
    FOREIGN KEY (pais_id)
    REFERENCES cad_paises (id_pais);
 
ALTER TABLE tb_funcionarios ADD CONSTRAINT FK_funcionario_endereco
    FOREIGN KEY (endereco_id)
    REFERENCES tb_enderecos (id_endereco);
 
ALTER TABLE tb_clientes ADD CONSTRAINT FK_cliente_endereco
    FOREIGN KEY (endereco_id)
    REFERENCES tb_enderecos (id_endereco);
 
ALTER TABLE itens_sabores ADD CONSTRAINT FK_itens_sabores
    FOREIGN KEY (ingrediente_id)
    REFERENCES cad_ingredientes (id_ingrediente);
 
ALTER TABLE itens_sabores ADD CONSTRAINT FK_iten_sabor
    FOREIGN KEY (sabor_id)
    REFERENCES tb_sabores (id_sabor);
    
ALTER TABLE tb_enderecos ADD bairro VARCHAR(50);

INSERT INTO cad_paises (nome_pais) VALUES ('Brasil');
INSERT INTO cad_uf (nome_uf, pais_id) VALUES ('SC', '1');
INSERT INTO cad_uf (nome_uf, pais_id) VALUES ('PR', '1');
INSERT INTO cad_uf (nome_uf, pais_id) VALUES ('RS', '1');
INSERT INTO cad_cidades (nome_cidade, uf_id) VALUES ('Lages', '1');
INSERT INTO cad_cidades (nome_cidade, uf_id) VALUES ('Floripa', '1');
INSERT INTO cad_cidades (nome_cidade, uf_id) VALUES ('Curitiba', '2');
INSERT INTO cad_cidades (nome_cidade, uf_id) VALUES ('Vacaria', '3');
INSERT INTO cad_cidades (nome_cidade, uf_id) VALUES ('Rio do Sul', '1');
INSERT INTO tb_enderecos (cep, logradouro, bairro, cidade_id) VALUES ('88500001', 'rua 1 lages', 'bairro 1', '1');
INSERT INTO tb_enderecos (cep, logradouro, bairro, cidade_id) VALUES ('88500002', 'rua 2 lages', 'bairro 2', '1');
INSERT INTO tb_enderecos (cep, logradouro, bairro, cidade_id) VALUES ('88500003', 'rua 3 lages', 'bairro 3', '1');
INSERT INTO tb_enderecos (cep, logradouro, bairro, cidade_id) VALUES ('88500004', 'rua 4 floripa', 'bairro 4', '2');
INSERT INTO tb_enderecos (cep, logradouro, bairro, cidade_id) VALUES ('88500005', 'rua 5 floripa', 'bairro 5', '2');
INSERT INTO tb_enderecos (cep, logradouro, bairro, cidade_id) VALUES ('88500006', 'rua 5 curitiba', 'bairro 6', '3');
INSERT INTO tb_enderecos (cep, logradouro, bairro, cidade_id) VALUES ('88500007', 'rua 7 vacaria', 'bairro 7', '4');
INSERT INTO tb_enderecos (cep, logradouro, bairro, cidade_id) VALUES ('88500008', 'rua 8 vacaria', 'bairro 8', '4');
INSERT INTO tb_enderecos (cep, logradouro, bairro, cidade_id) VALUES ('88500009', 'rua 9 rio do sul', 'bairro 9', '5');
use pizzaria_ze;

SELECT id_produto AS ID, descricao_produto AS Descrição, valor AS Valor, tipo AS 'Tipo Produto', medida_unitaria AS ML
	FROM cad_produtos AS p
    INNER JOIN lista_produtos lp on p.id_produto = lp.produto_id
    INNER JOIN tb_pedidos pe on lp.pedido_id = pe.id_pedido
    WHERE pe.id_pedido = 2
	ORDER BY p.descricao_produto;

SELECT s.id_sabor AS ID, s.descricao_sabor AS Nome, s.foto AS Foto, s.categoria AS Categoria, s.tipo AS Tipo,
	(SELECT GROUP_CONCAT(i.descricao_ingrediente SEPARATOR ', ') 
    FROM itens_sabores AS iss, cad_ingredientes i 
    WHERE iss.sabor_id = s.id_sabor AND i.id_ingrediente = iss.ingrediente_id ) AS Ingredientes 
    FROM tb_sabores AS s 
    INNER JOIN sabores_pizza sp on sp.sabor_id = s.id_sabor
    INNER JOIN tb_pizza pz on sp.
    INNER JOIN lista_pizzas lp on sp.
    INNER JOIN tb_pedidos pe on lp.pedido_id = pe.id_pedido
    WHERE pe.id_pedido = 2
	ORDER BY s.descricao_sabor;
    
SELECT * FROM lista_produtos;
SELECT * FROM tb_valor;

SELECT GROUP_CONCAT(s.descricao_sabor SEPARATOR ', ') AS Sabores
	FROM tb_sabores s, sabores_pizza sp, tb_pizza pz 
    WHERE s.id_sabor = sp.sabores_id AND pz.id_pizza = sp.pizza_id;