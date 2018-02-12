namespace ESA.DAL.Almaty
{
    public interface IReference : IPeriodic
    {
        string TitleKz { get; set; }
        string TitleRu { get; set; }
        string TitleEn { get; set; }
    }
}
