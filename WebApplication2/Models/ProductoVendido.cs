using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion
{
    public class ProductoVendido
    {
        private int _Id;
        private int _IdProducto;
        private int _Stock;
        private int _IdVenta;
    }

    public ProductoVendido()
    {
        _Id = 0;
        _IdProducto = 0;
        _Stock = 0;
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

    public int IdProducto
    {
        get
        {
            return this._IdProducto;

        }
        set
        {
            this._IdProducto = value;

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



}









