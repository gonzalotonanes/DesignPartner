
using System;
using System.Linq;
using System.Collections.Generic;
using HeroesDeCiudad.Adicionales;
using HeroesDeCiudad.Builder;
using HeroesDeCiudad.ChainOfResponsability;
using HeroesDeCiudad.Heroes;
using HeroesDeCiudad.Iterator;
using HeroesDeCiudad.Lugares;
using HeroesDeCiudad.Proxy;
using HeroesDeCiudad.Strategy;
using HeroesDeCiudad.Composite;
using HeroesDeCiudad.Decorator;
using HeroesDeCiudad.Command;
using HeroesDeCiudad.TemplatheMethod;
using HeroesDeCiudad.Adapter;
using HeroesDeCiudad.AbstractFactory;


namespace HeroesDeCiudad
{
	class HeroesDeCiudad
	{
		
		
		public static void Main(string[] args)
		{
		

			
			TestComposite();
			
			//TestCommand();
			
			//TestTemplatedMethod();
			
			//TestAdapter();
			
			//TestDecorator();
			
			//TestObserver();
			
			//TestBuilder();
			
			//TestIterator();
			
			//TestChainOfResposability();
			
			//TestAbstractFactory();
			
			//TestSingleton();
			
			//TestProxy();
			
			//TestState();
			
			
			Console.ReadKey(true);
			
		}
		
		public static void TestState()
		{
			
			Manejador manejador= new Medico(null);
			manejador= new Policia(manejador);
			manejador= new Electricista(manejador);
			manejador=new Bombero(manejador);
			
			Transeunte paciente= new Transeunte();
			
			
			Operador911 operador= new Operador911(manejador);
			

			//LUGARES
			Calle calle = new Calle(100,4,100);
			Casa a= new Casa(1,20,3);	Plaza f= new Plaza("",40,50,20);
			Casa b= new Casa(2,20,3);	Plaza g= new Plaza("",40,50,20);
			Casa c= new Casa(3,20,3);	Plaza h= new Plaza("",40,50,20);
			Casa d= new Casa(4,20,3);	Plaza i= new Plaza("",40,50,20);
			Casa e= new Casa(5,20,3);	Plaza j= new Plaza("",40,50,20);
			Esquina esquina= new Esquina(4);
			a.Calle=calle;b.Calle=calle;c.Calle=calle;d.Calle=calle;e.Calle=calle;f.Calle=calle;g.Calle=calle;h.Calle=calle;i.Calle=calle;j.Calle=calle;
			

			//DENUNCIA POR WHATSAPP
			Passerby passerby= new Passerby(0.35,0.45,0.35);
			AdapterPasserby pacientaAdaptado =  new AdapterPasserby(passerby);
			
			
			MensajeWhatsapp lista= null;
			//DENUNCIAS DE INCENDIO
			lista= new MensajeWhatsapp(new DenunciaDeIncendios(a),lista);
			lista= new MensajeWhatsapp(new DenunciaDeIncendios(b),lista);
			lista= new MensajeWhatsapp(new DenunciaDeIncendios(c),lista);
			//DENUNCIAS DE INFARTO
			lista= new MensajeWhatsapp(new DenunciaDeInfarto(paciente),lista);
			lista= new MensajeWhatsapp(new DenunciaDeInfarto(pacientaAdaptado),lista);
			//DENUNCIAS DE ROBO
			lista= new MensajeWhatsapp(new DenunciaDeRobo(esquina),lista);
			lista= new MensajeWhatsapp(new DenunciaDeRobo(d),lista);
			lista= new MensajeWhatsapp(new DenunciaDeRobo(e),lista);
			//DENUNCIAS DE LAMPARAS QUEMADAS
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(f),lista);
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(g),lista);
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(h),lista);
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(i),lista);
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(j),lista);
			
			DenunciaPorWhatsapp dpw= new DenunciaPorWhatsapp(lista);
			
			operador.atenderDenuncias(dpw);
			
		}
		
		public static void TestProxy()
		{
			Manejador manejador= new MedicoProxy(null);
			manejador= new PoliciaProxy(manejador);
			manejador= new ElectricistaProxy(manejador);
			manejador=new BomberoProxy(manejador);

			Transeunte paciente= new Transeunte();
			
			
			Operador911 operador= new Operador911(manejador);
			

			//LUGARES
			Calle calle = new Calle(100,4,100);
			Casa a= new Casa(1,20,3);	Plaza f= new Plaza("",40,50,20);
			Casa b= new Casa(2,20,3);	Plaza g= new Plaza("",40,50,20);
			Casa c= new Casa(3,20,3);	Plaza h= new Plaza("",40,50,20);
			Casa d= new Casa(4,20,3);	Plaza i= new Plaza("",40,50,20);
			Casa e= new Casa(5,20,3);	Plaza j= new Plaza("",40,50,20);
			Esquina esquina= new Esquina(4);
			a.Calle=calle;b.Calle=calle;c.Calle=calle;d.Calle=calle;e.Calle=calle;f.Calle=calle;g.Calle=calle;h.Calle=calle;i.Calle=calle;j.Calle=calle;
			

			//DENUNCIA POR WHATSAPP
			Passerby passerby= new Passerby(0.35,0.45,0.35);
			AdapterPasserby pacientaAdaptado =  new AdapterPasserby(passerby);
			
			
			MensajeWhatsapp lista= null;
			//DENUNCIAS DE INCENDIO
			lista= new MensajeWhatsapp(new DenunciaDeIncendios(a),lista);
			lista= new MensajeWhatsapp(new DenunciaDeIncendios(b),lista);
			lista= new MensajeWhatsapp(new DenunciaDeIncendios(c),lista);
			//DENUNCIAS DE INFARTO
			lista= new MensajeWhatsapp(new DenunciaDeInfarto(paciente),lista);
			lista= new MensajeWhatsapp(new DenunciaDeInfarto(pacientaAdaptado),lista);
			//DENUNCIAS DE ROBO
			lista= new MensajeWhatsapp(new DenunciaDeRobo(esquina),lista);
			lista= new MensajeWhatsapp(new DenunciaDeRobo(d),lista);
			lista= new MensajeWhatsapp(new DenunciaDeRobo(e),lista);
			//DENUNCIAS DE LAMPARAS QUEMADAS
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(f),lista);
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(g),lista);
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(h),lista);
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(i),lista);
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(j),lista);
			
			
			DenunciaPorWhatsapp dpw= new DenunciaPorWhatsapp(lista);
			

			operador.atenderDenuncias(dpw);
		}
		
		
		
		public static void TestSingleton()
		{
			IFabricaDeHeroes fabrica_electricista= new FabricaDeElectricista();
			IFabricaDeHeroes fabrica_policia=new FabricaDePolicia();
			IFabricaDeHeroes fabrica_bombero=new FabricaDeBombero();
			IFabricaDeHeroes fabrica_medico=new FabricaDeMedico();
			
			ICuartel central_electrica= crearHeroe(fabrica_electricista);
			ICuartel comisaria= crearHeroe(fabrica_policia);
			ICuartel cuartel_de_bomberos= crearHeroe(fabrica_bombero);
			ICuartel hospital= crearHeroe(fabrica_medico);
			
			
			for (int i = 0; i < 4; i++) {
				central_electrica= crearHeroe(fabrica_electricista);
			}
			
			for (int i = 0; i < 4; i++) {
				comisaria= crearHeroe(fabrica_policia);
			}
			
			for (int i = 0; i < 4; i++) {
				cuartel_de_bomberos= crearHeroe(fabrica_bombero);
			}
			
			for (int i = 0; i < 4; i++) {
				hospital= crearHeroe(fabrica_medico);
			}
			
			
			IResponsable electricista = central_electrica.getPersonal();
			IResponsable electricista2= central_electrica.getPersonal();
			IResponsable electricista3= central_electrica.getPersonal();
			IResponsable electricista4= central_electrica.getPersonal();
			
			IResponsable bombero = cuartel_de_bomberos.getPersonal();
			IResponsable bombero2= cuartel_de_bomberos.getPersonal();
			IResponsable bombero3= cuartel_de_bomberos.getPersonal();
			IResponsable bombero4= cuartel_de_bomberos.getPersonal();
			
			IResponsable medico = hospital.getPersonal();
			IResponsable medico2= hospital.getPersonal();
			IResponsable medico3= hospital.getPersonal();
			IResponsable medico4= hospital.getPersonal();
			
			IResponsable policia = comisaria.getPersonal();
			IResponsable policia2= comisaria.getPersonal();
			IResponsable policia3= comisaria.getPersonal();
			IResponsable policia4= comisaria.getPersonal();
			
		}
		
		public static void TestAbstractFactory()
		{
			IFabricaDeHeroes fabrica_electricista= new FabricaDeElectricista();
			IFabricaDeHeroes fabrica_policia=new FabricaDePolicia();
			IFabricaDeHeroes fabrica_bombero=new FabricaDeBombero();
			IFabricaDeHeroes fabrica_medico=new FabricaDeMedico();
			
			ICuartel central_electrica= crearHeroe(fabrica_electricista);
			ICuartel comisaria= crearHeroe(fabrica_policia);
			ICuartel cuartel_de_bomberos= crearHeroe(fabrica_bombero);
			ICuartel hospital= crearHeroe(fabrica_medico);
			
			
			IResponsable electricista = central_electrica.getPersonal();
			
			IResponsable bombero = cuartel_de_bomberos.getPersonal();
			
			IResponsable medico = hospital.getPersonal();
			
			IResponsable policia = comisaria.getPersonal();
			
			
			
			
			Plaza plaza = new Plaza("luz",40,19,10);
			Esquina esquina= new Esquina(4);
			Casa casa = new Casa(1,40,5); Calle calle= new Calle(100,4,85); casa.Calle=calle;
			IInfartable trauseunte= new Transeunte();
			
			Console.ForegroundColor= ConsoleColor.Red;
			((Electricista)electricista).revisar(plaza);
			
			
			//guardando electricista al cuartel, su herramienta y vehiculo
			central_electrica.agregarherramienta(((Electricista)electricista).Herramienta);
			central_electrica.agregarVehiculo(((Electricista)electricista).Vehiculo);
			
			((Electricista)electricista).Herramienta=null;
			((Electricista)electricista).Vehiculo=null;
			central_electrica.agregarPersonal(electricista);
			electricista=null;
			
			
			Console.ForegroundColor= ConsoleColor.Green;
			((Policia)policia).patrullarCalles(esquina);
			
			//guardando policia al cuartel, su herramienta y vehiculo
			comisaria.agregarherramienta(((Policia)policia).Herramienta);
			comisaria.agregarVehiculo(((Policia)policia).Vehiculo);
			((Policia)policia).Herramienta=null;
			((Policia)policia).Vehiculo=null;
			comisaria.agregarPersonal(policia);
			policia=null;
			
			
			Console.ForegroundColor= ConsoleColor.Cyan;
			((Bombero)bombero).apagarIncendio(casa,casa.Calle);
			
			
			//guardando bombero al cuartel, su herramienta y vehiculo
			cuartel_de_bomberos.agregarherramienta(((Bombero)bombero).Herramienta);
			cuartel_de_bomberos.agregarVehiculo(((Bombero)bombero).Vehiculo);
			((Bombero)bombero).Herramienta=null;
			((Bombero)bombero).Vehiculo=null;
			cuartel_de_bomberos.agregarPersonal(bombero);
			bombero=null;
			
			Console.ForegroundColor= ConsoleColor.DarkYellow;
			((Medico)medico).atenderInfarto(trauseunte);
			
			//guardando medico al cuartel, su herramienta y vehiculo
			hospital.agregarherramienta(((Medico)medico).Herramienta);
			hospital.agregarVehiculo(((Medico)medico).Vehiculo);
			((Medico)medico).Herramienta=null;
			((Medico)medico).Vehiculo=null;
			hospital.agregarPersonal(medico);
			medico=null;
			
			
		}
		
		public static ICuartel crearHeroe(IFabricaDeHeroes fabrica)
		{
			
			IResponsable responsable= fabrica.crearHeroe();
			ICuartel cuartel= fabrica.crearCuartel();
			IHerramienta herramienta= fabrica.crearHerramienta();
			IVehiculo vehiculo= fabrica.crearVehiculo();
			
			cuartel.agregarherramienta(herramienta);
			cuartel.agregarPersonal(responsable);
			cuartel.agregarVehiculo(vehiculo);
			
			
			return cuartel;
		}
		
		
		
		
		public static void TestChainOfResposability()
		{
			
			Manejador manejador= new Medico(null);
			manejador= new Policia(manejador);
			manejador= new Electricista(manejador);
			manejador=new Bombero(manejador);
			
			Transeunte paciente= new Transeunte();
			
			
			Operador911 operador= new Operador911(manejador);
			

			//LUGARES
			Calle calle = new Calle(100,4,100);
			Casa a= new Casa(1,20,3);	Plaza f= new Plaza("",40,50,20);
			Casa b= new Casa(2,20,3);	Plaza g= new Plaza("",40,50,20);
			Casa c= new Casa(3,20,3);	Plaza h= new Plaza("",40,50,20);
			Casa d= new Casa(4,20,3);	Plaza i= new Plaza("",40,50,20);
			Casa e= new Casa(5,20,3);	Plaza j= new Plaza("",40,50,20);
			Esquina esquina= new Esquina(4);
			a.Calle=calle;b.Calle=calle;c.Calle=calle;d.Calle=calle;e.Calle=calle;f.Calle=calle;g.Calle=calle;h.Calle=calle;i.Calle=calle;j.Calle=calle;
			

			//DENUNCIA POR WHATSAPP
			Passerby passerby= new Passerby(0.35,0.45,0.35);
			AdapterPasserby pacientaAdaptado =  new AdapterPasserby(passerby);
			
			
			MensajeWhatsapp lista= null;
			//DENUNCIAS DE INCENDIO
			lista= new MensajeWhatsapp(new DenunciaDeIncendios(a),lista);
			lista= new MensajeWhatsapp(new DenunciaDeIncendios(b),lista);
			lista= new MensajeWhatsapp(new DenunciaDeIncendios(c),lista);
			//DENUNCIAS DE INFARTO
			lista= new MensajeWhatsapp(new DenunciaDeInfarto(paciente),lista);
			lista= new MensajeWhatsapp(new DenunciaDeInfarto(pacientaAdaptado),lista);
			//DENUNCIAS DE ROBO
			lista= new MensajeWhatsapp(new DenunciaDeRobo(esquina),lista);
			lista= new MensajeWhatsapp(new DenunciaDeRobo(d),lista);
			lista= new MensajeWhatsapp(new DenunciaDeRobo(e),lista);
			//DENUNCIAS DE LAMPARAS QUEMADAS
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(f),lista);
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(g),lista);
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(h),lista);
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(i),lista);
			lista= new MensajeWhatsapp(new DenunciaDeLamparaQuemada(j),lista);
			
			
			DenunciaPorWhatsapp dpw= new DenunciaPorWhatsapp(lista);
			

			operador.atenderDenuncias(dpw);
			
			
		}
		
		public static void TestIterator()
		{
			Bombero bombero= new Bombero(null);
			
			
			BomberoSecretario bs= new BomberoSecretario(bombero);
			

			//LUGARES
			Calle calle = new Calle(100,4,100);
			Casa a= new Casa(2,20,3);	Plaza f= new Plaza("",40,50,20);
			Casa b= new Casa(2,20,3);	Plaza g= new Plaza("",40,50,20);
			Casa c= new Casa(2,20,3);	Plaza h= new Plaza("",40,50,20);
			Casa d= new Casa(2,20,3);	Plaza i= new Plaza("",40,50,20);
			Casa e= new Casa(2,20,3);	Plaza j= new Plaza("",40,50,20);
			a.Calle=calle;b.Calle=calle;c.Calle=calle;d.Calle=calle;e.Calle=calle;f.Calle=calle;g.Calle=calle;h.Calle=calle;i.Calle=calle;j.Calle=calle;
			
			//DENUNCIA POR TABLERO
			
			DenunciasPorTablero dpt = new DenunciasPorTablero();
			a.agregarObserador(dpt);
			b.agregarObserador(dpt);
			c.agregarObserador(dpt);
			d.agregarObserador(dpt);
			e.agregarObserador(dpt);
			f.agregarObserador(dpt);
			
			b.chispa();
			f.chispa();
			
			//DENUNCIA POR WHATSAPP
			MensajeWhatsapp lista= null;
			lista= new MensajeWhatsapp(new DenunciaDeIncendios(g),lista);
			lista= new MensajeWhatsapp(new DenunciaDeIncendios(h),lista);
			lista= new MensajeWhatsapp(new DenunciaDeIncendios(i),lista);
			
			DenunciaPorWhatsapp dpw= new DenunciaPorWhatsapp(lista);
			
			
			//DENUNCIA POR MOSTRADOR
			
			DenunciaDeIncendios den= new DenunciaDeIncendios(j);
			DenunciaPorMostrador dpm= new DenunciaPorMostrador(den);
			
			bs.atenderDenuncias(dpt);
			bs.atenderDenuncias(dpw);
			bs.atenderDenuncias(dpm);
			
		}
		
		
		public static void TestBuilder()
		{
			ConstructorPartesAbstracto simple= new ConstructorSimple();
			ConstructorPartesAbstracto favorable= new ConstructorFavorable();
			ConstructorPartesAbstracto desfavorable= new ConstructorDesfavorable();
			ConstructorPartesAbstracto mixto= new ConstructorMixto();
			
			
		
			
			
			Calle calle= new Calle(100,4,50);
			Plaza plaza= new Plaza("",25,20,5);
			plaza.Calle=calle;
			
			
			Casa casa= new Casa(1,20,3);
			casa.Calle=calle;
			
			
			Plaza plaza2= new Plaza("",25,20,5);
			plaza2.Calle=calle;
			
			Casa casa2= new Casa(2,20,3);
			casa2.Calle=calle;

			Bombero bombero= new Bombero(null);
			
			
			
			casa.Constructor=mixto;
			casa2.Constructor= simple;
			plaza.Constructor=favorable;
			plaza2.Constructor=desfavorable;
			
			Console.ForegroundColor= ConsoleColor.Red;
			bombero.apagarIncendio(plaza,plaza.Calle);
			Console.ForegroundColor= ConsoleColor.Cyan;
			bombero.apagarIncendio(casa,casa.Calle);
			Console.ForegroundColor= ConsoleColor.Green;
			bombero.apagarIncendio(plaza2,plaza2.Calle);
			Console.ForegroundColor= ConsoleColor.Magenta;
			bombero.apagarIncendio(casa2,casa2.Calle);
			
		}
		
		
		public static void TestObserver()
		{
			Bombero bombero= new Bombero(null);
			Calle calle= new Calle(100,4,50);
			Casa casa1= new Casa(2,20,25);
			Casa casa2= new Casa(2,20,25);
			Casa casa3= new Casa(2,20,25);
			Casa casa4= new Casa(2,20,25);
			Casa casa5= new Casa(2,20,25);
			Plaza plaza= new Plaza("Paz",50,15,20);
			
			
			casa1.Calle=calle;
			casa2.Calle=calle;
			casa3.Calle=calle;
			casa4.Calle=calle;
			casa5.Calle=calle;
			plaza.Calle=calle;
			
			casa1.agregarObserador(bombero);
			plaza.agregarObserador(bombero);
			
			casa1.chispa();
			plaza.chispa();
		}
		

		public static void TestDecorator()
		{
			
			Plaza plaza= new Plaza("Bera",40,7,10);
			Casa casa = new Casa(2,40,3);
			
			Bombero bombero= new Bombero(null);
			Calle calle= new Calle(100,4,50);
			plaza.Calle=calle;
			casa.Calle=calle;
			bombero.apagarIncendio(plaza,plaza.Calle);
			
		}

		public static void TestTemplatedMethod(){
			Transeunte paciente= new Transeunte();
			
			Medico medico= new Medico(null);
			
			//ProtocoloRCP rcpB= new RCP_B();
			//medico.Rcp=rcpB;
			
			medico.atenderInfarto(paciente);
			
		}
		
		public static void TestAdapter(){
			
			Medico medico = new Medico(null);
			
			Passerby passerby= new Passerby(0.35,0.45,0.35);
			AdapterPasserby adapter =  new AdapterPasserby(passerby);
			
			medico.atenderInfarto(adapter);
			
		}
		
		public static void TestCommand(){
			
			Policia policia= new Policia(null);

			Avisar orden= new Avisar();
			
			policia.Orden= orden;
			
			List<IPatrullable> lista= CrearLugares();
			
			
			int contador=1;
			foreach (IPatrullable element in lista ) {
				policia.patrullarCalles(element);
				if (contador==5) {
					policia.NumeroOrden=1;
					
				}
				
				if (contador==10) {
					policia.NumeroOrden=2;
					
				}
				contador++;
				
			}
			
		}
		
		//TEST COMPOSITE
		
		public static void TestComposite()
		{
			Electricista electricista= new Electricista(null);
			
			//BARRIO A
			Manzana m1= generarManzanaConPlaza();
			Manzana m2= generarManzana();
			Manzana m3= generarManzana();
			Manzana m4= generarManzana();
			Manzana m5= generarManzana();
			Manzana m6= generarManzana();
			Manzana m7= generarManzana();
			Manzana m8= generarManzana();
			Manzana m9=  generarManzanaConPlaza();
			
			Barrio barrio_A= new Barrio("A");
			barrio_A.agregar(m1);
			barrio_A.agregar(m2);
			barrio_A.agregar(m3);
			barrio_A.agregar(m4);
			barrio_A.agregar(m5);
			barrio_A.agregar(m6);
			barrio_A.agregar(m7);
			barrio_A.agregar(m8);
			barrio_A.agregar(m9);
			
			//BARRIO B
			
			Manzana m10= generarManzanaConPlaza();
			Manzana m11= generarManzana();
			Manzana m12= generarManzana();
			Manzana m13= generarManzana();
			Manzana m14= generarManzana();
			Manzana m15= generarManzana();
			Manzana m16= generarManzana();
			
			Barrio barrio_B= new Barrio("B");
			barrio_B.agregar(m10);
			barrio_B.agregar(m11);
			barrio_B.agregar(m12);
			barrio_B.agregar(m13);
			barrio_B.agregar(m14);
			barrio_B.agregar(m15);
			barrio_B.agregar(m16);
			
			//BARRIO C
			Manzana m17= generarManzanaConPlaza();
			Manzana m18= generarManzana();
			Manzana m19= generarManzana();
			Manzana m20= generarManzana();
			Manzana m21=  generarManzanaConPlaza();
			
			Barrio barrio_C= new Barrio("C");
			barrio_C.agregar(m17);
			barrio_C.agregar(m18);
			barrio_C.agregar(m19);
			barrio_C.agregar(m20);
			barrio_C.agregar(m21);
			
			//BARIO D
			Manzana m22=  generarManzana();
			Manzana m23= generarManzana();
			Manzana m24= generarManzana();
			Manzana m25= generarManzana();
			Manzana m26= generarManzana();
			Manzana m27= generarManzana();
			
			Barrio barrio_D= new Barrio("D");
			barrio_D.agregar(m22);
			barrio_D.agregar(m23);
			barrio_D.agregar(m24);
			barrio_D.agregar(m25);
			barrio_D.agregar(m26);
			barrio_D.agregar(m27);
			
			Ciudad ciudad = new Ciudad();
			ciudad.agregar(barrio_A);
			ciudad.agregar(barrio_B);
			ciudad.agregar(barrio_C);
			ciudad.agregar(barrio_D);
			
			electricista.revisar(ciudad);
		}
		
		
		//METODO PARA COMMAND
		public static List<IPatrullable> CrearLugares(){
			int cont=0;
			Random r= new Random();
			
			List<IPatrullable> p= new List<IPatrullable>();
			IPatrullable l ;
			
			while (cont<15) {
				switch (r.Next(1,4)) {
					case 1:
						l = new Casa(2,20,5);
						p.Add(l);
						break;
					case 2:
						l= new Esquina(3);
						p.Add(l);
						break;
					case 3:
						l = new Plaza("random",50,20,8);
						p.Add(l);
						break;
						
				}
				
				cont++;
				
			}
			
			return p;
		}
		
		public static Manzana generarManzana()
		{
			Esquina e1;
			Calle calle;
			Manzana manzana = new Manzana();
			
			for (int i = 0; i < 4; i++) {
				e1=  new Esquina(Aleatorio.Next(2,3));
				calle= new Calle(Aleatorio.Next(80,101),Aleatorio.Next(2,5),Aleatorio.Next(65,100));
				manzana.agregar(e1);
				manzana.agregar(calle);
			}
			
			return manzana;
			
		}
		public static Manzana generarManzanaConPlaza()
		{
			Esquina e1;
			Calle calle;
			Manzana manzana = new Manzana();
			Plaza plaza = new Plaza("",Aleatorio.Next(40,60),Aleatorio.Next(5,25),Aleatorio.Next(10,20));
			
			for (int i = 0; i < 4; i++) {
				e1=  new Esquina(Aleatorio.Next(2,3));
				calle= new Calle(Aleatorio.Next(80,101),Aleatorio.Next(2,5),Aleatorio.Next(65,100));
				manzana.agregar(e1);
				manzana.agregar(calle);
			}
			manzana.agregar(plaza);
			
			return manzana;
		}
	}
}