using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using StudySchedule.Domain.Entities.Cliente;
using StudySchedule.Infrastructure.Data;

namespace StudySchedule.Infrastructure.Repositories.Cliente
{
    public class ClienteRepository
    {
        public int Inserir(ClienteDomain cliente)
        {
            return Db.Inserir<int>(
                "cadastro_cliente_inserir",
                SqlParam.In("@nome", SqlDbType.NVarChar, cliente.Nome),
                SqlParam.In("@data_nascimento", SqlDbType.Date, cliente.DataNascimento),
                SqlParam.In("@telefone", SqlDbType.VarChar, cliente.Telefone),
                SqlParam.In("sexo", SqlDbType.Char, cliente.Sexo),
                SqlParam.In("@observacao", SqlDbType.NVarChar, cliente.Observacao)
            );
        }
    }
}
