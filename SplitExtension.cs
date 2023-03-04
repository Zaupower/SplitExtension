namespace Split
{
    public static class SplitExtension
    {
        public static ICollection<IEnumerable<T>> Split<T>(this IEnumerable<T> sourceList, int listSize)
        {
            ICollection<IEnumerable<T>> listOfLists = new List<IEnumerable<T>>();
            for (int i = 0; i < sourceList.Count(); i += listSize)
            {
                listOfLists.Add(sourceList.Skip(i).Take(listSize));
            }
            return listOfLists;
        }

        public static ICollection<IEnumerable<T>> SplitOrDefault<T>(this IEnumerable<T> sourceList, int listSize)
        {
            ICollection<IEnumerable<T>> listOfLists = new List<IEnumerable<T>>();
            if (listSize > sourceList.Count()) { return listOfLists; }
            for (int i = 0; i < sourceList.Count(); i += listSize)
            {
                listOfLists.Add(sourceList.Skip(i).Take(listSize));
            }
            return listOfLists;
        }
    }
}