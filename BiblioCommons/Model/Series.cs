namespace BiblioCommons
{
    /// <summary>
    /// A Series instance resource describes the series information if the Title is part of series
    /// </summary>
    public class Series
    {
        /// <summary>
        /// The series name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The number of this title within the series.
        /// </summary>
        public string number { get; set; }
    }
}
