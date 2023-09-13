using System;
using System.ComponentModel.DataAnnotations;
public class Barang
{
    public int Id { get; set; }
    public string Nama { get; set; }
    public string Deskripsi { get; set; }
    public decimal Berat { get; set; }
    public decimal Harga { get; set; }
    public DateTime Tanggal { get; set; }
}
