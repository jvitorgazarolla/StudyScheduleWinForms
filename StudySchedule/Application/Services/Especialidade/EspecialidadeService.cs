using StudySchedule.Application.DTOs.Especialidade;
using StudySchedule.Infrastructure.Repositories.Especialidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Application.Services.Especialidade
{
    public class EspecialidadeService
    {
        private readonly EspecialidadeRepository _repo;

        public EspecialidadeService()
        {
            var repo = new EspecialidadeRepository();
            _repo = repo;
        }

        public List<EspecialidadeDto> Listar()
        {
            return _repo.Listar();
        }

        public List<EspecialidadeDto> Buscar(string? termo = null, bool? status = null)
        {
    
            return _repo.Buscar(termo, status);

        }
        public (bool ok, string msg) Editar(int? id, string? descricao = null, bool? status = null, bool? edit = null)
        {

            if (id <= 0)
            {
                return (false, "Especialidade inválida");
            }

            if (string.IsNullOrEmpty(descricao) && edit != true) {

                 return (false, "Descrição é obrigatória");              
            }

            _repo.Atualizar(id, descricao, status);
            return (true, "Especialidade atualizada com sucesso!");
        }
        public(bool ok, string msg, int? id) Inserir(string descricao, bool status)
        {
            descricao = (descricao ?? "").Trim();

            if (string.IsNullOrWhiteSpace(descricao))
            {
                return (false, "Descrição da Especialidade é obrigatório", null);
            }

            try
            {
                var id = _repo.Inserir(descricao, status);
                return (true, "Especialidade cadastrada ✅", id);

            }catch(Exception ex)
            {
                return (false, ex.Message, null);
            }
        }

        public (bool ok, string msg) Excluir(int id)
        {
            try
            {
                _repo.Excluir(id);
                return (true, "Especialidade Excluida com sucesso!");

            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
