namespace AppTitlesAnime.Modules;

public partial class TitleStatus
{
    public int Id { get; set; }

    public short IdStatus { get; set; }

    public int IdAnime { get; set; }

    public DateOnly? DateStatus { get; set; }


    //навигационнные св-ва
    public virtual AnimeTitle AnimeTitle { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
