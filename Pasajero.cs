using System;

public class Pasajero : Persona
{

	//ATRIBUTOS

	public string nroVuelo { get; set; }
	public int nroAsiento { get; set; }
	public string origen { get; set; }
	public string destino { get; set; }

	//CONSTRUCTOR VACÍO
	public Pasajero() { }

	//CONSTRUCTOR DE ATRIBUTOS

	public Pasajero(string nroVuelo, int nroAsiento, string origen, string destino) 
	{
		this.nroVuelo = nroVuelo;
		this.nroAsiento = nroAsiento;
		this.origen = origen;
		this.destino= destino;

	}

    //MÉTODO (POLIMÓRFICO : OVERRIDE)

    public override void imprimirCredencial()
    {
        base.imprimirCredencial();
		Console.WriteLine($"\n Número del vuelo: {nroVuelo}" +
			$"\n Número del asiento: {nroAsiento}" +
			$"\n Origen: {origen}" +
			$"\n Destino: {destino}");
    }
	
}
