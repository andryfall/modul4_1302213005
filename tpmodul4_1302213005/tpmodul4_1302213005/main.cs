using static Table;

class main
{
    public static void Main(string[] args)
    {
        Table t = new Table();
        Kelurahan kelurahan = Kelurahan.Batununggal;

        Console.WriteLine(getKodePos(kelurahan));
    }
}