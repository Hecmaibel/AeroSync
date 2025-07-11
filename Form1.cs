using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace AeroSync
{
    public partial class frmInicioSesion : Form
    {
        //CREO LA CONEXION A LA BASE DE DATOS
        string connectionString = "server=localhost;port=3306;user=root;password=;database=db_aero_sync";
        public frmInicioSesion()
        {
            InitializeComponent();
            mostrarRol();
        }

        private void btnProbarBD_Click(object sender, EventArgs e)
        {
            //control o manejo de errores

            /*
             try{} catch (Exception ex){}
             * */
            try
            {
                //utilizar la conexion
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();//abrir
                    MessageBox.Show("la conexion ha sido exitosa",
                        "conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();//cerramos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Método para mostrar enum en el combo box

        private void mostrarRol()
        {
            //sentencia query
            string query = "SHOW COLUMNS FROM tbl_usuario LIKE 'rol_usuario'";

            //Hago lista para recibir el query
            List<string> listaRoles = new List<string>();

            //Usar la conexion y el query la base de datos 

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) //nueva conexión según query
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string type = reader["Type"].ToString(); // ejemplo: enum('Administrador','Pasajero')

                        // Extraer los valores usando Regex
                        MatchCollection matches = Regex.Matches(type, @"'([^']*)'");
                        foreach (Match match in matches)
                        {
                            listaRoles.Add(match.Groups[1].Value);
                        }
                    }

                }

            }
            //lenar el combo box
            cboRolUsuario.DataSource = listaRoles;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Recibiendo los datos ingresados en los textBox
            string nombreUsuario = txtNombreUsuario.Text;
            string passwordUsuario = txtPasswordUsuario.Text;
            string rolUsuario = cboRolUsuario.Text;

            //MessageBox.Show($"Los datos ingresados son: {nombreUsuario}, {passwordUsuario} y {rolUsuario} ");
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(passwordUsuario))
            {
                MessageBox.Show("Los campos deben estar llenos");
            }
            //Ahora si voy a utilizar using para usar la conexión a BD y manejo de errores

            /*using ()
             * { 
             * try {
             * } catch (Exception ex) { 
             * } 
             * }*/

            //Realizo el SQL

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM tbl_usuario WHERE nombre_usuario = @nombreUsuario " +
                        "AND password_usuario = @passwordUsuario AND rol_usuario = @rolUsuario";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@passwordUsuario", passwordUsuario);
                    cmd.Parameters.AddWithValue("@rolUsuario", rolUsuario);

                    MySqlDataReader reader = cmd.ExecuteReader();


                    if (reader.Read())
                    {
                        string rol = reader["rol_usuario"].ToString();
                        //MessageBox.Show("Inicio de sesión exitoso. Rol: " + rol); 
                        // Aquí puedes abrir otro formulario según el rol 
                        //Abrir el formulario de usuario
                        frmUsuario formularioUsuario = new frmUsuario();
                        formularioUsuario.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Usuario, contraseña o rol incorrectos.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

        /*private void cargarValoresEnum()
        {
            //string connectionString = "server=localhost;user=root;password=;database=tu_base_datos";
            string query = "SHOW COLUMNS FROM tbl_usuario LIKE 'rol_usuario'";
            List<string> roles = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString)) 
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) //nueva conexión según query
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string type = reader["Type"].ToString(); // ejemplo: enum('Administrador','Pasajero')

                        // Extraer los valores usando Regex
                        MatchCollection matches = Regex.Matches(type, @"'([^']*)'");
                        foreach (Match match in matches)
                        {
                            roles.Add(match.Groups[1].Value);

                        }
                    }
                }
            } 
            //Enlazar al ComboBox
            cboRolUsuario.DataSource = roles;
        */
       

