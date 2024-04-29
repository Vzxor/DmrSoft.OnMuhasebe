using System;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.BankaSubeler;

public class CreateBankaSubeDto:IEntityDto
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid? BankaId { get; set; }
    public Guid? Ozelkod1Id { get; set; }
    public Guid? Ozelkod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
    
}