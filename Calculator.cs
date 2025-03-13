class calculator
{
	
	static void main(string[] args)
	{
		int a = 10;
		int b = 5;
		Console.Writeline("Hasil Penambahan : {0} + {1} = {2}", a, b, Penambahan(a, b));
		Console.Writeline("Hasil Pengurangan : {0} + {1} = {2}", a, b, Pengurangan(a, b));
		
		Console.Writeline("\nTekan Smbarang Key untuk keluar");
		Console.Readkey();
		
	}
	
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
}