using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("//LISTA DE NUESTRAS SUCURSALES//");
            Console.WriteLine();

            List<Sucursal> sucursales = new List<Sucursal>();

            TipoAuto Deportivo = new TipoAuto(300);
            TipoAuto Utilitario = new TipoAuto("Hasta 100k");
            TipoAuto Familiar = new TipoAuto("Grande", "");
            RegVehiculos nuevoAuto1 = new RegVehiculos(1, "A2HH3", "Audi", "Rojo", "100L", "Usado", 10000, 2, Deportivo);
            RegVehiculos nuevoAuto2 = new RegVehiculos(2, "HJ23F", "Golf gti", "Negro", "100L", "Nuevo", 1500, 5, Deportivo);
            RegVehiculos nuevoAuto3 = new RegVehiculos(3, "HJ23F", "Mercedes Benz", "Negro", "100L", "Nuevo", 2000, 5, Familiar);
            RegVehiculos nuevoAuto4 = new RegVehiculos(4, "HTD324", "BMW", "Blanco", "150L", "Como Nuevo", 2000, 10, Deportivo);
            RegVehiculos nuevoAuto5 = new RegVehiculos(5, "34FREW", "KIA", "Blanco", "150L", "Como Nuevo", 2000, 10, Utilitario);
            RegVehiculos nuevoAuto6 = new RegVehiculos(6, "21RTYH", "SUBARU", "Blanco", "150L", "Como Nuevo", 2000, 10, Familiar);

            List<RegVehiculos> ColRegVehiculos1 = new List<RegVehiculos>();




            ColRegVehiculos1.Add(nuevoAuto1);
            ColRegVehiculos1.Add(nuevoAuto2);
            ColRegVehiculos1.Add(nuevoAuto3);
            ColRegVehiculos1.Add(nuevoAuto4);
            ColRegVehiculos1.Add(nuevoAuto5);
            ColRegVehiculos1.Add(nuevoAuto6);


            Sucursal nuevaSucursal1 = new Sucursal(1, " Direccion: Jose Pedro Varela y Manolo Lima", ColRegVehiculos1);
            Sucursal nuevaSucursal2 = new Sucursal(2, "Direccion:  Roberto Varela y Lituania", ColRegVehiculos1);


            sucursales.Add(nuevaSucursal1);
            sucursales.Add(nuevaSucursal2);


            Console.WriteLine("Que Sucursal Desea?");
            Console.WriteLine();



            for (int i = 0; i < sucursales.Count; i++)
            {

                Console.WriteLine(sucursales[i].getNumero() + "- " + sucursales[i].getDireccion());



            }

            int numero = Int32.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Que Auto desea alquilar?");
            Console.WriteLine();

            switch (numero)
            {


                case 1:


                    for (int p = 0; p < ColRegVehiculos1.Count; p++)
                    {

                        Console.WriteLine(ColRegVehiculos1[p].getNumero() + "- " + ColRegVehiculos1[p].getMarca() + "(" + ColRegVehiculos1[p].getColor() + ")");
                    };
                    break;

                case 2:


                    for (int e = 0; e < ColRegVehiculos1.Count; e++)
                    {

                        Console.WriteLine(ColRegVehiculos1[e].getNumero() + "- " + ColRegVehiculos1[e].getMarca() + "(" + ColRegVehiculos1[e].getColor() + ")");
                    };
                    break;



            }
            Console.WriteLine();
            

            int numero2 = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (numero2)
            {

                case 1:

                    Console.WriteLine("Marca: " + nuevoAuto1.getMarca());
                    Console.WriteLine("Matricula: " + nuevoAuto1.getMatricula());
                    Console.WriteLine("Color: " + nuevoAuto1.getColor());
                    Console.WriteLine("Capacidad del Tanque: " + nuevoAuto1.getCapTanque());
                    Console.WriteLine("Km por Litro: " + nuevoAuto1.getKmPorLitro());
                    Console.WriteLine("Estado: " + nuevoAuto1.getEstado());
                    Console.WriteLine("Precio del Alquiler por Hora: " + nuevoAuto1.getPrecioAlquiler());
                    Console.WriteLine("Velocidad Maxima es: " + Deportivo.getVelocidadMax() + "km/h");


                    
                    Console.WriteLine("//Cuantos dias vas a utilizar el Vehiculo: ");
                    int dias = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del  cliente: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el Apellido del cliente: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento del cliente:  ");
                    string documento = Console.ReadLine();
                    Console.WriteLine("Ingrese el Telefono del  cliente: ");
                    string telefono = Console.ReadLine();



                    int CantPagar = (dias * nuevoAuto1.getPrecioAlquiler());

                    Alquiler alquiler = new Alquiler(1, CantPagar, documento, telefono, nombre, apellido);

                    Console.Clear();
                    Console.WriteLine("//BOLETA//");
                    Console.WriteLine();

                    Detalles detalles = new Detalles(nuevoAuto1.getMarca(), DateTime.Now, dias);


                    Console.WriteLine("Nombre y Apellido: " + alquiler.getNombreCliente() + " " + alquiler.getApellidoCliente() + "\n Documento: " + alquiler.getDocumento() + "\n Telefono: " + alquiler.getTelefono() + "\n Auto: " + detalles.getVehiculo() + "\n Fecha de Retiro: " + detalles.getFechaRetiro() + "\n Dias Alquilados: " + detalles.getCantDias() + "\nPrecio Final: " + alquiler.getPrecioTotal());

                    break;

                case 2:

                    Console.WriteLine("Marca: " + nuevoAuto2.getMarca());
                    Console.WriteLine("Matricula: " + nuevoAuto2.getMatricula());
                    Console.WriteLine("Color: " + nuevoAuto2.getColor());
                    Console.WriteLine("Capacidad del Tanque: " + nuevoAuto2.getCapTanque());
                    Console.WriteLine("Km por Litro: " + nuevoAuto2.getKmPorLitro());
                    Console.WriteLine("Estado: " + nuevoAuto2.getEstado());
                    Console.WriteLine("Precio del Alquiler por Hora: " + nuevoAuto2.getPrecioAlquiler());
                    Console.WriteLine("Velocidad Maxima es: " + Deportivo.getVelocidadMax() + "km/h");


                    
                    
                    Console.WriteLine("//Cuantos dias vas a utilizar el Vehiculo: ");
                    int dias2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del  cliente: ");
                    string nombre2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el Apellido del cliente: ");
                    string apellido2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento del cliente:  ");
                    string documento2 = Console.ReadLine();
                    Console.WriteLine("Ingrese el Telefono del  cliente: ");
                    string telefono2 = Console.ReadLine();


                    int CantPagar2 = (dias2 * nuevoAuto2.getPrecioAlquiler());

                    Alquiler alquiler2 = new Alquiler(2, CantPagar2, documento2, telefono2, nombre2, apellido2);
                    Console.Clear();
                    Console.WriteLine("//BOLETA//");
                    Console.WriteLine();

                    Detalles detalles2 = new Detalles(nuevoAuto2.getMarca(), DateTime.Now, dias2);


                    Console.WriteLine("Nombre y Apellido: " + alquiler2.getNombreCliente() + " " + alquiler2.getApellidoCliente() + "\n Documento: " + alquiler2.getDocumento() + "\n Telefono: " + alquiler2.getTelefono() + "\n Auto: " + detalles2.getVehiculo() + "\n Fecha de Retiro: " + detalles2.getFechaRetiro() + "\n Dias Alquilados: " + detalles2.getCantDias() + "\nPrecio Final: " + alquiler2.getPrecioTotal());
                    break;

                case 3:
                    Console.WriteLine("Marca: " + nuevoAuto3.getMarca());
                    Console.WriteLine("Matricula: " + nuevoAuto3.getMatricula());
                    Console.WriteLine("Color: " + nuevoAuto3.getColor());
                    Console.WriteLine("Capacidad del Tanque: " + nuevoAuto3.getCapTanque());
                    Console.WriteLine("Km por Litro: " + nuevoAuto3.getKmPorLitro());
                    Console.WriteLine("Estado: " + nuevoAuto3.getEstado());
                    Console.WriteLine("Precio del Alquiler por Hora: " + nuevoAuto3.getPrecioAlquiler());
                    Console.WriteLine("La capacidad del Maletero es: " + Familiar.getCapMaletero());


                   
                    
                    Console.WriteLine("//Cuantos dias vas a utilizar el Vehiculo: ");
                    int dias3 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del  cliente: ");
                    string nombre3 = Console.ReadLine();
                    Console.WriteLine("Ingrese el Apellido del cliente: ");
                    string apellido3 = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento del cliente:  ");
                    string documento3 = Console.ReadLine();
                    Console.WriteLine("Ingrese el Telefono del  cliente: ");
                    string telefono3 = Console.ReadLine();



                    int CantPagar3 = (dias3 * nuevoAuto3.getPrecioAlquiler());

                    Alquiler alquiler3 = new Alquiler(3, CantPagar3, documento3, telefono3, nombre3, apellido3);
                    Console.Clear();
                    Console.WriteLine("//BOLETA//");
                    Console.WriteLine();

                    Detalles detalles3 = new Detalles(nuevoAuto3.getMarca(), DateTime.Now, dias3);


                    Console.WriteLine("Nombre y Apellido: " + alquiler3.getNombreCliente() + " " + alquiler3.getApellidoCliente() + "\n Documento: " + alquiler3.getDocumento() + "\n Telefono: " + alquiler3.getTelefono() + "\n Auto: " + detalles3.getVehiculo() + "\n Fecha de Retiro: " + detalles3.getFechaRetiro() + "\n Dias Alquilados: " + detalles3.getCantDias() + "\nPrecio Final: " + alquiler3.getPrecioTotal());
                    break;

                case 4:
                    Console.WriteLine("Marca: " + nuevoAuto4.getMarca());
                    Console.WriteLine("Matricula: " + nuevoAuto4.getMatricula());
                    Console.WriteLine("Color: " + nuevoAuto4.getColor());
                    Console.WriteLine("Capacidad del Tanque: " + nuevoAuto4.getCapTanque());
                    Console.WriteLine("Km por Litro: " + nuevoAuto4.getKmPorLitro());
                    Console.WriteLine("Estado: " + nuevoAuto4.getEstado());
                    Console.WriteLine("Precio del Alquiler por Hora: " + nuevoAuto4.getPrecioAlquiler());
                    Console.WriteLine("Velocidad Maxima es: " + Deportivo.getVelocidadMax() + "km/h");

                   
                    
                    Console.WriteLine("//Cuantos dias vas a utilizar el Vehiculo: ");
                    int dias4 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del  cliente: ");
                    string nombre4 = Console.ReadLine();
                    Console.WriteLine("Ingrese el Apellido del cliente: ");
                    string apellido4 = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento del cliente:  ");
                    string documento4 = Console.ReadLine();
                    Console.WriteLine("Ingrese el Telefono del  cliente: ");
                    string telefono4 = Console.ReadLine();



                    int CantPagar4 = (dias4 * nuevoAuto4.getPrecioAlquiler());

                    Alquiler alquiler4 = new Alquiler(4, CantPagar4, documento4, telefono4, nombre4, apellido4);
                    Console.Clear();
                    Console.WriteLine("//BOLETA//");
                    Console.WriteLine();

                    Detalles detalles4 = new Detalles(nuevoAuto4.getMarca(), DateTime.Now, dias4);


                    Console.WriteLine("Nombre y Apellido: " + alquiler4.getNombreCliente() + " " + alquiler4.getApellidoCliente() + "\n Documento: " + alquiler4.getDocumento() + "\n Telefono: " + alquiler4.getTelefono() + "\n Auto: " + detalles4.getVehiculo() + "\n Fecha de Retiro: " + detalles4.getFechaRetiro() + "\n Dias Alquilados: " + detalles4.getCantDias() + "\nPrecio Final: " + alquiler4.getPrecioTotal());
                    break;

                case 5:
                    Console.WriteLine("Marca: " + nuevoAuto5.getMarca());
                    Console.WriteLine("Matricula: " + nuevoAuto5.getMatricula());
                    Console.WriteLine("Color: " + nuevoAuto5.getColor());
                    Console.WriteLine("Capacidad del Tanque: " + nuevoAuto5.getCapTanque());
                    Console.WriteLine("Km por Litro: " + nuevoAuto5.getKmPorLitro());
                    Console.WriteLine("Estado: " + nuevoAuto5.getEstado());
                    Console.WriteLine("Precio del Alquiler por Hora: " + nuevoAuto5.getPrecioAlquiler());
                    Console.WriteLine("La capacidad de Carga es:  " + Utilitario.getCapCarga());


                    
                    Console.WriteLine("//Cuantos dias vas a utilizar el Vehiculo: ");
                    int dias5 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del  cliente: ");
                    string nombre5 = Console.ReadLine();
                    Console.WriteLine("Ingrese el Apellido del cliente: ");
                    string apellido5 = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento del cliente:  ");
                    string documento5 = Console.ReadLine();
                    Console.WriteLine("Ingrese el Telefono del  cliente: ");
                    string telefono5 = Console.ReadLine();



                    int CantPagar5 = (dias5 * nuevoAuto5.getPrecioAlquiler());

                    Alquiler alquiler5 = new Alquiler(5, CantPagar5, documento5, telefono5, nombre5, apellido5);
                    Console.Clear();
                    Console.WriteLine("//BOLETA//");
                    Console.WriteLine();

                    Detalles detalles5 = new Detalles(nuevoAuto5.getMarca(), DateTime.Now, dias5);


                    Console.WriteLine("Nombre y Apellido: " + alquiler5.getNombreCliente() + " " + alquiler5.getApellidoCliente() + "\n Documento: " + alquiler5.getDocumento() + "\n Telefono: " + alquiler5.getTelefono() + "\n Auto: " + detalles5.getVehiculo() + "\n Fecha de Retiro: " + detalles5.getFechaRetiro() + "\n Dias Alquilados: " + detalles5.getCantDias() + "\nPrecio Final: " + alquiler5.getPrecioTotal());
                    break;

                case 6:

                    Console.WriteLine("Marca: " + nuevoAuto6.getMarca());
                    Console.WriteLine("Matricula: " + nuevoAuto6.getMatricula());
                    Console.WriteLine("Color: " + nuevoAuto6.getColor());
                    Console.WriteLine("Capacidad del Tanque: " + nuevoAuto6.getCapTanque());
                    Console.WriteLine("Km por Litro: " + nuevoAuto6.getKmPorLitro());
                    Console.WriteLine("Estado: " + nuevoAuto6.getEstado());
                    Console.WriteLine("Precio del Alquiler por Hora: " + nuevoAuto6.getPrecioAlquiler());
                    Console.WriteLine("Velocidad Maxima es: " + Deportivo.getVelocidadMax() + "km/h");



                   
                    
                    Console.WriteLine("//Cuantos dias vas a utilizar el Vehiculo: ");
                    int dias6 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del  cliente: ");
                    string nombre6 = Console.ReadLine();
                    Console.WriteLine("Ingrese el Apellido del cliente: ");
                    string apellido6 = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento del cliente:  ");
                    string documento6 = Console.ReadLine();
                    Console.WriteLine("Ingrese el Telefono del  cliente: ");
                    string telefono6 = Console.ReadLine();



                    int CantPagar6 = (dias6 * nuevoAuto6.getPrecioAlquiler());

                    Alquiler alquiler6 = new Alquiler(6, CantPagar6, documento6, telefono6, nombre6, apellido6);
                    Console.Clear();
                    Console.WriteLine("//BOLETA//");
                    Console.WriteLine();

                    Detalles detalles6 = new Detalles(nuevoAuto6.getMarca(), DateTime.Now, dias6);


                    Console.WriteLine("Nombre y Apellido: " + alquiler6.getNombreCliente() + " " + alquiler6.getApellidoCliente() + "\n Documento: " + alquiler6.getDocumento() + "\n Telefono: " + alquiler6.getTelefono() + "\n Auto: " + detalles6.getVehiculo() + "\n Fecha de Retiro: " + detalles6.getFechaRetiro() + "\n Dias Alquilados: " + detalles6.getCantDias() + "\nPrecio Final: " + alquiler6.getPrecioTotal());
                    break;
            }













        }

        public void HacerBoleta() {


            Console.WriteLine();
            Console.WriteLine("Cuantos dias vas a utilizar el Vehiculo?");
            int dias = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Documento de Identidad: ");
            string documento = Console.ReadLine();
            Console.WriteLine("Telefono: ");
            string telefono = Console.ReadLine();

        }
    }

    class Sucursal
    {

        private int numero;
        private string direccion;
        private List<RegVehiculos> ColRegVehiculos;

        public Sucursal(int numero, string direccion, List<RegVehiculos> ColRegVehiculos)
        {

            this.numero = numero;
            this.direccion = direccion;
            this.ColRegVehiculos = ColRegVehiculos;

        }

        public int getNumero()
        {

            return numero;
        }

        public void setNumero(int numero)
        {

            this.numero = numero;
        }

        public string getDireccion()
        {

            return direccion;
        }

        public void setDireccion(string direccion)
        {

            this.direccion = direccion;
        }

        public void setRegistroVehiculos(List<RegVehiculos> ColRegVehiculos)
        {

            this.ColRegVehiculos = ColRegVehiculos;
        }
        public List<RegVehiculos> getRegistroVehiculos()
        {

            return this.ColRegVehiculos;
        }

    }

    class RegVehiculos
    {

        private int numero;
        private string matricula;
        private string marca;
        private string color;
        private string CapTanque;
        private string estado;
        private int PrecioAlquiler;
        private int KmPorLitro;
        private TipoAuto TipoAuto;
        private List<Alquiler> colAlquiler;


        public RegVehiculos(int numero, string matricula, string marca, string color, string CapTanque, string estado, int PrecioAlquiler, int KmPorLitro, TipoAuto TipoAuto)
        {

            this.numero = numero;
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
            this.CapTanque = CapTanque;
            this.estado = estado;
            this.PrecioAlquiler = PrecioAlquiler;
            this.KmPorLitro = KmPorLitro;
            this.TipoAuto = new TipoAuto();
            

        }

        public RegVehiculos(List<Alquiler> colAlquiler)
        {

            this.colAlquiler = colAlquiler;

        }

        public int getNumero()
        {

            return this.numero;
        }

        public void setNumero(int numero)
        {

            this.numero = numero;
        }

        public string getMatricula()
        {

            return this.matricula;
        }

        public void setMatricula(string matricula)
        {

            this.matricula = matricula;
        }

        public string getMarca()
        {

            return this.marca;
        }

        public void setMarca(string marca)
        {

            this.marca = marca;
        }

        public string getColor()
        {

            return this.color;
        }

        public void setColor(string color)
        {

            this.color = color;
        }

        public string getCapTanque()
        {

            return this.CapTanque;
        }

        public void setCapTanque(string CapTanque)
        {

            this.CapTanque = CapTanque;
        }

        public string getEstado()
        {

            return this.estado;
        }

        public void setEstado(string estado)
        {

            this.estado = estado;
        }

        public int getPrecioAlquiler()
        {

            return this.PrecioAlquiler;
        }

        public void setPrecioAlquiler(int PrecioAlquiler)
        {

            this.PrecioAlquiler = PrecioAlquiler;
        }

        public int getKmPorLitro()
        {

            return this.KmPorLitro;
        }

        public void setKmPorLitro(int KmPorLitro)
        {

            this.KmPorLitro = KmPorLitro;
        }

        public List<Alquiler> GetAlquiler()
        {

            return this.colAlquiler;
        }

        public void setAlquiler(List<Alquiler> colAlquiler)
        {

            this.colAlquiler = colAlquiler;
        }

        public TipoAuto GetTipoAuto()
        {

            return this.TipoAuto;
        }

        public void setTipoAuto(TipoAuto tipoAuto)
        {

            this.TipoAuto = tipoAuto;

        }
    }

    class Alquiler
    {

        private int numero;
        private int PrecioTotal;
        private string documento;
        private string telefono;
        private string nombreCliente;
        private string apellidoCliente;
        private List<Detalles> ColDetalles;

        public Alquiler(int numero, int PrecioTotal, string documento, string telefono, string nombreCliente, string apellidoCliente)
        {

            this.numero = numero;
            this.telefono = telefono;
            this.apellidoCliente = apellidoCliente;
            this.documento = documento;
            this.PrecioTotal = PrecioTotal;
            this.nombreCliente = nombreCliente;
            this.ColDetalles = new List<Detalles>();
        }

        public void AgregarDetalles(string vehiculo, DateTime fechaRetiro, int CantDias)
        {

            Detalles miDetalle = new Detalles(vehiculo, fechaRetiro, CantDias);
            ColDetalles.Add(miDetalle);
        }

        public List<Detalles> getColDetalles()
        {


            return this.ColDetalles;
        }

        public void setColDetalles(List<Detalles> ColDetalles)
        {

            this.ColDetalles = ColDetalles;
        }

        public int getNumero()
        {

            return this.numero;
        }

        public void setNumero(int numero)
        {

            this.numero = numero;
        }

        public int getPrecioTotal()
        {

            return this.PrecioTotal;
        }

        public void setPrecioTotal(int PrecioTotal)
        {

            this.PrecioTotal = PrecioTotal;
        }

        public string getDocumento()
        {

            return this.documento;
        }

        public void setDocumento(string documento)
        {

            this.documento = documento;
        }

        public string getTelefono()
        {

            return this.telefono;
        }

        public void setTelefono(string telefono)
        {

            this.telefono = telefono;
        }

        public string getNombreCliente()
        {

            return this.nombreCliente;
        }

        public void setNombreCliente(string nombreCliente)
        {

            this.nombreCliente = nombreCliente;
        }

        public string getApellidoCliente()
        {

            return this.apellidoCliente;
        }

        public void setApellidoCliente(string apellidoCliente)
        {

            this.apellidoCliente = apellidoCliente;
        }

    }

    class Detalles
    {

        private string vehiculo;
        private DateTime fechaRetiro;
        private int CantDias;

        public Detalles(string vehiculo, DateTime fechaRetiro, int CantDias)
        {

            this.vehiculo = vehiculo;
            this.fechaRetiro = fechaRetiro;
            this.CantDias = CantDias;

        }

        public string getVehiculo()
        {

            return this.vehiculo;
        }

        public void setVehiculo(string vehiculo)
        {

            this.vehiculo = vehiculo;


        }

        public DateTime getFechaRetiro()
        {

            return this.fechaRetiro;
        }

        public void setFechaRetiro(DateTime fechaRetiro)
        {

            this.fechaRetiro = fechaRetiro;

        }

        public int getCantDias()
        {

            return this.CantDias;
        }

        public void setCantDias(int CantDias)
        {

            this.CantDias = CantDias;

        }


    }

    class TipoAuto
    {

        private string CapCarga;
        private int VelocidadMax;
        private string CapMaletero;

        public TipoAuto() { 
        
        
        }
        public TipoAuto(string CapCarga)
        {

            this.CapCarga = CapCarga;



        }

        public TipoAuto(string CapMaletero, string CapCarga)
        {

            this.CapMaletero = CapMaletero;
        }

        public TipoAuto(int VelocidadMax)
        {

            this.VelocidadMax = VelocidadMax;
        }




        public string getCapCarga()
        {

            return this.CapCarga;

        }

        public void setCapCarga(string CapCarga)
        {

            this.CapCarga = CapCarga;
        }

        public int getVelocidadMax()
        {

            return this.VelocidadMax;

        }

        public void setVelocidadMax(int VelocidadMax)
        {

            this.VelocidadMax = VelocidadMax;
        }

        public string getCapMaletero()
        {

            return this.CapMaletero;

        }

        public void setCapMaletero(string CapMaletero)
        {

            this.CapMaletero = CapMaletero;
        }



    }





}
