// See https://aka.ms/new-console-template for more information


Console.WriteLine("----GESTIÓN DE PERSONAL Y PASAJEROS----");
Console.WriteLine("1. Empleado Aéreo");
Console.WriteLine("2. Pasajero");
Console.WriteLine("3. Otro");
Console.WriteLine("Digite la opción que desee: ");
int opcion = int.Parse(Console.ReadLine());

if (opcion == 1)
{
    //PEDIMOS LOS DATOS

    Console.WriteLine("\nEMPLEADO AÉREO");
    EmpleadoAereo emp = new EmpleadoAereo();

    Console.WriteLine("Digite su id: ");
    emp.idPersona = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese sus nombres: ");
    emp.nombrePersona = Console.ReadLine();
    Console.WriteLine("Ingrese sus apellidos: ");
    emp.apellidoPersona = Console.ReadLine();
    Console.WriteLine("Ingrese su nacionaliad: ");
    emp.nacionalidadPersona = Console.ReadLine();
    Console.WriteLine("Digite su número de teléfono: ");
    emp.telefonoPersona = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su dirección: ");
    emp.direccionPersona = Console.ReadLine();
    Console.WriteLine("Ingrese su departamento de trabajo: ");
    emp.departamentoEmpleado = Console.ReadLine();
    Console.WriteLine("Turno laboral: ");
    emp.turnoEmpleado = Console.ReadLine();

    //IMPRIMIMOS LOS DATOS DEL EMPLEADO
    emp.imprimirCredencial();
}

else if (opcion == 2)
{
    Console.WriteLine("\nPASAJERO");
    Pasajero pasajero = new Pasajero();

    // PEDIMOS LOS DATOS 

    Console.WriteLine("Digite su id: ");
    pasajero.idPersona = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese sus nombres: ");
    pasajero.nombrePersona = Console.ReadLine();
    Console.WriteLine("Ingrese sus apellidos: ");
    pasajero.apellidoPersona = Console.ReadLine();
    Console.WriteLine("Ingrese su nacionaliad: ");
    pasajero.nacionalidadPersona = Console.ReadLine();
    Console.WriteLine("Digite su número de teléfono: ");
    pasajero.telefonoPersona = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su dirección: ");
    pasajero.direccionPersona = Console.ReadLine();
    Console.WriteLine("Ingrese el número del vuelo: ");
    pasajero.nroVuelo = Console.ReadLine();
    Console.WriteLine("Ingrese el número del asiento: ");
    pasajero.nroAsiento = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el origen: ");
    pasajero.origen = Console.ReadLine();
    Console.WriteLine("Ingrese el destino: ");
    pasajero.destino = Console.ReadLine();

    //IMPRIMIMOS LOS DATOS DEL PASAJERO
    pasajero.imprimirCredencial();
}
else
{

    Persona persona = new Persona();

    Console.WriteLine("Digite su id: ");
    persona.idPersona = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese sus nombres: ");
    persona.nombrePersona = Console.ReadLine();
    Console.WriteLine("Ingrese sus apellidos: ");
    persona.apellidoPersona = Console.ReadLine();
    Console.WriteLine("Ingrese su nacionalidad: ");
    persona.nacionalidadPersona = Console.ReadLine();
    Console.WriteLine("Digite su númerod e teléfono: ");
    persona.telefonoPersona = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese su dirección: ");
    persona.direccionPersona = Console.ReadLine();

    //IMPRIMIMOS LOS DATOS

    persona.imprimirCredencial();


}
   

