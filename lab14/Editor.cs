using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab14
{
    public partial class Editor : Form
    {
        private DB db = null;
        private int id = 0;
        public Editor(int id, DB dB)
        {
            InitializeComponent();
            this.db = dB;   
            this.id = id;
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            Concert currentobj =  db.GetList().Where(x => x.id == id).FirstOrDefault();
            textBoxId.Text = id.ToString();
            if(currentobj.name == "Концерт")
            {
                radioButtonConcert.Checked = true;
            }
            else
            {
                radioButtonFestival.Checked = true;
            }
            textBoxPerformer.Text = currentobj.performer.ToString();
            textBoxNumSeats.Text = currentobj.number_of_seats.ToString();
            textBoxVenue.Text = currentobj.venue.ToString();
            textBoxData.Text = currentobj.data.ToString();
            dateTimePicker1.Text = currentobj.data.ToString();
            //Доделать form1 поиск по дате и доделать валидацию доробити зміну типу фестеваль и концерт
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidatingCheck() != true)
            {
                return;
            }
            if (radioButtonConcert.Checked)
            {
                Concert newobj = new Concert(textBoxPerformer.Text, Convert.ToDateTime(textBoxData.Text), textBoxVenue.Text,Convert.ToInt32(textBoxNumSeats.Text));
                db.Edit(newobj,id);
                DialogResult = DialogResult.OK;
            }
            else
            {
                Festival newobj = new Festival(textBoxPerformer.Text, Convert.ToDateTime(textBoxData.Text), textBoxVenue.Text, Convert.ToInt32(textBoxNumSeats.Text));
                db.Edit(newobj,id);
                DialogResult= DialogResult.OK;
            }
        }
        private bool ValidatingCheck()
        {
            int coutvlid = 0;
            errorPerformer.SetError(this.textBoxPerformer, "");
            errorData.SetError(this.textBoxData, "");
            errorVenue.SetError(this.textBoxVenue, "");
            errorNumSeats.SetError(this.textBoxNumSeats, "");
            if (textBoxPerformer.Text.Trim(new Char[] { ' ', '*', ',', '.', '[', ']' }) == string.Empty)
            {
                errorPerformer.SetError(this.textBoxPerformer, "Поле не може буди пустим");
            }
            else
            {
                coutvlid++;
            }
            if (!DateTime.TryParse(textBoxData.Text, out _))
            {
                errorData.SetError(this.textBoxData, "Невірний фориат дати");
            }
            else
            {
                coutvlid++;
            }
            if (textBoxVenue.Text.Trim(new Char[] { ' ', '*', ',', '.', '[', ']' }) == string.Empty)
            {
                errorVenue.SetError(this.textBoxVenue, "Поле не може буди пустим");
            }
            else
            {
                coutvlid++;
            }
            if (!Int32.TryParse(textBoxNumSeats.Text, out _))
            {
                errorNumSeats.SetError(this.textBoxNumSeats, "невірний фрмат числа");
            }
            else if (Int32.Parse(textBoxNumSeats.Text) < 0)
            {
                errorNumSeats.SetError(this.textBoxNumSeats, "Повино буди додатне число");
            }
            else
            {
                coutvlid++;
            } // Сделать так в всех класах

            if (coutvlid == 4)
                return true;
            else
                return false;
        }

        private void dateTimePicker1_BindingContextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Text.ToString());
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            //когда фокус капут
        }

        private void dateTimePicker1_MarginChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Text.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBoxData.Text = dateTimePicker1.Value.ToString();
        }
    }
}
