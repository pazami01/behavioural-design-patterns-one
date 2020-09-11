namespace mediator
{
    public class Heater : IColleague
    {
        public IMachineMediator Mediator { get; set; }

        public void On(int temp)
        {
            System.Console.WriteLine("Heater is on...");

            if (Mediator.CheckTemperature(temp))
            {
                System.Console.WriteLine($"Temperature is set to {temp}");
            }

            Mediator.Off();
        }
        public void Off()
        {
            System.Console.WriteLine("Heater is off...");

            Mediator.Wash();
        }
    }
}