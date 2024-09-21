using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuar_motos
{
    internal class Moto
    {
        public string marca { get; private set; }
        public int modelo { get; private set; }
        public int valorFabricacion { get; private set; }

        public Moto(int valorFabricacion, int modelo, string marca)
        {
            this.valorFabricacion = valorFabricacion;
            this.modelo = modelo;
            this.marca = marca;
        }

        public double calcularDepreciacionLineal(int añoACalcular, int vidaUtil)
        {
            
            return valorFabricacion - (valorFabricacion * (añoACalcular - modelo) / vidaUtil);
        }

        public double calcularDepreciacionAnual(int añoACalcular, double tasaDepreciacion)
        {
            return this.valorFabricacion * Math.Pow(1 - tasaDepreciacion, añoACalcular - this.modelo) ;
        }

        public string verDescripcion()
        {
            return $"Marca: {this.marca}, Modelo: {this.modelo}, Valor Fabricación: ${this.valorFabricacion:0.00}";
        }
    }

}
