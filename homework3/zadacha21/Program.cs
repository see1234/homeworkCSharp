 
double distance = Math.Round(Distance3D(Coord("x", "A"), Coord("y", "A"),Coord("z", "A"), Coord("x", "B"),Coord("y", "B"),Coord("z", "B")),2);
Console.WriteLine($"Дистанция в 3D: {distance}");
int Coord(string coord, string point)
{
    Console.Write($"Задайте координату {coord} точки {point}: ");
    return Convert.ToInt16(Console.ReadLine());
}
double Distance3D(double x, double y, double z, double x1, double y1, double z1){
  return Math.Sqrt(Math.Pow((x1-x), 2) + Math.Pow((y1-y), 2) + Math.Pow((z1-z), 2));
}

