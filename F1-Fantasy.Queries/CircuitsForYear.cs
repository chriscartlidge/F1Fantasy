namespace F1_Fantasy.Queries
{
    using System.Collections.Generic;
    using System.Linq;

    using EasyHttp.Http;

    using F1.Fantasy.DataTransferObjects;

    using F1_Fantasy.Queries.Interfaces;

    /// <summary>
    /// Implements a query that is used for
    /// return the circuits used within a grand prix 
    /// for a supplied year.
    /// </summary>
    public sealed class CircuitsForYear : IQuery<IEnumerable<CircuitDTO>>
    {
        private readonly int year;

        public CircuitsForYear(int year)
        {
            this.year = year;
        }

        /// <summary>
        /// Executes the query for the given type.
        /// </summary>
        /// 
        /// <returns>
        /// The result of the query for the given type.
        /// </returns>
        public IEnumerable<CircuitDTO> Execute()
        {
            var http = new HttpClient
            {
                Request = { Accept = HttpContentTypes.ApplicationJson }
            };

            var response = http.Get(string.Format("http://ergast.com/api/f1/{0}/circuits.xml", this.year));

            var result = MRDataType.Deserialize(response.RawText);

            var circuits = result.CircuitTable.Circuit.Select(circuit => new CircuitDTO
                {
                    Name = circuit.CircuitName,
                    Location = string.Format("{0}, {1}", circuit.Location.Country, circuit.Location.Locality.First()),
                });

           return circuits;
        }
    }
}
