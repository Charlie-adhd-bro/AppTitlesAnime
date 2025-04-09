using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Modules;

public partial class Type
{
    public short Id { get; set; }

    public string TypeName { get; set; } = null!;


    //навигационнные св-ва
    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
