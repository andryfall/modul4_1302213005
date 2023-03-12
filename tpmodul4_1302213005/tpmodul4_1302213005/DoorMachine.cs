internal class DoorMachine
{
    public enum State {Terkunci, Terbuka};
    State state = State.Terkunci;
    public void command()
    {
        Console.Write("Enter Command : ");
        string c = Console.ReadLine();

        if (c == "BukaPintu")
        {
            state = State.Terbuka;
        }else if (c == "KunciPintu")
        {
            state = State.Terkunci;
        }
        else
        {
            Console.WriteLine("Error : salah command");
        }
    }
    public void currentState()
    {
        if (state ==  State.Terkunci)
        {
            Console.WriteLine("Pintu Terkunci");
        }else if (state == State.Terbuka)
        {
            Console.WriteLine("Pintur Terbuka");
        }
    }
}