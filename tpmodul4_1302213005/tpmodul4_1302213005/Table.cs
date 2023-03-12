internal class Table
{
    public Table()
    {
    }
    public enum Kelurahan { Batununggal, Kujangsar, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja }
    public static int getKodePos(Kelurahan kelurahan)
    {
        int[] kodePos = { 40266, 40287, 40267, 40256, 40286, 40286, 40286, 40272, 40272, 40274, 40273 };


        return kodePos[(int)kelurahan];


    }
}