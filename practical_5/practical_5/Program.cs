Console.Write("1)\nweigth: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("movement_speed: ");
double b = Convert.ToDouble(Console.ReadLine());
Kinetik s = new Kinetik(a, b);
Console.WriteLine(s.GetString());
Console.Write("W: "); 
Console.WriteLine(s.CalKinetik());
Console.Write("2)\nheigth: ");
double x = Convert.ToDouble(Console.ReadLine());
ChKinetik cw = new ChKinetik(a,b,x);
Console.Write($"heigth: {x} ");  
Console.WriteLine(cw.GetString());
Console.Write("CalEnergy: "); 
Console.WriteLine(cw.CalEnergy()); 

class Kinetik
{
    public double weigth;
    public double movement_speed; 
    
    public Kinetik(double m, double ms)
    {
        weigth = m;
        movement_speed = ms; 
    } 

    public string GetString()
    {
        return $"Weigth: {weigth}, Movement_speed: {movement_speed}";
    } 

    public double CalKinetik() 
    {
        return (weigth * Math.Pow(movement_speed, 2))/2;  
    }
} 

class ChKinetik : Kinetik
{
    public double hei;  
    public ChKinetik(double m, double ms, double h): base(m, ms)
    {
        hei = h;  
    } 
    public double CalEnergy()
    {
        return weigth * 9.81 * hei; 
    }
}