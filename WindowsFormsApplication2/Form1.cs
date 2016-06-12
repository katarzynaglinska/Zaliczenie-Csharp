using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private decimal suma = 0;

        private Sklep sklep = new Sklep();
        BindingSource produktyBinding = new BindingSource();

        private List<Produkt> listaProduktow = new List<Produkt>();
        BindingSource listaBinding = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            setupData();

            produktyBinding.DataSource = sklep.Produkty.Where(x => x.Sprzedane == false).ToList();
            produktyListbox.DataSource = produktyBinding;

            produktyListbox.DisplayMember = "Pokaz";
            produktyListbox.ValueMember = "Pokaz";

            listaBinding.DataSource = listaProduktow;
            koszykListbox.DataSource = listaBinding;


            koszykListbox.DisplayMember = "Pokaz";
            koszykListbox.ValueMember = "Pokaz";
        }

        private void setupData()
        {

            Osoba wlasciciel = new Osoba();
            wlasciciel.Imie = "Katarzyna";
            wlasciciel.Nazwisko = "Glinska";
            sklep.Wlasciciel = wlasciciel;
            

            sklep.Produkty.Add(new Produkt { Tytul = "czekolada mleczna", Opis = "mleczna z orzechami", Cena = 3.50M  });
            sklep.Produkty.Add(new Produkt { Tytul = "lizak", Opis = "o smaku coli", Cena = 0.50M });
            sklep.Produkty.Add(new Produkt { Tytul = "ciastka", Opis = "z rodzynkami", Cena = 2.00M });
            sklep.Produkty.Add(new Produkt { Tytul = "żelki słodkie", Opis = "o smaku śmietankowym", Cena = 4.00M });
            sklep.Produkty.Add(new Produkt { Tytul = "żelki kwaśne", Opis = "o smaku jabłkowym", Cena = 4.00M });
            sklep.Produkty.Add(new Produkt { Tytul = "czekolada gorzka", Opis = "70% kakao", Cena = 6.50M });
            sklep.Produkty.Add(new Produkt { Tytul = "cukierki karmelowe", Opis = "ręcznie robione", Cena = 5.50M });
            sklep.Produkty.Add(new Produkt { Tytul = "cukierki czekoladowe", Opis = "ręcznie robione", Cena = 5.50M });
            sklep.Produkty.Add(new Produkt { Tytul = "cukierki migdałowe", Opis = "ręcznie robione", Cena = 7.50M });
            sklep.Produkty.Add(new Produkt { Tytul = "muffinka", Opis = "z kawałkami owoców", Cena = 1.50M });
            sklep.Produkty.Add(new Produkt { Tytul = "czekolada do picia", Opis = "instant", Cena = 0.50M });
        }




        private void button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtzalacznik.Text = openFileDialog1.FileName.ToString();
            }
            
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            
                try
                {

                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    MailMessage message = new MailMessage();


                    message.From = new MailAddress(txtTwojmail.Text);
                    message.To.Add(txtodbiorca.Text);
                    message.Body = txttresc.Text;
                    message.Subject = txttemat.Text;
                    client.UseDefaultCredentials = false;
                    client.EnableSsl = true;
                    if (txtzalacznik.Text != null)
                    {
                        message.Attachments.Add(new Attachment(txtzalacznik.Text));
                    }

                    client.Credentials = new System.Net.NetworkCredential(txtTwojmail.Text, txthaslo.Text);
                    Cursor.Current = Cursors.WaitCursor;
                    client.Send(message);
                    MessageBox.Show("Email został wysłany");
                    Cursor.Current = Cursors.Default;
                    message = null;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


}



        private void purchaseitem_Click(object sender, EventArgs e)
        {
            Produkt wybranyProdukt = (Produkt)produktyListbox.SelectedItem;

            listaProduktow.Add(wybranyProdukt);
            listaBinding.ResetBindings(false);
        }

        private void podlicz_Click(object sender, EventArgs e)
        {
            foreach(Produkt produkt in listaProduktow)
            {
                produkt.Sprzedane = true;
               // suma += produkt.Cena;
                
            }
           listaProduktow.Clear();

            produktyBinding.DataSource = sklep.Produkty.Where(x => x.Sprzedane == false).ToList();

            
            listaBinding.ResetBindings(false);
            produktyBinding.ResetBindings(false);

            suma = 0;
            labelsuma.Text = string.Format("${0}", suma);
            MessageBox.Show("Produkty zostały kupione");

        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Produkt produkt in listaProduktow)
            {
               
                suma += produkt.Cena;

            }
            labelsuma.Text = string.Format("${0}", suma);
        }
    }
}
