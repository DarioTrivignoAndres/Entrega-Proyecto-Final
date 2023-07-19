using SistemaGestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion
{
    public class Usuario
    {
        private int _id;    
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contrasenia;
        private string _mail;
    }

    public Usuario()
    {
        _id = 0;
        _nombre = string.Empty;
        _apellido = string.Empty;
        _nombreUsuario = string.Empty;
        _contrasenia = string.Empty;
        _mail = string.Empty;
    }

    public int id
    {
        get
        {
            return this._id;  
        }    
        set
        {
            this._id = value; 

        }
    }

    public string nombre
    {
        get
        {
            return this._nombre; 

        }
        set
        {
            this._nombre = value;

        }
     }  
        public string apellido
        {
        get
        {
            return this._apellido;

        }
        set
        {
            this._apellido = value;

        }

        }

    public string nombreUsuario
    {
        get
        {
            return this._nombreUsuario;

        }
        set
        {
            this._nombreUsuario = value;

        }

    }

    public string contrasenia
    {
        get
        {
            return this._contrasenia;

        }
        set
        {
            this._contrasenia = value;

        }
    }

    public string mail
    {
        get
        {
            return this._mail;

        }
        set
        {
            this._mail = value;

        }
    }

    public Usuario (int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
    {
        this._id = id;
        this._nombre = nombre;
        this._apellido = apellido;
        this._nombreUsuario = nombreUsuario;
        this._contrasenia = contrasenia;
        this._mail = mail;
    }

}

public class IniciarSesion ()
{
    private string nombreUsuario;
    private string contrasenia;
}

public IniciarSesion()
{
    nombreUsuario = string.Empty;
    contrasenia = string.Empty;
}

public IniciarSesion (string nombreUsuario, string contrasenia)
{
    this.nombreUsuario = nombreUsuario;
    this.contrasenia = contrasenia;
} 