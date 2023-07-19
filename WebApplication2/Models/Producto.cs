using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion
{
    public class Producto
    {
        private int _Id;
        private string _Descripcion;
        private double _Costo;
        private double _PrecioVenta;
        private int _Stock;
        private int _IdUsuario;
    }

    public Producto()
    {
        _Id = 0;
        _Descripcion = string.Empty;
        _Costo = 0;
        _PrecioVenta = 0;
        _Stock = 0;
        _IdUsuario = 0;
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

    public string Descripcion
    {
        get
        {
            return this._Descripcion;

        }
        set
        {
            this._Descripcion = value;

        }
    }
    public double Costo
    {
        get
        {
            return this._Costo;

        }
        set
        {
            this._Costo = value;

        }

    }

    public double PrecioVenta
    {
        get
        {
            return this._PrecioVenta;

        }
        set
        {
            this._PrecioVenta = value;

        }

    }

    public int Stock
    {
        get
        {
            return this._Stock;

        }
        set
        {
            this._Stock = value;

        }
    }

    public int IdUsuario
    {
        get
        {
            return this._IdUsuario;

        }
        set
        {
            this._IdUsuario = value;

        }
    }

    public Producto (int Id, string Descripcion, double Costo, double PrecioVenta, int Stock, string IdUsuario)
    {
        this._id = Id;
        this._Descripcion = Descripcion;
        this._Costo = Costo;
        this._PrecioVenta = PrecioVenta;
        this._Stock = Stock;
        this._IdUsuario = IdUsuario;
    }




}
