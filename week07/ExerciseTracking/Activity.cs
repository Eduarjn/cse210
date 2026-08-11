using System;

public abstract class Activity
{
    // Encapsulamento: Variáveis privadas
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Getter para permitir que as classes derivadas acessem os minutos para os cálculos
    public int GetMinutes()
    {
        return _minutes;
    }

    // Abstração e Polimorfismo: Métodos abstratos
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Método virtual/comum na classe base que formata o resumo sem precisar ser sobrescrito
    public string GetSummary()
    {
        // this.GetType().Name pega automaticamente o nome da classe derivada (Running, Cycling, Swimming)
        return $"{_date} {this.GetType().Name} ({_minutes} min): " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}
