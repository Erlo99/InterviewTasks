namespace InterviewTasks.zadanie3
{
    public class Task3
    {
        public static IEnumerable<IEnumerable<string>>
         OnlyBigCollections(List<IEnumerable<string>> toFilter)
        {
            Func<IEnumerable<string>, bool> predicate =
            list => list.Any() && list.Count() > 5;

            return toFilter.Where(predicate);
        }
    }
}
