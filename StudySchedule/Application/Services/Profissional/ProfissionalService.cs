using Microsoft.Data.SqlClient;
using StudySchedule.Application.DTOs.Profissional;
using StudySchedule.Infrastructure.Repositories.Profissional;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Application.Services.Profissional
{
    public class ProfissionalService
    {
        private readonly ProfissionalRepository _repo;
        public ProfissionalService(ProfissionalRepository repo)
        {
            _repo = repo;
        }

        public (bool ok, string msg, int? id) Inserir (string nome, string telefone, bool status, int especialidadeId)
        {
            nome =  (nome ?? "").Trim();
            telefone = (telefone ?? "" ).Trim();

            if (string.IsNullOrEmpty(nome) ) {
                return (false, "Informe o nome", null);
           
            }
            if (string.IsNullOrEmpty(telefone))
            {
                return (false, "Informe o telefone", null);

            }

            try
            {
                var id = _repo.Inserir(nome, telefone, status, especialidadeId);
                return (true, "Profissional cadastrado!", id);
            }catch(Exception ex)
            {
                return (false, ex.Message, null);
            }

            return (true, "Ok", 1);

        }
        public List<ProfissionalDto> Buscar(string? termo = null, bool? status = null)
        {
            return _repo.Buscar(termo, status);
        }
        public (bool ok, string msg) Editar(int? id = null, string? descricao = null, string? telefone = null, bool? status = null, int? especialidadeId = null, bool? desativar = null)
        {
            if (string.IsNullOrEmpty(descricao) && desativar != true)
            {
                return (false, "Informe o nome");

            }
            if (string.IsNullOrEmpty(telefone) && desativar != true)
            {
                return (false, "Informe o telefone");

            }

            _repo.Editar(id, descricao, telefone, status, especialidadeId);
            if(desativar == true)
            {
                return (true, "Profissional Desativado com sucesso!");
            }
            else
            {
                return (true, "Profissional atualizado com sucesso!");
            }
            
        }

        public (bool ok, string msg)Excluir(int id){
            try
            {
                _repo.Excluir(id);
                return (true, "Usuário excluido com sucesso!");

            }catch(SqlException ex) when(ex.Number == 547){
                string tabela = "registro relacionado";

                var match = System.Text.RegularExpressions.Regex.Match(
                    ex.Message,
                    @"table\s+""dbo\.([^""]+)"""
                );

                if (match.Success)
                    tabela = match.Groups[1].Value;

                return (false, $"Não é possível excluir o profissional. Existe vínculo com especialidade ou agenda");
            }
                

        }
    }

   
}
