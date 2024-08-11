CREATE TABLE Contas (
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR(100),
    Valor DECIMAL(10, 2),
    DataVencimento DATE,
    DataPagamento DATE,
    Pago BOOLEAN
);
