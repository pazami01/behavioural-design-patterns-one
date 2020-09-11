namespace mediator
{
    public class Sensor
    {
        public bool CheckTemperature(int temp)
        {
            System.Console.WriteLine($"Temperature reached {temp} C");
            return true;
        }
    }
}