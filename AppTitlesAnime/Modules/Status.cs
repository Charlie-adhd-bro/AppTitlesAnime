using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Modules;

public partial class Status
{
    public short Id { get; set; }

    public string StatusName { get; set; } = null!;


    //навигационнные св-ва
    public virtual ICollection<TitleStatus> TitleStatuses { get; set; } = new List<TitleStatus>();
}
