using StudySchedule.Application.DTOs.Usuario;
using StudySchedule.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace StudySchedule.Application.Services.Usuario
{
    internal class UsuarioService
    {
        private readonly UsuarioRepository _repo;
        public UsuarioService(UsuarioRepository repo)
        {
            _repo = repo;
        }

        public LoginResult Login(string usuario, string senha)
        {
            if(string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                return LoginResult.Fail("Informe usuário ou senha");
            }

            var user = _repo.Login(usuario.Trim(), senha);

            if(user == null){
                return LoginResult.Fail("Usuário ou senha inválido");
            }

            return LoginResult.Ok(user);

        }
    }
}
