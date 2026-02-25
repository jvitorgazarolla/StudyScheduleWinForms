using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using StudySchedule.Infrastructure.Data;

namespace StudySchedule.Infrastructure.Repositories.Cliente
{
    public class ClienteRepository
    {
        public int Inserir(string nome, DateTime data_nascimento, string telefone, string sexo, string? observacao = null)
        {
            return Db.Inserir<int>(
                "cadastro_cliente_inserir",
                SqlParam.In("@nome", SqlDbType.NVarChar, nome),
                SqlParam.In("@data_nascimento", SqlDbType.Date, data_nascimento),
                SqlParam.In("@telefone", SqlDbType.VarChar, telefone),
                SqlParam.In("sexo", SqlDbType.Char, sexo),
                SqlParam.In("@observacao", SqlDbType.NVarChar, observacao)
            );
        }
    }
}
