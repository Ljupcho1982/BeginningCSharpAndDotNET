﻿string line;
using (FileStream aFile = new FileStream("Log1.txt", FileMode.Open))
	try
	{

		using (StreamReader sr = new StreamReader(aFile))
		{
			line = sr.ReadLine();

			//Read data in line by line.

			while (line != null)
			{

				Console.WriteLine(line);
				line = sr.ReadLine();

			}
		}
	}





	catch (IOException e)
	{
		Console.WriteLine("An IO exception has been throw!");
		Console.WriteLine(e.ToString());
		return;

	}