using System;

public class EmpleadoVendedor : Empleado
{
    public decimal Ventas { get; set; }

    public EmpleadoVendedor(string nombre, decimal sueldoBase, decimal ventas)
        : base(nombre, sueldoBase)
    {
        this.Ventas = ventas;
    }

    public override decimal CalcularSueldo()
    {
        return this.SueldoBase + (this.Ventas * 0.10m);
    }

    // MostrarInformacion() se hereda de Empleado sin sobrescribirlo.
}
