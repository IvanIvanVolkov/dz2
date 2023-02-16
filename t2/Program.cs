Console.Write("Введите число: ");
int anyNamber = Convert.ToInt32(Console.ReadLine());
string anyNamberText = Convert.ToString(anyNamber);
if (anyNamberText.Length >2){
    Console.WriteLine("третья цифра ->"+ anyNamberText[2]);
}
else{
    Console.WriteLine("-> третьей цыфры нет");
}