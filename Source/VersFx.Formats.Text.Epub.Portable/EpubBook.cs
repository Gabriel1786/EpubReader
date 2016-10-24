﻿using System.Collections.Generic;
using VersFx.Formats.Text.Epub.Entities;

namespace VersFx.Formats.Text.Epub
{
    public class EpubBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public List<string> AuthorList { get; set; }
        public EpubSchema Schema { get; set; }
        public EpubContent Content { get; set; }
        public EpubContentFile CoverImage { get; set; }
        public List<EpubChapter> Chapters { get; set; }
    }
}
