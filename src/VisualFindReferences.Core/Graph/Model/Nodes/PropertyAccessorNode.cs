﻿using System.Collections.Generic;
using System.Windows.Media;

namespace VisualFindReferences.Core.Graph.Model.Nodes
{
    public class PropertyAccessorNode : VFRNode
    {
        static readonly Geometry DefaultIcon = Geometry.Parse("M22.7,19L13.6,9.9C14.5,7.6 14,4.9 12.1,3C10.1,1 7.1,0.6 4.7,1.7L9,6L6,9L1.6,4.7C0.4,7.1 0.9,10.1 2.9,12.1C4.8,14 7.5,14.5 9.8,13.6L18.9,22.7C19.3,23.1 19.9,23.1 20.3,22.7L22.6,20.4C23.1,20 23.1,19.3 22.7,19Z");

        public PropertyAccessorNode(NodeGraph flowChart, FoundReferences foundReferences) : base(flowChart, foundReferences, DefaultIcon, Brushes.Gray)
        { }

        public override string NodeSymbolType => "Property Accessor";

        public override IEnumerable<SearchableSymbol> GetSearchableSymbols()
        {
            yield return new SearchableSymbol(NodeFoundReferences, new[] { NodeFoundReferences.Symbol }, NodeFoundReferences.Solution, "property accessor " + ContainerName);
        }
    }
}