class Ferrari : ICar
{
    public string Model { get; set; }
    public string Driver { get; set; }

    public Ferrari(string driver)
    {
        this.Driver = driver;
        this.Model = "488-Spider";
    }

    public string Brake()
    {
        return "Brakes!";
    }

    public string PushGas()
    {
        return "Gas!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brake()}/{this.PushGas()}/{this.Driver}";
    }
}