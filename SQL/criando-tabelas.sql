CREATE TABLE "User" (
	Id INT IDENTITY (1,1) NOT NULL,
	Password VARCHAR(255),
	Username VARCHAR(255),
	CreatedDate datetime,
	Profile VARCHAR(30),
	Status tinyint
);

INSERT INTO "User" (Username, Password) VALUES ('admin', '21232f297a57a5a743894a0e4a801fc3');

CREATE TABLE "ParceladoPre" (
	Id int IDENTITY (1,1) NOT NULL,
	nparcelas varchar(255),
	contractRef varchar(255),
	parcelaInicial float,
	indiceDataVencimento float,
	indiceDataCalcAmor float,
	valorNoVencimento float,
	subtotal float,
	amortizacao float,
	totalDevedor float,
	dataVencimento varchar(255),
	indiceDV varchar(255),
	indiceDCA varchar(255),
	dataCalcAmor varchar(255),
	valorPMTVincenda varchar(255),
	status varchar(255),
	ultimaAtualizacao varchar(255),
	encargosMonetarios varchar(255),
	infoParaCalculo varchar(255),
	tipoParcela varchar(255),
	infoParaAmortizacao varchar(max)
);

CREATE TABLE "Log" (
	Id int IDENTITY (1,1) NOT NULL,
	data datetime,
	usuario varchar(255),
	pasta varchar(255),
	contrato varchar(255),
	tipoContrato varchar(255),
	dataSimulacao varchar(255),
	infoTabela varchar(255),
	acao varchar(255),
	modulo varchar(255),
	recuperacaoJudicial bit
);


CREATE TABLE "Indice" (
	Id int IDENTITY (1,1) NOT NULL,
	data datetime,
	indice varchar(255),
	valor float
);


CREATE TABLE "ChequeEmpresarial" (
	Id int IDENTITY (1,1) NOT NULL,
	"dataBase" varchar(255),
	indiceDB varchar(255),
	indiceDataBase float,
	indiceBA varchar(255),
	indiceDataBaseAtual float,
	dataBaseAtual varchar(255),
	valorDevedor float,
	encargosMonetarios varchar(255),
	lancamentos float,
	tipoLancamento varchar(255),
	valorDevedorAtualizado float,
	contractRef varchar(255),
	ultimaAtualizacao varchar(255),
	infoParaCalculo varchar(max)
);
