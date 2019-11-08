﻿using BrawlLib;
using BrawlLib.SSBB;
using BrawlLib.SSBB.ResourceNodes;

namespace BrawlCrate.NodeWrappers.BrawlEx
{
    [NodeWrapper(ResourceType.COSC)]
    internal class COSCWrapper : GenericWrapper
    {
        public override string ExportFilter => FileFilters.COSC;
    }
}