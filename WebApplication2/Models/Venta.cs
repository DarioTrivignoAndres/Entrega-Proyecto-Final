using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion
{
    public class Venta
    {
        private int _Id;
        private string _Comentarios;
        private int _IdVenta;
    }

    public Venta()
    {
        _Id = 0;
        _Comentarios = string.Empty;
        _IdVenta = 0;
        
    }

    public int Id
    {
        get
        {
            return this._Id;
        }
        set
        {
            this._Id = value;

        }
    }

    public string Comentarios
    {
        get
        {
            return this._Comentarios;

        }
        set
        {
            this._Comentarios = value;

        }
    }
    public int IdVenta
    {
        get
        {
            return this._IdVenta;
        }
        
        set
        {
            this._IdVenta = value;

        }
     }

    public Venta (int id, string Comentarios, int IdVenta)
    {
        this._id = id;
        this._Comentarios = Comentarios;
        this._IdVenta = IdVenta;
     }    



}
