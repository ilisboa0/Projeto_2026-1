USE PROJETO05;
GO
CREATE TABLE Aluno (
    id_aluno INT IDENTITY(1,1)    NOT NULL CONSTRAINT PK_Aluno PRIMARY KEY,
    nome VARCHAR(20) NOT NULL,
    sobrenome VARCHAR(50) NOT NULL,
    RG CHAR(9) NOT NULL,
    CPF CHAR(11) NOT NULL,
    Senha VARCHAR(20) NOT NULL,
    genero VARCHAR(1),
    CEP CHAR(8),
    email VARCHAR(50),
    telefone CHAR(20),
    Data_nascimento DATE
);
CREATE TABLE Professor (
    id_professor INT IDENTITY(1,1)    NOT NULL CONSTRAINT PK_Professor PRIMARY KEY,
    Nome VARCHAR(20),
    Sobrenome VARCHAR(50),
    RG CHAR(9),
    CPF CHAR(11),
    Data_nascimento DATE,
    genero VARCHAR(1),
    CEP CHAR(8),
    email VARCHAR(50),
    telefone CHAR(20),
    Educação VARCHAR(100),
    Disciplina VARCHAR(100),
    Senha VARCHAR(20)
);
CREATE TABLE Curso (
    Id_Curso INT IDENTITY(1,1)    NOT NULL CONSTRAINT PK_Curso PRIMARY KEY,
    Nome VARCHAR(50),
    carga_horaria INT,
    frequencia_obrigatoria INT,
    id_Professor INT,
    FOREIGN KEY (id_Professor) REFERENCES Professor(id_professor)
);
CREATE TABLE Matricula (
    Id_Matricula INT IDENTITY(1,1)    NOT NULL CONSTRAINT PK_Matricula PRIMARY KEY,
    Id_Aluno INT,
    Id_Curso INT,
    id_Professor INT,
    Status VARCHAR(20),
    FOREIGN KEY (Id_Aluno) REFERENCES Aluno(id_aluno),
    FOREIGN KEY (Id_Curso) REFERENCES Curso(Id_Curso),
    FOREIGN KEY (id_Professor) REFERENCES Professor(id_professor)
);
CREATE TABLE Notas_Frequencia (
    Id_Matricula INT,
    nome_curso VARCHAR(50),
    Carga_Horaria INT,
    frequencia_obrigatoria INT,
    Horas_assistidas INT,
    Aproveitamento INT,
    FOREIGN KEY (Id_Matricula) REFERENCES Matricula(Id_Matricula)
);
CREATE TABLE Materiais (
    Id_Material INT IDENTITY(1,1)    NOT NULL CONSTRAINT PK_Materiais PRIMARY KEY,
    Id_Curso INT,
    Nome_do_Material VARCHAR(100),
    Horas INT,
    arquivo_Material VARBINARY(MAX),
    Arquivo_Atividade VARBINARY(MAX),
    FOREIGN KEY (Id_Curso) REFERENCES Curso(Id_Curso)
);
CREATE TABLE Atendente (
    Id_Atendente INT IDENTITY(1,1)    NOT NULL CONSTRAINT PK_Atendente PRIMARY KEY,
    Nome VARCHAR(20),
    Sobrenome VARCHAR(50),
    RG CHAR(9),
    CPF CHAR(11),
    Data_nascimento DATE,
    genero VARCHAR(1),
    CEP CHAR(8),
    email VARCHAR(50),
    telefone CHAR(20),
    Senha VARCHAR(20)
);
CREATE TABLE Atendimento_Secretaria (
    Id_Atendimento INT IDENTITY(1,1)    NOT NULL CONSTRAINT PK_Atendimento_Secretaria PRIMARY KEY,
    Id_Atendente INT,
    Id_Aluno INT,
    Tipo_de_Solicitação VARCHAR(50),
    Descrição_pedido VARCHAR(255),
    Arquivos VARBINARY(MAX),
    Status_do_atendimento VARCHAR(40),
    FOREIGN KEY (Id_Atendente) REFERENCES Atendente(Id_Atendente),
    FOREIGN KEY (Id_Aluno) REFERENCES Aluno(id_aluno)
);
INSERT INTO Aluno VALUES
('Ana','Silva','123456789','11122233344','senha1','F','01001000','ana@email.com','11999990001','2005-02-10'),
('Bruno','Santos','223456789','22233344455','senha2','M','02002000','bruno@email.com','11999990002','2002-4-04'),
('Carla','Oliveira','323456789','33344455566','senha3','F','03003000','carla@email.com','11999990003','2015-08-10'),
('Daniel','Pereira','423456789','44455566677','senha4','M','04004000','daniel@email.com','11999990004','2008-08-18'),
('Eduarda','Costa','523456789','55566677788','senha5','F','05005000','eduarda@email.com','11999990005','2003-03-01');
INSERT INTO Professor VALUES
('Marcos','Almeida','987654321','99988877766','1980-05-10','M','06006000','marcos@escola.com','11988880001','Ensino Fundamental I','Matemática','prof1'),
('Patrícia','Lima','887654321','88877766655','1982-07-15','F','07007000','patricia@escola.com','11988880002','Ensino Fundamental II','Português','prof2'),
('Roberto','Souza','787654321','77766655544','1975-09-20','M','08008000','roberto@escola.com','11988880003','Ensino Médio','História','prof3'),
('Fernanda','Rocha','687654321','66655544433','1985-11-25','F','09009000','fernanda@escola.com','11988880004','Educação Infantil','Ciências','prof4'),
('Carlos','Pereira','587654321','55544433322','1978-03-30','M','10010000','carlos@escola.com','11988880005','Ensino Fundamental II','Geografia','prof5');
INSERT INTO Curso VALUES
('Matemática Básica',80,60,1),
('Português',90,70,2),
('História Geral',70,50,3),
('Ciências',85,65,4),
('Geografia',75,55,5);
INSERT INTO Matricula VALUES
(1,1,1,'Ativo'),
(2,2,2,'Ativo'),
(3,3,3,'Ativo'),
(4,4,4,'Trancado'),
(5,5,5,'Ativo');
INSERT INTO Notas_Frequencia VALUES
(1,'Matemática Básica',80,60,70,85),
(2,'Português',90,70,80,90),
(3,'História Geral',70,50,55,75),
(4,'Ciências',85,65,60,70),
(5,'Geografia',75,55,65,88);
INSERT INTO Materiais VALUES
(1,'Apostila Matemática',10,NULL,NULL),
(2,'Livro Português',12,NULL,NULL),
(3,'Slides História',8,NULL,NULL),
(4,'PDF Ciências',9,NULL,NULL),
(5,'Mapa Geografia',7,NULL,NULL);
INSERT INTO Atendente VALUES
('Lucas','Mendes','111111111','12312312312','1995-02-10','M','11111000','lucas@secretaria.com','11977770001','atend1'),
('Mariana','Costa','222222222','23423423423','1996-04-12','F','22222000','mariana@secretaria.com','11977770002','atend2'),
('Rafael','Pereira','333333333','34534534534','1994-06-15','M','33333000','rafael@secretaria.com','11977770003','atend3'),
('Beatriz','Alves','444444444','45645645645','1997-08-20','F','44444000','beatriz@secretaria.com','11977770004','atend4'),
('Thiago','Souza','555555555','56756756756','1993-10-25','M','55555000','thiago@secretaria.com','11977770005','atend5');
INSERT INTO Atendimento_Secretaria VALUES
(1,1,'Matrícula','Solicitação de matrícula',NULL,'Concluído'),
(2,2,'Declaração','Pedido de declaração',NULL,'Em análise'),
(3,3,'Transferência','Solicitação de transferência',NULL,'Pendente'),
(4,4,'Histórico','Pedido de histórico',NULL,'Concluído'),
(5,5,'Certificado','Solicitação de certificado',NULL,'Em andamento');