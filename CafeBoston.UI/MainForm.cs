using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeBoston.DATA;

namespace CafeBoston.UI
{
    public partial class MainForm : Form
    {
        CafeData db = new CafeData();

        public MainForm()
        {
            InitializeComponent();
            LoadTables();
        }

        private void LoadTables()
        {
            for (int i = 1; i <= db.TableCount; i++)
            {
                var lvi = new ListViewItem($"Table {i}");
                lvi.ImageKey = "empty";
                lvwTables.Items.Add(lvi);
            }
        }
    }
}
