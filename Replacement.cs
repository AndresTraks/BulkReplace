using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BulkReplace
{
    class ReplaceItem
    {
        public string Replace { get; set; }
        public string With { get; set; }

        public ReplaceItem(string replace, string with)
        {
            Replace = replace;
            With = with;
        }
    }

    class Replacement
    {
        bool recursive = true;
        string _directory;
        string _filter;
        ReplaceItem[] _items;

        public Replacement(string directory, string filter, IEnumerable<ReplaceItem> items)
        {
            _directory = directory;
            _filter = filter;
            _items = items.ToArray();
        }

        public void ParseFile(string filename)
        {
            string contents;
            using (var reader = new StreamReader(filename))
            {
                contents = reader.ReadToEnd();
            }
            
            foreach (var item in _items)
            {
                contents = contents.Replace(item.Replace, item.With);
            }

            using (var writer = new StreamWriter(filename))
            {
                writer.Write(contents);
                writer.Flush();
            }
        }

        public void Do()
        {
            SearchOption option = recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            IEnumerable<string> files = Directory.EnumerateFiles(_directory, _filter, option);
            foreach (string file in files){
                ParseFile(file);
            }
            MessageBox.Show("Done!");
        }
    }
}
