using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Modules;

public partial class TitlesGenre
{
    public int Id { get; set; }

    public short IdGenre { get; set; }

    public int IdAnime { get; set; }


    //навигационнные св-ва
    public virtual AnimeTitle IdAnimeNavigation { get; set; } = null!;

    public virtual Genre IdGenreNavigation { get; set; } = null!;
}
