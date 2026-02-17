using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.Application.DTOs.Usuario
{
    public class LoginResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public UsuarioDto? Usuario { get; set; }
    private LoginResult(bool success, string message, UsuarioDto? usuario)
        {
            Success = success;
            Message = message;
            Usuario = usuario;
        }

    public static LoginResult Ok(UsuarioDto usuario) => new(true, "OK", usuario);
    public static LoginResult Fail(string message) => new(false, message, null);
       
    }



}
