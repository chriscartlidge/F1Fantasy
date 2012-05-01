namespace F1_Fantasy.Queries.Interfaces
{
    /// <summary>
    /// A contract for creating queries. For example
    /// a query could return a list of all the circuits for
    /// the 2010 calendar.
    /// </summary>
    /// 
    /// <typeparam name="T">
    /// The type that this query is for.
    /// </typeparam>
    public interface IQuery<T>
    {
        /// <summary>
        /// Executes the query for the given type.
        /// </summary>
        /// 
        /// <returns>
        /// The result of the query for the given type.
        /// </returns>
        T Execute();
    }
}
