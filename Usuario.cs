using System;

public class Usuario
{
	// ATRIBUTOS 


	public int idUsuario { get; set; }
	public string nombreUsuario { get; set; }
	public string emailUsuario { get; set; }
	public string rolUsuario { get; set; }
	public string nacionalidadUsuario { get; set; }
	public string passwordUsuario { get; set; }



    // CONSTRUCTOR 

	public Usuario()
	{


	}

    public Usuario(int idUsuario, string nombreUsuario, string emailUsuario, string rolUsuario, string nacionalidadUsuario, string passwordUsuario)
    {

		this.idUsuario = idUsuario;
		this.nombreUsuario	= nombreUsuario;
		this.emailUsuario = emailUsuario;
		this.rolUsuario = rolUsuario;
		this.nacionalidadUsuario = nacionalidadUsuario;
		this.passwordUsuario = passwordUsuario;
    }

}
