

Mobil kendaraanObj = new Mobil();

kendaraanObj.Merk = "Toyota";
kendaraanObj.Tahun = 2021;
kendaraanObj.JumlahPintu = 4;

Console.WriteLine($"Mobil saya adalah {kendaraanObj.Merk} pengeluaran tahun {kendaraanObj.Tahun} dan mempunyai pintu {kendaraanObj.JumlahPintu}");

kendaraanObj.Jalan();

class Kendaraan
{
    public string Merk;
    public int Tahun;

    public void Jalan()
    {
        Console.WriteLine("Kendaraan sedang bergerak");
    }
}

class Mobil : Kendaraan
{
    public int JumlahPintu;
}











































































































