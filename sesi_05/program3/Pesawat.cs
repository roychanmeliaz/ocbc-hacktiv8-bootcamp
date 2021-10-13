using System;

public class Pesawat
{
    public string nama;
    public int jumlahRoda;
    public string jumlahPenumpang;
    private string ketinggian;
    public string Ketinggian
    {
        get {
            return this.ketinggian;
        }
        set {
            this.ketinggian = value;
        }
    }

    public void terbang() {
        Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);
    }
    public void sudahterbang() {
        Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this.ketinggian);
    }
}
public class Pesawat_Tempur:Pesawat
{
    public void terbang()
    {
        Console.WriteLine($"Pesawat Tempur dengan nama {this.nama}, yang mempunyai jumlah roda {this.jumlahRoda}, sedang berada pada ketinggian {this.Ketinggian}, dengan membawa jumlah penumpang sebanyak {this.jumlahPenumpang}");
    }
}
