using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab14
{
    public partial class Form1 : Form
    {
        private bool save = false;
        DB db = new DB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "lab 14";
            //db.CreateTestData();
            Updated();
        }
        public void Updated()
        {
            listView1.Items.Clear();
            List<DateTime> listdays = new List<DateTime>();
            foreach (var db in db.GetList())
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {db.id.ToString(),db.name.ToString(),db.performer.ToString(),db.data.ToString(),db.venue,db.number_of_seats.ToString()});
                listView1.Items.Add(listViewItem);
                listdays.Add(db.data);
            }
            monthCalendar1.BoldedDates = listdays.ToArray();
        }
        public void Updated(string date)
        {
            listView1.Items.Clear();
            foreach (var db in db.GetList())
            {
                if (db.data.ToShortDateString() == date)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] { db.id.ToString(), db.name.ToString(), db.performer.ToString(), db.data.ToString(), db.venue, db.number_of_seats.ToString() });
                    listView1.Items.Add(listViewItem);
                    //Доробити валідацию 
                    
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Addcs fromadd = new Addcs();
            //fromadd.ShowDialog();
            if(fromadd.ShowDialog() == DialogResult.OK)
            {
                var inst = fromadd.ReturnObj();
                var fest = fromadd.ReturnObjf();

                if(inst == null)
                {
                    db.Add(fest);
                }
                else
                {
                    db.Add(inst);
                }
            }
            Updated();
            

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Sleceted obj");
                return;
            }
            if (listView1.Items.Count > 0)
            {
                int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
                db.Removed(id);
                Updated();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Sleceted obj");
                return;
            }
            Editor editor = new Editor(Convert.ToInt32(listView1.SelectedItems[0].Text),db);
            if(editor.ShowDialog() == DialogResult.OK)
            {
                Updated();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Updated();
        }

        private void buttonShowCalendar_Click(object sender, EventArgs e)
        {
            if(monthCalendar1.Visible == true)
            {
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Updated(monthCalendar1.SelectionStart.ToShortDateString());
        }

        private void завантаженняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.LoadDBJson();
            Updated();
        }

        private void збереженняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.SaveDBJson();
        }

        private void автозбереженняВиклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(save == false)
            {
                save = true;
                автозбереженняВиклToolStripMenuItem.Text = "Авто-збереженя вкл";
            }
            else
            {
                save = false;
                автозбереженняВиклToolStripMenuItem.Text = "Авто-збереженя викл";

            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if(save == true)
            {
                db.SaveDBJson();
            }
        }
    }
}
