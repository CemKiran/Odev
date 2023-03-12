int[] numbers = { 5, 8, 10, 35, 33, 60 };
int min = numbers[0];
int max = numbers[0];
int i = 0;

for (int i = 1; i < numbers.Length; i++)
{
	if (numbers[i]< min)
	{
		min = numbers[i];
	}
	if (numbers[i]>max)
	{
		max = numbers[i];
	}
}

Console.WriteLine("Sayıların en küçüğü: " + min);
Console.WriteLine("Sayıların en büyüğü: " + max);

int toplam = 0;
int fark = 0;

for (int i = 0; i < numbers.Length; i++)
{
	toplam += numbers[i];
	fark -= numbers[i];
}

Console.WriteLine("Sayıların Toplamı = " + toplam);
Console.WriteLine("Sayıların Farkı = "+fark);


while (i < numbers.Length) 
{
	if (numbers[i]>max)
	{
		max = numbers[i];
	}
	if (numbers[i]< min)
	{
		min = numbers[i];
	}
	i++;
}

Console.WriteLine("Sayıların en büyüğü: "+max);
Console.WriteLine("Sayıların en küçüğü: " + min);