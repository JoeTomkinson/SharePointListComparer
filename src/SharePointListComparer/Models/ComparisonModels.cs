using System.Collections.Generic;

namespace SharePointListComparer.Models
{
    public class ComparisonResult
    {
        public string ListName { get; set; }

        public string ComparisonListName { get; set; }

        public bool Identical { get; set; }

        public int ComparisonIndex { get; set; }

        public IEnumerable<ColumnAnalysis> FirstListColumnsAnalysis { get; set; }

        public IEnumerable<ColumnAnalysis> SecondListColumnAnalysis { get; set; }

        /// <summary>
        /// Online and local template lists differ in how they store system created columns, so comparing views is sometimes a better way to tell if they are identical.
        /// </summary>
        public bool AreViewsIdentical { get; set; }
    }

    public class ColumnAnalysis
    {
        public string DisplayName { get; set; }

        public bool Matched { get; set; }
    }

    public enum ListType
    {
        Online,
        Spt,
        Hybrid,
    }
}
