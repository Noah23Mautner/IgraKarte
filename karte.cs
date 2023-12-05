using System;
					
public class Program
{
	public static void Main()
	{
		int karte;
		int brojkarata = 0;
		
		while(brojkarata < 31 )
		{
		Console.WriteLine("Upisite vrijednost karte:");
			try
			{
			karte = Convert.ToInt32(Console.ReadLine());
		if ( karte > 13 || karte < 1)
		{  
			Console.WriteLine("pogrešan unos!");
			
		}
		else
		{
			brojkarata += karte;
		}
			}
			catch(Exception ex)
		{
		Console.WriteLine(ex.Message);
		}
		}
		
		if ( brojkarata == 31)
		{
			Console.WriteLine("Bodovi" +  brojkarata);
			Console.WriteLine("Pobijedili ste");
		}
		else
		{
			
			Console.WriteLine("Bodovi" +  brojkarata);
			Console.WriteLine("Izgubidli ste");
		}
		
	}
	
}