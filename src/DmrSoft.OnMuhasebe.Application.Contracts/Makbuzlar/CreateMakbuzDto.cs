using System;
using System.Collections.Generic;
using DmrSoft.OnMuhasebe.MakbuzHareketler;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.Makbuzlar;

public class CreateMakbuzDto:IEntityDto
{
    public MakbuzTuru? MakbuzTuru { get; set; }
    public string MakbuzNo { get; set; }
    public DateTime Tarih { get; set; }
    public Guid? CariId { get; set; }
    public Guid? KasaId { get; set; }
    public Guid? BankaHesapId { get; set; }
    public int HareketSayisi { get; set; }
    public decimal CekToplam { get; set; }
    public decimal SenetToplam { get; set; }
    public decimal PosToplam { get; set; }
    public decimal NakitToplam { get; set; }
    public decimal BankaToplam { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public Guid? SubeId { get; set; }
    public Guid? DonemId { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
    public ICollection<MakbuzHareketDto> MakbuzHareketler { get; set; }
}