using System;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.Depolar;

public class ListDepoDto : EntityDto<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string Ozelkod1Adi { get; set; }
    public string Ozelkod2Adi { get; set; }
    public decimal Giren { get; set; }
    public decimal Cikan { get; set; }
    public decimal Mevcut => Giren - Cikan;
    public string Aciklama { get; set; }
}