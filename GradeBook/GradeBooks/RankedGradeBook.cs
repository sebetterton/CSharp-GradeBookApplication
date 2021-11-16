namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook : base(name)
    {
     public RankedGradeBook(string name)
            {
            Type = GradeBookType.Ranked;
            }
    }
}
