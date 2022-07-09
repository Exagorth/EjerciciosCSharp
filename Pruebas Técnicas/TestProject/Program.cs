

public static class Program
{

	public static void Main()
	{
		

		for (var i = 1; i <= 5; i++)
		{
			//if(i != 4) continue;//debugueo solo el caso 4
			
			var info = ObtenerData(i);

			var resultado = ComputeDayGains(info.Seats, info.PayingGuest, info.GuestMovements);

			Console.WriteLine("El total es: " + resultado);
		}
		
		Console.ReadKey();

	}
	
	
	
	static int ComputeDayGains(int nbSeats, List<int> payingGuest, List<int> guestMovements)
	{
		int total = 0;

		List<int> asientos = new List<int>();
		List<int> colaEspera = new List<int>();
		List<bool> yaVino = new List<bool>(new bool[payingGuest.Count]);

		foreach (var guestId in guestMovements)
		{
			
			if (asientos.Contains(guestId))
			{
				//Está sentado (ahora se va)
				asientos.Remove(guestId);
				if (colaEspera.Count > 0)
				{
					//agregamos al proximo en la cola
					var proximo = colaEspera.First();
					asientos.Add(proximo);
					colaEspera.Remove(proximo);
				}
				if (!yaVino[guestId])
				{
					//controlamos si cobramos
					total += payingGuest[guestId];
					yaVino[guestId] = true;
				}
				
			}
			else
			{
				//No está sentado (Está entrando al restaurante)
				if (asientos.Count < nbSeats)
				{
					asientos.Add(guestId);
				}
				else
				{
					//queda en al cola de espera
					if (colaEspera.Contains(guestId)) colaEspera.Remove(guestId); //Esperó y se fue sin sentarse
					else colaEspera.Add(guestId); //espera en la cola normalmente
					
				}
			}
			
			
			
			//
		}




		return total;

	}
	
	
	static ModeloInfo ObtenerData(int numeroTest)
	{
		string path = $@"../../../Resources/Test_{numeroTest}_input.txt";
		
		List<string> lineasTexto = File.ReadAllLines(path).ToList();

		ModeloInfo modelo = new ModeloInfo();
		
		modelo.Seats = Convert.ToInt32(lineasTexto[0]);
		
		modelo.PayingGuest = ConvertirLista(lineasTexto[3].Split(" ").ToList());
		
		modelo.GuestMovements = ConvertirLista(lineasTexto[4].Split(" ").ToList());
		
		return modelo;
	}
	public static List<int> ConvertirLista(List<string> listaEntrada)
	{
		List<int> listaSalida = new ();
		foreach (var str in listaEntrada)
		{
			var num = Convert.ToInt32(str);
			listaSalida.Add(num);
		}
		return listaSalida;
	}
}