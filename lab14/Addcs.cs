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
    public partial class Addcs : Form
    {
        public Addcs()
        {
            InitializeComponent();
        }

        private Concert inst = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidatingCheck() != true)
            {
                return;
            }
            if (radioButtonConcert.Checked)
            {
                var data = Convert.ToDateTime(dateTimePicker1.Value.Date + dateTimePicker1.Value.TimeOfDay);
                inst = new Concert(textBox1.Text, data, textBox3.Text, Convert.ToInt32(textBox4.Text));
                DialogResult = DialogResult.OK;
            }
            else if (radioButtonFestival.Checked)
            {
                var data = Convert.ToDateTime(dateTimePicker1.Value.Date + dateTimePicker1.Value.TimeOfDay);
                inst = new Festival(textBox1.Text, data, textBox3.Text, Convert.ToInt32(textBox4.Text));
                MessageBox.Show(inst.ToString());
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Слект нужно таво то");
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(monthCalendar1.Visible == true)
            {
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;
            }
            var data = Convert.ToDateTime(dateTimePicker1.Value.Date);
            MessageBox.Show(data.ToString());
        }
        public Concert ReturnObj()
        {
            return inst;
        }
        private bool ValidatingCheck()
        {
            int coutvlid = 0;

            errorPerformer.SetError(this.textBox1, "");
            errorDate.SetError(this.textBox2, "");
            errorVenue.SetError(this.textBox3, "");
            errorNumberOfSeats.SetError(this.textBox4, "");

            if (textBox1.Text.Trim(new Char[] { ' ', '*', ',', '.', '[', ']' }) == string.Empty)
            {
                errorPerformer.SetError(this.textBox1, "Поле не може буди пустим");
            }
            else
            {
                coutvlid++;
            }
            if (!DateTime.TryParse((dateTimePicker1.Value.Date + dateTimePicker1.Value.TimeOfDay).ToString(), out _))
            {
                errorDate.SetError(this.textBox2, "Невірний фориат дати");
            }
            else
            {
                coutvlid++;
            }
            if(textBox3.Text.Trim(new Char[] { ' ', '*', ',', '.', '[', ']' }) == string.Empty)
            {
                errorVenue.SetError(this.textBox3, "Поле не може буди пустим");
            }
            else {
                coutvlid++;
            }
            if(!Int32.TryParse(textBox4.Text,out _))
            {
                errorPerformer.SetError(this.textBox4, "невірний фрмат числа");
            }
            else if(Int32.Parse(textBox4.Text) < 0)
            {
                errorNumberOfSeats.SetError(this.textBox4, "Повино буди додатне число");
            }
            else
            {
                coutvlid++;
            } // Сделать так в всех класах

            if(coutvlid == 4)
                return true;
            else 
                return false;
        }
    }
}
