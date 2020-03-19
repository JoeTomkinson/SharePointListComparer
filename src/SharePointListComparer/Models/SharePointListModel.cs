using System.Collections.Generic;

namespace SharePointListComparer.Models
{
    public class SharePointListStructure
    {
        public bool LocalList { get; set; }

        public string ListName { get; set; }

        public string ListPhysicalPath { get; set; }

        public int? ColumnCount { get => ColumnDefinitions?.Count; }

        public string FullXMLSchema { get; set; }

        public string ColumnDefinitionXML { get; set; }

        public List<ColumnDefinition> ColumnDefinitions { get; set; }

        public string ViewDefinitionXML { get; set; }

        public List<SharePointListView> ViewDefinitions { get; set; }
    }

    public class ColumnDefinition
    {
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string ColumnType { get; set; }
        public string Required { get; set; }
        public string StaticName { get; set; }
    }

    public class SharePointListView
    {
        public string ViewDisplayName { get; set; }

        public List<string> ViewFieldRefs { get; set; }
    }
}
