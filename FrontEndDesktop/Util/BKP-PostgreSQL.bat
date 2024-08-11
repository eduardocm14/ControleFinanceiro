@echo off
REM Configurações do banco de dados
set PGUSER=postgres
set PGPASSWORD=root
set PGDATABASE=ControleFinanceiro
set PGHOST=localhost
set PGPORT=5432

REM Caminho onde o pg_dump está localizado (ajuste conforme a instalação)
set PGBIN="C:\Program Files\PostgreSQL\16\bin"

REM Caminho onde o backup será salvo
set BACKUPDIR="C:\Eduardo\.NET\ControleFinanceiroEntityPostgreSQL\Backups"

REM Obter a data e hora atual no formato yyyy-mm-dd_HH-MM-SS
for /f "tokens=1-4 delims=/ " %%A in ('date /t') do (
    set CurDate=%%D%%B-%%A
)
for /f "tokens=1-2 delims=:. " %%A in ('time /t') do (
    set CurTime=%%A-%%B
)

REM Nome do arquivo de backup com data e hora
set BACKUPFILE=%BACKUPDIR%\backup_%PGDATABASE%_%CurDate%_%CurTime%.sql

REM Cria o diretório de backup se não existir
if not exist %BACKUPDIR% mkdir %BACKUPDIR%

REM Executa o pg_dump para realizar o backup
%PGBIN%\pg_dump -h %PGHOST% -p %PGPORT% -U %PGUSER% -F c -b -v -f %BACKUPFILE% %PGDATABASE%

REM Verifica se o backup foi bem-sucedido
if %errorlevel% neq 0 (
    echo Backup falhou.
) else (
    echo Backup realizado com sucesso: %BACKUPFILE%
)

REM Limpa a variável de senha por segurança
set PGPASSWORD=
