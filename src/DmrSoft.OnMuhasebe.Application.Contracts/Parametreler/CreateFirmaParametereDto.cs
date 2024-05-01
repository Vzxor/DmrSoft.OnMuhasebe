using System;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.Parametreler;

public class CreateFirmaParametereDto:IEntityDto
{
    public Guid UserId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public Guid? DepoId { get; set; }
}