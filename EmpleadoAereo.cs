using System;

public class EmpleadoAereo : Persona
{
	//ATRIBUTOS

	public string departamentoEmpleado {  get; set; }
	public string turnoEmpleado { get; set; }

	//CONSTRUCTOR VACÍO

	public EmpleadoAereo() { }

	//CONSTRUCTOR DE ATRIBUTOS

	public EmpleadoAereo(string departamentoEmpleado, string turnoEmpleado) 
	{
		this.departamentoEmpleado = departamentoEmpleado;
		this.turnoEmpleado = turnoEmpleado;
	}

    //MÉTODOS (POLIMÓFICOS : OVERRIDE)

    public override void imprimirCredencial()
    {
        base.imprimirCredencial();
		Console.WriteLine($"\n Departamento: {departamentoEmpleado}" +
			$"\n Turno del empleado: {turnoEmpleado}");
    }
	
}
