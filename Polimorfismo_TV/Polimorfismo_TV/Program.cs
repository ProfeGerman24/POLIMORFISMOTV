namespace Polimorfismo_TV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            EmpleadoAdministrativo e1 = new EmpleadoAdministrativo("Juan", 1000m, 150);
            EmpleadoVendedor e2 = new EmpleadoVendedor("Ana", 1500, 1000);
            EmpleadoAdministrativo e3 = new EmpleadoAdministrativo("Rocio", 2000m, 600);
            EmpleadoVendedor e4 = new EmpleadoVendedor("Martin", 1250, 5000);

            empleados.Add(e1);
            empleados.Add(e2);
            empleados.Add(e3);
            empleados.Add(e4);


            foreach(Empleado e in empleados)
            {
                
                if(e is EmpleadoAdministrativo)
                {
                    ((EmpleadoAdministrativo)e).GenerarReporte();
                    
                }

               

                e.MostrarInformacion();

            }





            // TODO: Crear y agregar a Ana, Pedro y Laura con los datos del enunciado.

            // TODO: Recorrer la lista con foreach y llamar a MostrarInformacion().

            // TODO: Comprobar si cada empleado es EmpleadoAdministrativo.
            // Si lo es, convertirlo explícitamente y llamar a GenerarReporte().

            // AMPLIACIÓN: Agregar un EmpleadoGerente y comprobar el polimorfismo.
        }
    }
}
