namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            base.Type = Enums.GradeBookType.Standard;
        }
    }
}