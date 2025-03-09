// See https://aka.ms/new-console-template for more information
using tpmodul4_103022300078;

class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode Pos Batununggal: " + kodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Wates: " + kodePos.GetKodePos("Wates"));
        Console.WriteLine("Kode Pos Sekejati: " + kodePos.GetKodePos("Sekejati"));
        Console.WriteLine("Kode Pos Tidak Ada: " + kodePos.GetKodePos("TidakAda"));

        Console.WriteLine("\n=== Simulasi DoorMachine ===");
        DoorMachine pintu = new DoorMachine();
        pintu.BukaPintu();
        pintu.KunciPintu();
    }
}