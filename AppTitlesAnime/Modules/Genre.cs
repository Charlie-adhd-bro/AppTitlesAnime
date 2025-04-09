using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Modules;

public partial class Genre
{
    public short Id { get; set; }

    public string GenreName { get; set; } = null!;


    //навигационнные св-ва
    public virtual ICollection<TitlesGenre> TitlesGenres { get; set; } = new List<TitlesGenre>();
}
