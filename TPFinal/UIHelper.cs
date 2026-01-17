using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    public static class UIHelper
    {
        public const int MAXLENGTHNUMERO = 10;
        public const int MAXLENGTHIMPORTE = 10;

        public static void setDefaultStyleForm(Control parent)
        {
            parent.BackColor = Color.WhiteSmoke;
            setButtonStyles(parent);
            setTextBoxStyles(parent);
            setComboBoxStyles(parent);
        }

        public static void setButtonStyles(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is System.Windows.Forms.Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.FromArgb(180, 220, 250);
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(120, 180, 220);
                    btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

                    //cambio de colores y asignacion de eventos al acercar y alejar el mouse
                    btn.MouseEnter += (s, e) =>
                    {
                        btn.BackColor = Color.FromArgb(100, 180, 240);
                    };
                    btn.MouseLeave += (s, e) =>
                    {
                        btn.BackColor = Color.FromArgb(180, 220, 250);
                    };
                }

                if (c.HasChildren)
                {
                    setButtonStyles(c);
                }
            }
        }
        public static void setTextBoxStyles(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.BackColor = Color.White;
                    txt.ForeColor = Color.Black;
                    txt.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                    txt.Margin = new Padding(3);

                    //Eventos para que cambie de color con el focus
                    txt.Enter += (s, e) =>
                    {
                        txt.BackColor = Color.AliceBlue;
                    };

                    txt.Leave += (s, e) =>
                    {
                        txt.BackColor = Color.White;
                    };
                }

                if (c.HasChildren)
                {
                    setTextBoxStyles(c);
                }
            }
        }

        public static void setComboBoxStyles(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is ComboBox combo)
                {
                    combo.DropDownStyle = ComboBoxStyle.DropDownList;
                    combo.FlatStyle = FlatStyle.Flat;
                    combo.BackColor = Color.White;
                    combo.ForeColor = Color.Black;
                    combo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

                    //Eventos para que cambie de color con el focus
                    combo.Enter += (s, e) =>
                    {
                        combo.BackColor = Color.AliceBlue;
                    };

                    combo.Leave += (s, e) =>
                    {
                        combo.BackColor = Color.White;
                    };
                }

                if (c.HasChildren)
                {
                    setComboBoxStyles(c);
                }
            }
        }

        public static void setDatagridDefault(DataGridView dataGrid)
        {
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersVisible = false;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        internal static void setHoraPickerDefault(DateTimePicker agregarInicioTurno)
        {
            agregarInicioTurno.Format = DateTimePickerFormat.Time;
            agregarInicioTurno.ShowUpDown = true;
        }

        internal static void setTextBoxNumeroConDecimal(TextBox textBox, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        internal static void setTextBoxNumeroSinDecimal(TextBox textBox, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
