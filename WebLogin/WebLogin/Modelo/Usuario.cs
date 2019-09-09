using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class Usuario
    {
       
            public int idusuario { get; set; }
            public string usuario { get; set; }
            public string senha { get; set; }
            public int idusuarioperfil { get; set; }

            public Usuario()
            {
                this.idusuario = 0;
                this.usuario = "";
                this.senha = "";
                this.idusuarioperfil = 0;

            }
            public Usuario(int idUsario, string usuario, string senha, int idUsuarioPerfil)
            {
                this.idusuario = idUsario;
                this.usuario = usuario;
                this.senha = senha;
                this.idusuarioperfil = idUsuarioPerfil;


            }
       
    }
}