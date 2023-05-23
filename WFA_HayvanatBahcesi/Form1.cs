using AltYapi.Enumlar;
using AltYapi.SoyutSiniflar;

namespace WFA_HayvanatBahcesi
{
    public partial class Form1 : Form
    {
        Hayvan h1 = new Hayvan();
        List<Hayvan> HayvanlarListesi = new List<Hayvan>();
        HayvanatBahcesi hayvanat = new HayvanatBahcesi();

        public Form1()
        {
           

            InitializeComponent();
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));


        }

        public void Listele()
        {
            lsthayvanlar.Items.AddRange(HayvanlarListesi.ToArray());
        }
        public void Guncelle()
        {

        }
        public void Sil()
        {
            int selected = lsthayvanlar.SelectedIndex;
            HayvanlarListesi.RemoveAt(selected);
            lsthayvanlar.Update();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            h1.Tur = txtCinsi.ToString();
            h1.Yas = int.Parse(txtYasi.Text);
            HayvanlarListesi.Add(h1);
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sil();
            Listele();
        }
    }
}