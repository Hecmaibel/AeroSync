using System;

public class Persona
{
	//ATRIBUTOS 

	public int idPersona { get; set; }
	public string nombrePersona { get; set; }
	public string apellidoPersona { get; set; }
	public string nacionalidadPersona {  get; set; }
	public int telefonoPersona { get; set; }
	public string direccionPersona {  get; set; }


	//CONSTRUCTOR VACÍO

	public Persona() { }

	//CONSTRUCTOR DE ATRIBUTOS

	public Persona(int idPersona, string nombrePersona, string apellidoPersona, string nacionalidadPersona, int telefonoPersona, string direccionPersona) 
	{ 
		this.idPersona = idPersona;
		this.nombrePersona = nombrePersona;
		this.apellidoPersona = apellidoPersona;
        this.nacionalidadPersona = nacionalidadPersona;
		this.telefonoPersona = telefonoPersona;
        this.direccionPersona = direccionPersona;
	}

	//MÉTODOS 

	public virtual void imprimirCredencial() 
	{
		Console.WriteLine($"ID: {idPersona}" +
			$"\n Nombres y apellidos: {nombrePersona} {apellidoPersona}" +
			$"\n Nacionalidad: {nacionalidadPersona}" +
			$"\n Teléfono: {telefonoPersona}" +
			$"\n Dirección: {direccionPersona}");
	}
	
}
