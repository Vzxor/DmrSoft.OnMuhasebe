using System;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.Masraflar;

public class CreateMasrafDto:IEntityDto
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public int KdvOran { get; set; }
    public decimal BirimFiyat { get; set; }
    public string Barkod { get; set; }
    public Guid? BirimId { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}