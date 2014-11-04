using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BulkReplace
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            replacementList.Items[0].Selected = true;
            replacementList.DoubleClick += replacementList_DoubleClick;

            directoryText.Focus();
            directoryBrowseButton.Focus();
        }

        void replacementList_DoubleClick(object sender, EventArgs e)
        {
            replacementList_SelectedIndexChanged(sender, e);
            replaceText.Focus();
        }

        private void replacementList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (replacementList.SelectedItems.Count == 0)
            {
                replaceText.Text = string.Empty;
                withText.Text = string.Empty;
                return;
            }

            var item = replacementList.SelectedItems[0];
            var subItem = item.SubItems[1];
            replaceText.Text = item.Text;
            withText.Text = subItem.Text;
        }

        private void replaceText_TextChanged(object sender, EventArgs e)
        {
            if (replacementList.SelectedItems.Count == 0)
            {
                if (replaceText.Text == string.Empty)
                {
                    return;
                }
                var item1 = GetEmptyItem();
                item1.Text = replaceText.Text;
                item1.Selected = true;
                AddEmptyItem();
                return;
            }

            var item = replacementList.SelectedItems[0];
            var subItem = item.SubItems[1];

            if (item.Text.Equals(string.Empty) && subItem.Text.Equals(string.Empty))
            {
                // Item was started, add another empty item
                AddEmptyItem();
            }
            else
            {
                if (replaceText.Text.Equals(string.Empty) && subItem.Text.Equals(string.Empty))
                {
                    replacementList.Items.Remove(item);
                    replacementList.Items[replacementList.Items.Count - 1].Selected = true;
                }
            }

            item.Text = replaceText.Text;
        }

        private void withText_TextChanged(object sender, EventArgs e)
        {
            if (replacementList.SelectedItems.Count == 0)
            {
                if (withText.Text == string.Empty)
                {
                    return;
                }
                var item1 = GetEmptyItem();
                var subItem1 = item1.SubItems[1];
                subItem1.Text = withText.Text;
                item1.Selected = true;
                AddEmptyItem();
                return;
            }

            var item = replacementList.SelectedItems[0];
            var subItem = item.SubItems[1];

            if (item.Text.Equals(string.Empty) && subItem.Text.Equals(string.Empty))
            {
                // Item was started, add another empty item
                AddEmptyItem();
            }
            else
            {
                if (item.Text.Equals(string.Empty) && withText.Text.Equals(string.Empty))
                {
                    replacementList.Items.Remove(item);
                    replacementList.Items[replacementList.Items.Count - 1].Selected = true;
                }
            }

            subItem.Text = withText.Text;
        }

        private ListViewItem AddEmptyItem()
        {
            var item = replacementList.Items.Add("");
            item.SubItems.Add("");
            return item;
        }

        private ListViewItem GetEmptyItem()
        {
            if (replacementList.Items.Count == 0)
            {
                return AddEmptyItem();
            }

            var item = replacementList.Items[replacementList.Items.Count - 1];
            var subItem = item.SubItems[1];

            if (item.Text.Equals(string.Empty) && subItem.Text.Equals(string.Empty))
            {
                return item;
            }

            return AddEmptyItem();
        }

        private void directoryBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = directoryText.Text;
            dialog.ShowDialog();
            directoryText.Text = dialog.SelectedPath;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            // Go to the empty item
            var emptyItem = GetEmptyItem();
            foreach (ListViewItem i in replacementList.SelectedItems)
            {
                i.Selected = false;
            }
            emptyItem.Selected = true;
            replaceText.Focus();
        }

        private string ReadNLines(StreamReader file, int n)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < n; i++)
                str.Append(file.ReadLine());
            return str.ToString();
        }

        private void loadConfButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text file|*.txt";
            dialog.Title = "Save configuration";
            if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            replacementList.Items.Clear();
            using (Stream file = dialog.OpenFile())
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    ListViewItem item = null;
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
                        if (line.Length == 0)
                        {
                            continue;
                        }
                        switch (line[0])
                        {
                            case "replace":
                                var itemText = ReadNLines(reader, int.Parse(line[1]));
                                item = replacementList.Items.Add(itemText);
                                item.SubItems.Add("");
                                break;
                            case "with":
                                if (item == null)
                                    continue;
                                var subItemText = ReadNLines(reader, int.Parse(line[1]));
                                item.SubItems[1].Text = subItemText;
                                item = null;
                                break;
                            case "directory":
                                directoryText.Text = reader.ReadLine();
                                break;
                            case "filter":
                                filterText.Text = reader.ReadLine();
                                break;
                        }
                    }
                }
                GetEmptyItem();
                replacementList.Items[0].Selected = true;
            }
        }

        private void saveConfButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text file|*.txt";
            dialog.Title = "Save configuration";
            if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            using (Stream file = dialog.OpenFile())
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine("directory 1");
                    writer.WriteLine(directoryText.Text);

                    writer.WriteLine("filter 1");
                    writer.WriteLine(filterText.Text);

                    foreach (ListViewItem item in replacementList.Items)
                    {
                        var subItem = item.SubItems[1];
                        var lines = item.Text.Count(x => x.Equals('\n')) + 1;
                        writer.WriteLine("replace " + lines.ToString());
                        writer.WriteLine(item.Text);
                        lines = subItem.Text.Count(x => x.Equals('\n')) + 1;
                        writer.WriteLine("with " + lines.ToString());
                        writer.WriteLine(subItem.Text);
                    }
                }
            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            List<ReplaceItem> items = new List<ReplaceItem>();
            foreach (ListViewItem viewItem in replacementList.Items)
            {
                if (string.IsNullOrEmpty(viewItem.Text))
                {
                    continue;
                }
                ReplaceItem item = new ReplaceItem(viewItem.Text, viewItem.SubItems[1].Text);
                items.Add(item);
            }
            Replacement replacement = new Replacement(directoryText.Text, filterText.Text, items);
            replacement.Do();
        }
    }
}
