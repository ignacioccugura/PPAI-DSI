using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Shopping_Buy_All.Negocios;
using System.Windows.Forms;


namespace Shopping_Buy_All.Clases
{
    public class GestorReservaVisita
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        public List<Escuela> escuelas = new List<Escuela>();
        public List<Sede> sedes = new List<Sede>();
        public List<TipoVisita> tiposVisitas = new List<TipoVisita>();
        public Escuela escuelaSeleccionada = new Escuela();
        public int cantidadVisitantes;
        public Sede sedeSeleccionada = new Sede();
        public TipoVisita tipoVisitaSeleccionada = new TipoVisita();
        public DateTime fechaHoraActual;
        public List<Exposicion> ExposicionesTempVigentes = new List<Exposicion>();
        public List<Exposicion> exposicionesSeleccionadas = new List<Exposicion>();
        public DateTime fechaHoraReserva;
        public int duracionEstimadaVisita = 0;
        public List<Empleado> empleados = new List<Empleado>();
        public List<Empleado> guiasDisponibles = new List<Empleado>();
        public List<Empleado> guiasSeleccionados = new List<Empleado>();
        public Sesion sesionActual = new Sesion();
        public List<ReservaVisita> reservas = new List<ReservaVisita>();
        public int guiasNecesarios;
        public List<Usuario> usuarios = new List<Usuario>();
        public List<Estado> estados = new List<Estado>();


        public List<Escuela> buscarEscuelas()
        {
            //Busca las escuelas existentes y las devuelve en forma de lista

            return this.escuelas;
        }
        public void tomarEscuela(string posicionEscuela)
        {
            //recibe como parámetro el índice de la escuela que fue seleccionada y le asigna al
            //atributo escuelaSeleccionada el objeto al que corresponde la posición del mismo en
            //la lista donde se encuentran todos los objetos escuela

            escuelaSeleccionada = escuelas[int.Parse(posicionEscuela)];
        }
        public void tomarCantidadVisitantes(string cantidad)
        {
            //recibe como parámetro una cantidad y la asigna al atributo cantidadVisitantes dicho valor

            cantidadVisitantes = int.Parse(cantidad);
        }
        public List<Sede> buscarSedes()
        {
            //busca las sedes existentes y las devuelve en forma de lista

            return this.sedes;
        }
        public void tomarSede(string sede)
        {
            //recibe como parámetro el índice de la sede que fue seleccionada y le asigna al atributo sedeSeleccionada
            //el objeto al que corresponde la posición del mismo en la lista donde se encuentran todos los objetos sede

            sedeSeleccionada = sedes[int.Parse(sede)];
        }
        public List<TipoVisita> buscarTipoVisita()
        {
            //busca los tipos de visita existentes y los devuelve en forma de lista

            return this.tiposVisitas;
        }
        public void tomarTipoVisita(string posicion)
        {
            //recibe como parámetro el índice del tipo de visita que fue seleccionado y le asigna al atributo tipoVisitaSeleccionada
            //el objeto al que corresponde la posición del mismo en la lista donde se encuentran todos los objetos tipoVisita

            tipoVisitaSeleccionada = tiposVisitas[int.Parse(posicion)];
        }
        public void tomarFechaHoraActual()
        {
            //le asigna al atributo fechaHoraActual el día y horario del momento en que se ejecuta el método,
            //según la configuración de su sistema operativo

            fechaHoraActual = DateTime.Now;
        }
        public void buscarExpTempVigentes()
        {
            //asigna al atributo ExposicionesTempVigentes una lista de objetos Exposicion
            //que cumplen la condicion de ser temporales y vigentes
            //que retorna el método BuscarExposiciones del objeto sedeSeleccionada

            ExposicionesTempVigentes = sedeSeleccionada.BuscarExposiciones(fechaHoraActual);
        }
        public void tomarExposiciones(string[] indices)
        {
            //recibe como parámetro un vector con los índices de todas las exposiciones que han sido seleccionadas por el usuario, lo recorre y agrega cada
            //uno de los objetos pertenecientes a la lista ExposicionesTempVigentes (que coinciden con los índices recibidos) a la lista exposicionesSeleccionadas

            for (int i = 0; i < indices.Length; i++)
            {
                exposicionesSeleccionadas.Add(ExposicionesTempVigentes[int.Parse(indices[i])]);
            }
        }
        public void tomarFechaHoraReserva(DateTime fechaHora)
        {
            //recibe la fecha y la hora ingresada por el usuario a la hora de registrar la reserva, asignandole su valor al atributo
            //fechaHoraReserva y llamando al método calcularDurEstimadaReserva. Luego evalúa el resultado del método calcularSobrepasaCapMax,
            //si devuelve true se llama a 2 metodos, calcularCantGuiasNecesarios y buscarGuiasDisponiblesFechaReserva.Si devuelve False se cancela el método.

            fechaHoraReserva = fechaHora;
            calcularDurEstimadaReserva();
            calcularSobrepasaCapMax();
            if (calcularSobrepasaCapMax())
            {
                calcularCantGuiasNecesarios();
                buscarGuiasDisponiblesFechaReserva();
            }
            else
            {
                return;
            }
        }
        private void calcularDurEstimadaReserva()
        {
            //invoca al método BuscarDuracionExposiciones del objeto sedeSeleccionada, pasandole como parámetro, la lista exposicionesSeleccionadas

            sedeSeleccionada.BuscarDuracionExposiciones(exposicionesSeleccionadas);
        }

        private bool calcularSobrepasaCapMax()
        {
            //asigna a la variable cantidadEstimada, el valor que retorna el método BuscarReservaParaFechaHora del objeto sedeSeleccionada.
            //Luego asigna a la variable validación, lo retornado por el método VerificarCantidadMaxVisitantes del objeto
            //sedeSeleccionada (el cual recibe como parámetro, la suma de cantidadEstimada y el valor del atributo cantidadVisitantes).
            //Retorna un valor booleano obtenido de la validación

            //for (int i = 0; i < sedes.Count; i++)
            //{
            //    MessageBox.Show(sedes[i].reservasVisita.Count.ToString());
            //}
            for (int i = 0; i < sedes.Count; i++)
            {
                MessageBox.Show("hola");
            }
            int hora = duracionEstimadaVisita / 3600;
            TimeSpan dur = TimeSpan.Parse(hora.ToString() + ":00:00");
            int cantidadEstimada = sedeSeleccionada.BuscarReservaParaFechaHora(fechaHoraReserva, dur);
            bool validacion = sedeSeleccionada.VerificarCantidadMaxVisitantes(cantidadEstimada + cantidadVisitantes);
            return validacion;

        }

        public void calcularCantGuiasNecesarios()
        {
            //calcula y establece la cantidad de guías necesarios para facilitarles el camino a la cantidad de visitantes ingresada

            int guiasNcs = cantidadVisitantes / sedeSeleccionada.getCantidadMaxPorGuia();
            if (cantidadVisitantes % sedeSeleccionada.getCantidadMaxPorGuia() > 0)
            {
                guiasNcs += 1;
            }
            guiasNecesarios = guiasNcs;

        }
        public void buscarGuiasDisponiblesFechaReserva()
        {
            //recorre la lista empleados y por cada uno de ellos compara sus horarios con el ingresado por el usuario, agregando a la
            //lista guiasDisponibles los que coincidan con la fecha y hora a reservar.

            for (int i = 0; i < empleados.Count; i++)
            {
                if (empleados[i].getGuiaDisponibleEnHorario(sedeSeleccionada, fechaHoraReserva))
                {
                    guiasDisponibles.Add(empleados[i]);
                }

            }

        }
        public void tomarGuias(string[] indice)
        {
            //recibe como parámetro un vector con los índices de los guías que seleccionó el usuario, con un ciclo recorre
            //la longitud del vector y va agregando a la lista guiasSeleccionados, aquellos guías que se recuperen por el índice de la lista guiasDisponibles

            for (int i = 0; i < indice.Length; i++)
            {
                guiasSeleccionados.Add(guiasDisponibles[int.Parse(indice[i])]);
            }
        }
        public void tomarConfirmacion(bool confirmacion)
        {
            //recibe como parámetro un booleano, si es true crea el objeto empleadoLogeado de la clase Empleado, asignando el objeto
            //que retorna el método buscarEmpleadosLogueados; a la variable numeroReserva se le asigna el valor que retorna el método
            //buscarUltimoNroReserva; se crea el objeto estado de la clase Estado, asignando el objeto retornado por el método BuscarEstadoReserva;
            //por último se convoca al método registrarReserva al que se le pasa como parámetro los objetos: estado, empleadoLogeado, numeroReserva.
            //Si es false, se muestra un mensaje comunicando que no se registró la reserva

            if (confirmacion)
            {
                Empleado empleadoLogeado = buscarEmpleadosLogueados();
                int numeroReserva = buscarUltimoNroReserva() + 1;
                Estado estado = BuscarEstadoReserva();
                registrarReserva(estado, empleadoLogeado, numeroReserva);
            }
            else
            {
                MessageBox.Show("No se ha finalizado la reserva con exito");
            }
        }
        public Empleado buscarEmpleadosLogueados()
        {
            //crea el objeto empleadoLogeado de la clase Empleado, al que se le asigna el valor del objeto que retorna el método
            //getEmpleadoLogueado del objeto sesiónActual. Por último, retorna empleadoLogeado

            Empleado empleadoLogeado = this.sesionActual.getEmpleadoLogueado();
            return empleadoLogeado;

        }
        public int buscarUltimoNroReserva()
        {
            //compara los numeros de las reservas, almacenando el mayor(por ende, el último) en la variable ultimaReserva

            int ultimaReserva = 0;
            for (int i = 0; i < reservas.Count; i++)
            {
                if (reservas[i].getNroReserva() > ultimaReserva)
                {
                    ultimaReserva = reservas[i].getNroReserva();
                }
            }
            return ultimaReserva;
        }
        public Estado BuscarEstadoReserva()
        {
            //recorre los estados, pregunta si su ambito es reserva y si está pendiente de confirmación, en caso de ser positivo
            //devuelve el estado que cumpla dichos criterios

            for (int i = 0; i < estados.Count; i++)
            {
                if (estados[i].EsAmbitoReserva())
                {
                    if (estados[i].EsPendienteDeConfirmacion())
                    {
                        return estados[i];
                    }
                }
            }
            return estados[estados.Count - 1];
        }
        public void registrarReserva(Estado estado, Empleado user, int numeroR)
        {
            //se envian los datos correspondientes al metodo CrearReserva para que la clase ReservaVisita lo ejecute y finalice el CU

            ReservaVisita reserva = new ReservaVisita();
            reserva.CrearReserva(estado, user, numeroR, guiasSeleccionados, fechaHoraReserva, duracionEstimadaVisita, cantidadVisitantes, escuelaSeleccionada, exposicionesSeleccionadas, sedeSeleccionada, tipoVisitaSeleccionada);
            MessageBox.Show("Se han cargado los datos correctamente!", "Enhorabuena");

        }

        public void CargarDatos()
        {
            //toma los datos almacenados en la base de datos y los carga en los objetos correspondientes 

            DataTable escuela = new DataTable();

            string sql = "SELECT * FROM ESCUELAS";
            escuela = _BD.Ejecutar_Select(sql);
            for (int i = 0; i < escuela.Rows.Count; i++)
            {
                Escuela escuelaNueva = new Escuela();
                escuelaNueva.nombre = escuela.Rows[i]["nombre"].ToString();
                escuelaNueva.mail = escuela.Rows[i]["mail"].ToString();
                escuelaNueva.telefCelular = escuela.Rows[i]["telefCelular"].ToString();
                escuelaNueva.telefFijo = escuela.Rows[i]["telefFijo"].ToString();
                escuelas.Add(escuelaNueva);
            }

            DataTable sede = new DataTable();
            string sqlSede = "SELECT * FROM SEDES";
            sede = _BD.Ejecutar_Select(sqlSede);

            DataTable obra = new DataTable();
            string sqlObra = "SELECT * FROM OBRA";
            obra = _BD.Ejecutar_Select(sqlObra);
            List<Obra> obras = new List<Obra>();

            DataTable exposicion = new DataTable();
            string sqlExp = "SELECT * FROM EXPOSICIONES";
            exposicion = _BD.Ejecutar_Select(sqlExp);
            List<Exposicion> exposiciones = new List<Exposicion>();

            DataTable tipoExposicion = new DataTable();
            string sqlTipoExposicion = "SELECT * FROM TIPOS_EXPOSICIONES";
            tipoExposicion = _BD.Ejecutar_Select(sqlTipoExposicion);
            List<TipoExposicion> tiposExposiciones = new List<TipoExposicion>();

            DataTable reservaVisita = new DataTable();
            string sqlReservaVisita = "SELECT * FROM RESERVAS_VISITAS";
            reservaVisita = _BD.Ejecutar_Select(sqlReservaVisita);
            List<ReservaVisita> reservasVisitas = new List<ReservaVisita>();

            DataTable tipoVisita = new DataTable();
            string sqlTipoVisita = "SELECT * FROM TIPOS_DE_VISITA";
            tipoVisita = _BD.Ejecutar_Select(sqlTipoVisita);
            List<TipoVisita> tipoVisitas = new List<TipoVisita>();

            DataTable empleado = new DataTable();
            string sqlEmpleado = "SELECT * FROM EMPLEADOS";
            empleado = _BD.Ejecutar_Select(sqlEmpleado);
            List<Empleado> empleadosLocal = new List<Empleado>();

            DataTable cargo = new DataTable();
            string sqlCargo = "SELECT * FROM CARGOS";
            cargo = _BD.Ejecutar_Select(sqlCargo);
            List<Cargo> cargos = new List<Cargo>();

            DataTable horarioEmpleado = new DataTable();
            string sqlHorarioEmpleado = "SELECT * FROM HORARIOS_EMPLEADOS";
            horarioEmpleado = _BD.Ejecutar_Select(sqlHorarioEmpleado);
            List<HorarioEmpleado> horariosEmpleados = new List<HorarioEmpleado>();

            DataTable diaSemana = new DataTable();
            string sqlDiaSemana = "SELECT * FROM DIAS_SEMANAS";
            diaSemana = _BD.Ejecutar_Select(sqlDiaSemana);
            List<DiaSemana> diasDeSemana = new List<DiaSemana>();

            DataTable asignacion = new DataTable();
            string sqlAsignacion = "SELECT * FROM ASIGNACIONES_VISITAS";
            asignacion = _BD.Ejecutar_Select(sqlAsignacion);
            List<AsignacionVisita> asignacionesVisitas = new List<AsignacionVisita>();

            DataTable cambioEstado = new DataTable();
            string sqlCambioEstado = "SELECT * FROM CAMBIOS_ESTADOS";
            cambioEstado = _BD.Ejecutar_Select(sqlCambioEstado);
            List<CambioDeEstado> cambiosDeEstado = new List<CambioDeEstado>();

            DataTable estado = new DataTable();
            string sqlEstado = "SELECT * FROM ESTADOS";
            estado = _BD.Ejecutar_Select(sqlEstado);

            DataTable reservasXexposiciones = new DataTable();
            string sqlRxE = "SELECT * FROM RESERVASXEXPOSICION";
            reservasXexposiciones = _BD.Ejecutar_Select(sqlRxE);

            DataTable user = new DataTable();
            string sqlUser = "SELECT * FROM USUARIOS";
            user = _BD.Ejecutar_Select(sqlUser);

            DataTable publicoDestino = new DataTable();
            string sqlPublico = "SELECT * FROM PUBLICOS_DESTINOS";
            publicoDestino = _BD.Ejecutar_Select(sqlPublico);
            List<PublicoDestino> publicosDestinos = new List<PublicoDestino>();

            for (int i = 0; i < publicoDestino.Rows.Count; i++)
            {
                PublicoDestino nuevoPublicoDestino = new PublicoDestino();
                nuevoPublicoDestino.nombre = publicoDestino.Rows[i]["nombre"].ToString();
                publicosDestinos.Add(nuevoPublicoDestino);

            }

            for (int i = 0; i < diaSemana.Rows.Count; i++)
            {
                DiaSemana diaNuevo = new DiaSemana();
                diaNuevo.nombre = diaSemana.Rows[i]["nombre"].ToString().Trim();
                diasDeSemana.Add(diaNuevo);
            }

            for (int i = 0; i < estado.Rows.Count; i++)
            {
                Estado estadoNuevo = new Estado();
                estadoNuevo.nombre = estado.Rows[i]["nombre"].ToString();
                estadoNuevo.ambito = estado.Rows[i]["ambito"].ToString();
                estados.Add(estadoNuevo);
            }

            for (int i = 0; i < cambioEstado.Rows.Count; i++)
            {
                CambioDeEstado cambioEstadoNuevo = new CambioDeEstado();
                cambioEstadoNuevo.fechaHoraFin = DateTime.Parse(cambioEstado.Rows[i]["fechaHoraFin"].ToString());
                cambioEstadoNuevo.fechaHoraInicio = DateTime.Parse(cambioEstado.Rows[i]["fechaHoraInicio"].ToString());
                for (int j = 0; j < estado.Rows.Count; j++)
                {
                    if (estado.Rows[j]["idEstado"] == cambioEstado.Rows[i]["idEstado"])
                    {
                        cambioEstadoNuevo.estado = estados[j];
                    }
                }
                cambiosDeEstado.Add(cambioEstadoNuevo);
            }


            for (int i = 0; i < horarioEmpleado.Rows.Count; i++)
            {
                HorarioEmpleado horarioNuevo = new HorarioEmpleado();
                horarioNuevo.horaInicio = TimeSpan.Parse(horarioEmpleado.Rows[i]["horaInicio"].ToString());
                horarioNuevo.horaFin = TimeSpan.Parse(horarioEmpleado.Rows[i]["horaFin"].ToString());
                for (int j = 0; j < diaSemana.Rows.Count; j++)
                {
                    if (diaSemana.Rows[j]["idDiaSemana"].ToString().Trim() == horarioEmpleado.Rows[i]["idDiaSemana"].ToString().Trim())
                    {
                        horarioNuevo.diaSemana = diasDeSemana[j];
                    }
                }
                horariosEmpleados.Add(horarioNuevo);


            }

            for (int i = 0; i < cargo.Rows.Count; i++)
            {
                Cargo cargoNuevo = new Cargo();
                cargoNuevo.nombre = cargo.Rows[i]["nombre"].ToString().Trim();
                cargoNuevo.descripcion = cargo.Rows[i]["descripcion"].ToString().Trim();
                cargos.Add(cargoNuevo);
            }

            for (int i = 0; i < tipoVisita.Rows.Count; i++)
            {
                TipoVisita tipoVisitaNuevo = new TipoVisita();
                tipoVisitaNuevo.nombre = tipoVisita.Rows[i]["nombre"].ToString().Trim();
                tiposVisitas.Add(tipoVisitaNuevo);
            }

            for (int i = 0; i < tipoExposicion.Rows.Count; i++)
            {
                TipoExposicion tipoExposicionNueva = new TipoExposicion();
                tipoExposicionNueva.nombre = tipoExposicion.Rows[i]["nombre"].ToString();
                tiposExposiciones.Add(tipoExposicionNueva);
            }


            for (int i = 0; i < obra.Rows.Count; i++)
            {
                Obra obraNueva = new Obra();
                obraNueva.nombre = obra.Rows[i]["nombreObra"].ToString();
                obraNueva.duracionExtendida = obra.Rows[i]["duracionExtendida"].ToString();
                obraNueva.duracionReducida = obra.Rows[i]["duracionReducida"].ToString();
                obras.Add(obraNueva);
            }

            for (int i = 0; i < exposicion.Rows.Count; i++)
            {
                Exposicion exposicionNueva = new Exposicion();
                exposicionNueva.nombre = exposicion.Rows[i]["nombre"].ToString();
                exposicionNueva.fechaFin = DateTime.Parse(exposicion.Rows[i]["fechaFin"].ToString());
                exposicionNueva.fechaFinReplanificacion = exposicion.Rows[i]["fechaFinReplanificada"].ToString();
                exposicionNueva.fechaInicioReplanificacion = exposicion.Rows[i]["fechaInicioReplanificada"].ToString();
                exposicionNueva.horaApertura = exposicion.Rows[i]["horaApertura"].ToString();
                exposicionNueva.horaCierre = exposicion.Rows[i]["horaCierre"].ToString();
                for (int j = 0; j < publicoDestino.Rows.Count; j++)
                {
                    if (publicoDestino.Rows[j]["idPublicoDestino"].ToString() == exposicion.Rows[i]["idPublicoDestino"].ToString())
                    {
                        exposicionNueva.publicoDestino = publicosDestinos[j];
                    }
                }
                for (int j = 0; j < tiposExposiciones.Count; j++)
                {
                    if (tipoExposicion.Rows[j]["idTipoExposicion"].ToString() == exposicion.Rows[i]["idTipoExposicion"].ToString())
                    {
                        exposicionNueva.tipoExposicion = tiposExposiciones[j];
                    }

                }

                for (int j = 0; j < obras.Count; j++)
                {
                    if (obra.Rows[j]["idExposicion"].ToString() == exposicion.Rows[i]["idExposicion"].ToString())
                    {
                        DetalleExposicion detalles = new DetalleExposicion();
                        detalles.obra = obras[j];
                        exposicionNueva.detallesExp.Add(detalles);
                    }
                }
                exposiciones.Add(exposicionNueva);
            }
            for (int i = 0; i < sede.Rows.Count; i++)
            {

                Sede sedeNueva = new Sede();
                sedeNueva.nombre = sede.Rows[i]["nombre"].ToString().Trim();
                sedeNueva.cantMaxPorGuia = int.Parse(sede.Rows[i]["cantMaxPorGuia"].ToString());
                sedeNueva.cantMaxVisitantes = int.Parse(sede.Rows[i]["cantMaxVisitantes"].ToString());
                for (int j = 0; j < exposiciones.Count; j++)
                {
                    if (exposicion.Rows[j]["idSede"].ToString() == sede.Rows[i]["idSede"].ToString())
                    {
                        sedeNueva.exposiciones.Add(exposiciones[j]);
                    }
                }
                for (int j = 0; j < reservaVisita.Rows.Count; j++)
                {
                    if (reservaVisita.Rows[j]["idSede"] == sede.Rows[i]["idSede"])
                    {
                        sedeNueva.reservasVisita.Add(reservasVisitas[j]);
                    }
                }
                sedes.Add(sedeNueva);

            }

            for (int i = 0; i < empleado.Rows.Count; i++)
            {
                Empleado empleadoNuevo = new Empleado();
                empleadoNuevo.nombre = empleado.Rows[i]["nombre"].ToString();
                empleadoNuevo.apellido = empleado.Rows[i]["apellido"].ToString();
                empleadoNuevo.codigoValidacion = int.Parse(empleado.Rows[i]["codigoValidacion"].ToString());
                empleadoNuevo.cuit = Int64.Parse(empleado.Rows[i]["cuit"].ToString());
                empleadoNuevo.domicilio = empleado.Rows[i]["domicilio"].ToString();
                empleadoNuevo.fechaIngreso = DateTime.Parse(empleado.Rows[i]["fechaIngreso"].ToString());
                empleadoNuevo.fechaNacimiento = DateTime.Parse(empleado.Rows[i]["fechaNacimiento"].ToString());
                empleadoNuevo.mail = empleado.Rows[i]["mail"].ToString();
                empleadoNuevo.telefono = empleado.Rows[i]["telefono"].ToString();
                for (int j = 0; j < cargo.Rows.Count; j++)
                {
                    if (cargo.Rows[j]["idCargo"].ToString().Trim() == empleado.Rows[i]["idCargo"].ToString().Trim())
                    {
                        empleadoNuevo.cargo = cargos[j];
                    }
                }
                for (int j = 0; j < sede.Rows.Count; j++)
                {
                    if (sede.Rows[j]["idSede"].ToString().Trim() == empleado.Rows[i]["idSede"].ToString().Trim())
                    {
                        empleadoNuevo.sede = sedes[j];
                    }
                }
                for (int j = 0; j < horarioEmpleado.Rows.Count; j++)
                {
                    if (horarioEmpleado.Rows[j]["idEmpleado"].ToString().Trim() == empleado.Rows[i]["idEmpleado"].ToString().Trim())
                    {
                        empleadoNuevo.horarioEmpleado.Add(horariosEmpleados[j]);
                    }
                }
                empleados.Add(empleadoNuevo);
            }

            for (int i = 0; i < asignacion.Rows.Count; i++)
            {
                AsignacionVisita asignacionVisitaNueva = new AsignacionVisita();
                asignacionVisitaNueva.fechaHoraInicio = DateTime.Parse(asignacion.Rows[i]["fechaHoraInicio"].ToString());
                asignacionVisitaNueva.fechaHoraFin = DateTime.Parse(asignacion.Rows[i]["fechaHoraFin"].ToString());
                for (int j = 0; j < empleado.Rows.Count; j++)
                {
                    if (empleado.Rows[j]["idEmpleado"] == asignacion.Rows[i]["idEmpleado"])
                    {
                        asignacionVisitaNueva.empleado = empleados[j];
                        empleados[j].asignacion = asignacionVisitaNueva;
                    }
                }
                asignacionesVisitas.Add(asignacionVisitaNueva);

            }

            for (int i = 0; i < reservaVisita.Rows.Count; i++)
            {
                ReservaVisita reservaVisitaNueva = new ReservaVisita();
                reservaVisitaNueva.numeroReserva = int.Parse(reservaVisita.Rows[i]["idReserva"].ToString());
                reservaVisitaNueva.cantidadAlumnos = int.Parse(reservaVisita.Rows[i]["cantidadAlumnos"].ToString());
                reservaVisitaNueva.cantidadAlumnosConfirmada = int.Parse(reservaVisita.Rows[i]["cantidadAlumnosConfirmada"].ToString());
                reservaVisitaNueva.duracionEstimada = TimeSpan.Parse(reservaVisita.Rows[i]["duracionEstimada"].ToString());
                reservaVisitaNueva.fechaHoraCreacion = DateTime.Parse(reservaVisita.Rows[i]["fechaHoraCreacion"].ToString());
                reservaVisitaNueva.fechaHoraReserva = DateTime.Parse(reservaVisita.Rows[i]["fechaHoraReservada"].ToString());
                reservaVisitaNueva.horaFinReal = TimeSpan.Parse(reservaVisita.Rows[i]["horaFinReal"].ToString());
                
                for (int j = 0; j < escuela.Rows.Count; j++)
                {
                    if (escuela.Rows[j]["idEscuela"] == reservaVisita.Rows[i]["idEscuela"])
                    {
                        reservaVisitaNueva.escuela = escuelas[j];
                    }
                }
                for (int j = 0; j < tipoVisita.Rows.Count; j++)
                {

                    if (tipoVisita.Rows[j]["id"] == reservaVisita.Rows[i]["idTipoVisita"])
                    {
                        reservaVisitaNueva.tipoVisita = tipoVisitas[j];
                    }
                }
                for (int j = 0; j < sede.Rows.Count; j++)
                {
                    if (sede.Rows[j]["idSede"] == reservaVisita.Rows[i]["idSede"])
                    {
                        reservaVisitaNueva.sede = sedes[j];
                    }
                }
                for (int j = 0; j < empleado.Rows.Count; j++)
                {
                    if (empleado.Rows[j]["idEmpleado"] == reservaVisita.Rows[i]["idEmpleado"])
                    {
                        reservaVisitaNueva.empleado = empleados[j];
                    }
                }

                for (int j = 0; j < asignacion.Rows.Count; j++)
                {
                    if (asignacion.Rows[j]["idAsignacionVisita"] == reservaVisita.Rows[i]["idAsignacionVisita"])
                    {
                        reservaVisitaNueva.asignacionVisita.Add(asignacionesVisitas[j]);
                    }
                }

                for (int j = 0; j < cambioEstado.Rows.Count; j++)
                {
                    if (cambioEstado.Rows[j]["idReserva"] == reservaVisita.Rows[i]["idReserva"])
                    {
                        reservaVisitaNueva.cambioDeEstado.Add(cambiosDeEstado[j]);
                    }
                }
                for (int j = 0; j < reservasXexposiciones.Rows.Count; j++)
                {
                    for (int k = 0; k < exposicion.Rows.Count; k++)
                    {
                        if (reservaVisita.Rows[i]["idReserva"] == reservasXexposiciones.Rows[j]["idReserva"] && exposicion.Rows[k]["idExposicion"] == reservasXexposiciones.Rows[j]["idExposicion"]) ;
                    }
                }

                reservas.Add(reservaVisitaNueva);
            }
            for (int i = 0; i < sede.Rows.Count; i++)
            {
                for (int j = 0; j < reservaVisita.Rows.Count; j++)
                {
                    if (reservaVisita.Rows[j]["idSede"] == sede.Rows[i]["idSede"])
                    {
                        sedes[i].reservasVisita.Add(reservasVisitas[j]);
                    }
                }
            }
            for (int i = 0; i < user.Rows.Count; i++)
            {
                Usuario userNuevo = new Usuario();
                userNuevo.nombre = user.Rows[i]["nombre"].ToString().Trim();
                userNuevo.contraseña = user.Rows[i]["contraseña"].ToString().Trim();
                userNuevo.caducidad = DateTime.Parse(user.Rows[i]["caducidad"].ToString().Trim());
                for (int j = 0; j < empleado.Rows.Count; j++)
                {
                    if (empleado.Rows[j]["idEmpleado"].ToString().Trim() == user.Rows[i]["idEmpleado"].ToString().Trim())
                    {
                        userNuevo.empleado = empleados[j];
                        break;
                    }
                }
                usuarios.Add(userNuevo);

            }

            DataTable sesion = new DataTable();
            string sqlSesion = "SELECT nombre, fechaInicio, horaInicio FROM SESIONES GROUP BY nombre, fechaInicio , horaInicio HAVING(fechaInicio) >= ALL(SELECT MAX(fechaInicio) FROM SESIONES)";
            sesion = _BD.Ejecutar_Select(sqlSesion);
            TimeSpan hora = TimeSpan.Parse("00:00:00.0000000");
            string indice = "0";
            for (int i = 0; i < sesion.Rows.Count; i++)
            {
                if (TimeSpan.Parse(sesion.Rows[i]["horaInicio"].ToString().Trim()) > hora)
                {
                    hora = TimeSpan.Parse(sesion.Rows[i]["horaInicio"].ToString().Trim());
                    indice = i.ToString();
                }
            }
            sesionActual.horaInicio = hora;
            sesionActual.fechaInicio = DateTime.Parse(sesion.Rows[int.Parse(indice)]["fechaInicio"].ToString());
            for (int i = 0; i < user.Rows.Count; i++)
            {
                if (user.Rows[i]["nombre"].ToString().Trim() == sesion.Rows[int.Parse(indice)]["nombre"].ToString().Trim())
                {
                    sesionActual.usuarioLog = usuarios[i];
                    break;
                }
            }


        }
        public void RegistrarSesion(Usuario user)
        {
            string sqlInsert = "INSERT INTO SESIONES VALUES(GETDATE(),NULL, convert(varchar(10), GETDATE(), 108),NULL,'" + user.nombre + "')";
            _BD.Insertar(sqlInsert);
        }

    }
}
