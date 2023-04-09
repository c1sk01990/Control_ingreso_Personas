using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;


namespace control_de_empleados
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        Timer timer = new Timer();


        public Form1()
        {
            InitializeComponent();

            //CboTipo_Persona.SelectedIndex = -1;
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            timer.Interval = 1500; // 1.5 segundos
            timer.Tick += Timer_Tick;


            // variable que muestra el combobox vacio hasta seleccionar un item
            CboTipo_Persona.SelectedIndex = -1;



        }


        // boton para la salida del personal
        private void materialButton2_Click(object sender, EventArgs e)
        {
            // Obtener la hora actual

            DateTime horaSalida = DateTime.Now;
            string cedula = txtCedula.Text;

            // Mostrar la hora de salida en el label
            LblMostrarSali.Text = "La hora de salida es: " + horaSalida.ToString("HH:mm:ss");
            timer.Start();
            string conexionDB = "server=localhost;user=root;database=control_empleados;port=3306;password=Libero125;";

            using (MySqlConnection conn = new MySqlConnection(conexionDB))
            {
                // se abre la conexion a una base de datos
                conn.Open();

                // Realizar la consulta para actualizar el registro con la hora de salida del empleado
                string query = "UPDATE empleados SET hora_salida = @hora_salida WHERE cedula = @cedula";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    cmd.Parameters.AddWithValue("@hora_salida", horaSalida);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
        // boton para el ingreso del personal
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            // Obtener la hora actual

            DateTime horaEntrada = DateTime.Now;
            string cedula = txtCedula.Text;

            // Mostrar la hora de entrada en el label
            Lblmostrarentrad.Text = "La hora de entrada es: " + horaEntrada.ToString("HH:mm:ss");

            timer.Start();

            // variable que guarda la conexion de la base de datos
            string conexionDB = "server=localhost;user=root;database=control_empleados;port=3306;password=Libero125;";

            using (MySqlConnection conn = new MySqlConnection(conexionDB))
            {
                // se abre la conexion a una base de datos
                conn.Open();


                string query = "INSERT INTO EMPLEADOS  (cedula, hora_ingreso) VALUES (@cedula, @hora_ingreso)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    cmd.Parameters.AddWithValue("@hora_ingreso", horaEntrada);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Entrada!");
                }
                conn.Close();
            }

        }


        // metodo para controlar el tiempo en el cual el mensaje esta habilitado
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Detener el Timer
            timer.Stop();

            // Borrar el texto del label
            Lblmostrarentrad.Text = "";
            LblMostrarSali.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }
        // control del combobox 
        private void CboTipo_Persona_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CboTipo_Persona.SelectedItem != null)
            {
                string tipo = CboTipo_Persona.SelectedItem.ToString();

                if (tipo == "INVITADOS" || tipo == "PROVEEDORES")
                {
                    // Deshabilitar los botones de ingreso y salida
                    BtnIngresar.Enabled = false;
                    BtnSalir.Enabled = false;
                    lblnombre.Enabled = true;
                    txtnombre.Enabled = true;
                    BtnRegistroInvi.Enabled = true;

                    // Mostrar un mensaje al usuario
                    MessageBox.Show("Debe registrarse!");
                }
                else
                {
                    // Habilitar los botones de ingreso y salida
                    BtnIngresar.Enabled = true;
                    BtnSalir.Enabled = true;
                    BtnRegistroInvi.Enabled = false;
                    lblnombre.Enabled = false;
                    txtnombre.Enabled = false;
                }

            }

        }

        // boton de registro para invitados
        private void BtnRegistroInvi_Click(object sender, EventArgs e)
        {
            // Obtener la hora actual

            DateTime horaEntrada = DateTime.Now;
            string cedula = txtCedula.Text;
            string nombre = txtnombre.Text;

            // Mostrar la hora de entrada en el label


            timer.Start();

            // variable que guarda la conexion de la base de datos
            string conexionDB = "server=localhost;user=root;database=control_empleados;port=3306;password=Libero125;";

            using (MySqlConnection conn = new MySqlConnection(conexionDB))
            {
                // se abre la conexion a una base de datos
                conn.Open();

                if (registro(cedula))
                {
                    // El usuario ya está registrado
                    MessageBox.Show("El usuario ya está registrado!");
                }

                else
                {
                    string query = "INSERT INTO invitado  (cedula,nombre, hora_ingreso) VALUES (@cedula, @nombre,@hora_ingreso)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@cedula", cedula);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@hora_ingreso", horaEntrada);
                        cmd.ExecuteNonQuery();
                        BtnIngresar.Enabled = true;
                        BtnSalir.Enabled = true;
                        MessageBox.Show("Bienvenido(a) a Big Jhon");

                    }

                }
                conn.Close();
            }


        }

        public bool registro(string cedula)
        {


            bool registrado = false;

            // Conectarse a la base de datos
            string connectionString = "server=localhost;user=root;database=control_empleados;port=3306;password=Libero125;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Buscar al usuario en la base de datos
                string query = "SELECT COUNT(*) FROM invitado WHERE cedula = @cedula";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // El usuario ya está registrado
                        registrado = true;
                    }
                }

                conn.Close();
            }

            return registrado;


        }

        // boton calculo horas trabajadas
        private void btnHorasTrabajadas_Click(object sender, EventArgs e)
        {
            // Obtener la cédula del empleado
            string cedula = txtCedula.Text;

            // variable que guarda la conexion de la base de datos
            string conexionDB = "server=localhost;user=root;database=control_empleados;port=3306;password=Libero125;";

            using (MySqlConnection conn = new MySqlConnection(conexionDB))
            {
                // se abre la conexion a una base de datos
                conn.Open();

                // Realizar la consulta para obtener las horas de entrada y salida del empleado
                string query = "SELECT hora_ingreso, hora_salida FROM empleados WHERE cedula = @cedula";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime horaIngreso = reader.GetDateTime("hora_ingreso");

                            // Verificar si las horas corresponden al día que deseas calcular
                            if (horaIngreso.Date == DateTime.Today)
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal("hora_salida")))
                                {
                                    DateTime horaSalida = reader.GetDateTime("hora_salida");

                                    // Calcular las horas trabajadas
                                    TimeSpan horasTrabajadas = horaSalida - horaIngreso;

                                    // Mostrar el resultado en el formulario
                                    lblhoras.Text = horasTrabajadas.TotalHours.ToString("0.00") + " horas";
                                }
                                else
                                {
                                    MessageBox.Show("La hora de salida del empleado no está registrada.");
                                }

                                break;
                            }
                        }
                    }
                }

                conn.Close();
            }
        }

        private void btnnumeroPers_Click(object sender, EventArgs e)
        {
            string conexionDB = "server=localhost;user=root;database=control_empleados;port=3306;password=Libero125;";

            using (MySqlConnection conn = new MySqlConnection(conexionDB))
            {
                // se abre la conexion a una base de datos
                conn.Open();

                // Realizar la consulta para contar el número de empleados
                string queryEmpleados = "SELECT COUNT(*) as cantidad FROM empleados";
                using (MySqlCommand cmd = new MySqlCommand(queryEmpleados, conn))
                {
                    int cantidadEmpleados = Convert.ToInt32(cmd.ExecuteScalar());
                    Console.WriteLine("Empleados: {0}", cantidadEmpleados);
                    MessageBox.Show("Empleados: " + cantidadEmpleados);
                }


                conn.Close();
            }
        }

        // boton para saber cuantos invitados hay
        

        

        private void btncalculo_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;

            // Obtener la fecha a calcular
            DateTime fecha = dtpFecha.Value;

            TimeSpan tiempoTotal = TimeSpan.Zero;

            // variable que guarda la conexion de la base de datos
            string conexionDB = "server=localhost;user=root;database=control_empleados;port=3306;password=Libero125;";

            using (MySqlConnection conn = new MySqlConnection(conexionDB))
            {
                // se abre la conexion a una base de datos
                conn.Open();

                // Realizar la consulta para obtener las horas de entrada y salida del empleado
                string query = "SELECT hora_ingreso, hora_salida FROM empleados WHERE cedula = @cedula";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime horaIngreso = reader.GetDateTime("hora_ingreso");
                            DateTime horaSalida = reader.GetDateTime("hora_salida");

                            // Verificar si las horas corresponden al día que deseas calcular
                            if (horaIngreso.Date == fecha.Date)
                            {
                                // Calcular el tiempo que el empleado permaneció dentro de la empresa en este período
                                TimeSpan tiempo = horaSalida - horaIngreso;

                                // Sumar el tiempo al tiempo total
                                tiempoTotal += tiempo;
                            }
                        }
                    }
                }

                conn.Close();
            }

            // Mostrar el resultado en el formulario
            horas.Text = tiempoTotal.TotalHours.ToString("0.00") + " horas";
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            string conexionDB = "server=localhost;user=root;database=control_empleados;port=3306;password=Libero125;";

            using (MySqlConnection conn = new MySqlConnection(conexionDB))
            {
                conn.Open();
                string queryInvitados = "SELECT COUNT(*) as cantidad FROM invitado";
                using (MySqlCommand cmd = new MySqlCommand(queryInvitados, conn))
                {
                    int cantidadInvitados = Convert.ToInt32(cmd.ExecuteScalar());
                    Console.WriteLine("Invitados: {0}", cantidadInvitados);
                    MessageBox.Show("Invitados: " + cantidadInvitados);
                }

                conn.Close();
            }
        }
    }
}