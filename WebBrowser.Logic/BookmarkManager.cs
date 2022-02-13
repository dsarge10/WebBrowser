﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.Database1DataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        public static void AddItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.Id, item.Title, item.URL);
        }

        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();
            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.Title = row.Title;
                item.URL = row.URL;

                results.Add(item);
            }
            return results;
        }
    }
}
