Descrição do projeto
Arquitetura em camadas
Uso de SQL Server + Stored Procedures
Padrão Service + Repository + DTO


Estrutura de Dependências

Especialidades: Devem ser cadastradas previamente (ex: Corte + Barba, Corte, Sobrancelha + Corte).

Profissionais: O cadastro de um profissional exige o vínculo com pelo menos uma Especialidade existente.

Jornada: O registro de uma jornada  exige a existência prévia de um Profissional e sua respectiva Especialidade.

Regras de Cadastro
1. Profissionais e Especialidades
Não é permitido cadastrar um profissional sem uma especialidade vinculada.

2. Jornada
Para cadastrar uma nova jornada, os seguintes requisitos devem ser atendidos:
Vínculo Duplo: É obrigatório informar o Profissional e Especialidade.


Backend: C# .NET 10
Banco de Dados: SQL Server 
