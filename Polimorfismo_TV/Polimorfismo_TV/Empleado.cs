using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public abstract class Empleado
{
    public string Nombre { get; set; }
    public decimal SueldoBase { get; set; }

    public Empleado(string nombre, decimal sueldoBase)
    {
        this.Nombre = nombre;
        this.SueldoBase = sueldoBase;
    }

    public abstract decimal CalcularSueldo();

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Empleado: {this.Nombre}");
        Console.WriteLine($"Sueldo final: ${this.CalcularSueldo()} ");
    }
}
