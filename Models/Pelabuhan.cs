using System;
using System.ComponentModel.DataAnnotations;
public class Pelabuhan
{
    public int Id { get; set; }
    public string Nama { get; set; }
    public string Kota { get; set; }
    public int NegaraId { get; set; }

    public Negara Negara { get; set; }
}
