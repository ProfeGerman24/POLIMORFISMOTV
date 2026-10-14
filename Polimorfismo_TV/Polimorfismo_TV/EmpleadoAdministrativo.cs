using System;

public  class EmpleadoAdministrativo : Empleado
{
    public decimal Bono { get; set; }

    public EmpleadoAdministrativo(string nombre, decimal sueldoBase, decimal bono)
        : base(nombre, sueldoBase)
    {
        this.Bono = bono;
    }

    public override decimal CalcularSueldo()
    {
        return this.SueldoBase + this.Bono;

    }

    public override void MostrarInformacion() // Especializando el comportamiento del metodo
    {
        base.MostrarInformacion();
        Console.WriteLine($"Bono percibido: ${this.Bono}");
    }

    public void GenerarReporte()
    {
        Console.WriteLine($"Generando reporte administrativo de {this.Nombre}");
    }


}



