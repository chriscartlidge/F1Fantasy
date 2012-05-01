namespace F1_Fantasy.Queries.Tests
{
    using NUnit.Framework;

    public sealed class TestCircuitsForYear
    {
        [Test]
        public void GetData()
        {
            var query = new CircuitsForYear(1998);

           var result =  query.Execute();
        }
    }
}
