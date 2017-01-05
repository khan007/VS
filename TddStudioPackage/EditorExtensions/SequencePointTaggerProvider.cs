﻿using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;
using R4nd0mApps.TddStud10.Hosts.VS.TddStudioPackage.Core.Editor;

namespace R4nd0mApps.TddStud10.Hosts.VS.EditorExtensions
{
    [Export(typeof(ITaggerProvider))]
    [ContentType("code")]
    [TagType(typeof(SequencePointTag))]
    public class SequencePointTaggerProvider : ITaggerProvider
    {
        public ITagger<T> CreateTagger<T>(ITextBuffer buffer) where T : ITag
        {
            return new SequencePointTagger(
                buffer,
                TddStud10Package.DataStore,
                TddStud10Package.DataStoreEvents) as ITagger<T>;
        }
    }
}
