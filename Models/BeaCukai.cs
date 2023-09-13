using System;
using System.ComponentModel.DataAnnotations;
public class BeaCukai
{
    public int Id { get; set; }
    public int NegaraId { get; set; }
    public int BarangId { get; set; }
    public decimal Tarif { get; set; }

    public Negara Negara { get; set; }
    public Barang Barang { get; set; }
}
