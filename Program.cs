Console.WriteLine(" === RINCIAN PENCETAKAN === ");
Console.Write("Nama pelanggan: ");
string Namapelanggan = (Console.ReadLine());

Console.Write("Jumlah halaman: ");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.Write("Harga per halaman: ");
int hargaHalaman = int.Parse(Console.ReadLine());

const int biayaAdmin = 2000;
Console.WriteLine($"Biaya Administrasi = {biayaAdmin}");

int subTotal = hargaHalaman * jumlahHalaman;
Console.WriteLine($"SubTotal = {subTotal}");

int totalBayar = subTotal + biayaAdmin;
Console.WriteLine($"Total Bayar = {totalBayar}");gt