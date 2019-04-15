using FilmlerKatmanli.BLL;
using FilmlerKatmanli.BLL.Repositories;
using FilmlerKatmanli.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmlerKatmanli.WinUI
{
    public partial class Form1 : Form
    {
        #region Global Instances
        FilmlerRepository fr = new FilmlerRepository();
        OyuncularRepository or = new OyuncularRepository();
        YonetmenlerRepository yr = new YonetmenlerRepository();
        Filmler guncellenecekFilm;
        Oyuncular guncellenecekOyuncu;
        Yonetmenler guncellenecekYonetmen;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region Genel Islemler
        private void Form1_Load(object sender, EventArgs e)
        {
            FilmleriDoldur();
            ComboboxiDoldur();
        }
        private void lnkYonetmenEkle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = tbYonetmenler;
            txtYonetmenAdi.Focus();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    FilmleriDoldur();
                    ComboboxiDoldur();
                    break;
                case 1:
                    YonetmenleriDoldur();
                    break;
                case 2:
                    OyunculariDoldur();
                    break;
            }
        }


        #endregion

        #region Metotlar
        private void ComboboxiDoldur()
        {
            cmbYonetmenler.DataSource = yr.SelectAll();
            cmbYonetmenler.DisplayMember = "AdSoyad";
            cmbYonetmenler.ValueMember = "YonetmenId";
        }

        private void FilmleriDoldur()
        {
            dgvFilmler.DataSource = fr.SelectAll();
        }
        private void OyunculariDoldur()
        {
            dgvOyuncular.DataSource = or.SelectAll();
        }

        private void YonetmenleriDoldur()
        {
            dgvYonetmenler.DataSource = yr.SelectAll();
        }
        #endregion

        #region Film İslemleri
        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilmAdi.Text))
            {
                MessageBox.Show("Film adı boş geçilemez.");
                return;
            }

            fr.Insert(new Filmler
            {
                FilmAdi = txtFilmAdi.Text,
                YayinTarihi = dtYayinTarihi.Value,
                Yonetmenler = cmbYonetmenler.SelectedItem as Yonetmenler
            });
            FilmleriDoldur();
            Tools.Temizle(tbFilmler.Controls);

        }

        private void dgvFilmler_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFilmler.SelectedRows.Count > 0)
            {
                guncellenecekFilm = fr.SelectById(Convert.ToInt32(dgvFilmler.SelectedRows[0].Cells[0].Value));
                txtFilmAdi.Text = guncellenecekFilm.FilmAdi;
                dtYayinTarihi.Value = Convert.ToDateTime(guncellenecekFilm.YayinTarihi);
                cmbYonetmenler.SelectedValue = guncellenecekFilm.YonetmenId;
            }
        }

        private void btnFilmGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilmAdi.Text))
            {
                MessageBox.Show("Film adı boş geçilemez.");
                return;
            }
            guncellenecekFilm.FilmAdi = txtFilmAdi.Text;
            guncellenecekFilm.YayinTarihi = dtYayinTarihi.Value;
            guncellenecekFilm.Yonetmenler = cmbYonetmenler.SelectedItem as Yonetmenler;
            fr.Update(guncellenecekFilm);
            FilmleriDoldur();
            Tools.Temizle(tbFilmler.Controls);
        }

        private void btnFilmSil_Click(object sender, EventArgs e)
        {
            if (dgvFilmler.SelectedRows.Count > 0)
            {
                fr.Delete(Convert.ToInt32(dgvFilmler.SelectedRows[0].Cells[0].Value));
                FilmleriDoldur();
                Tools.Temizle(tbFilmler.Controls);
            }
        }

        #endregion

        #region Yonetmen Islemleri
        private void btnYonetmenEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtYonetmenAdi.Text))
            {
                MessageBox.Show("Yonetmen adı boş geçilemez.");
                return;
            }

            yr.Insert(new Yonetmenler
            {
                YonetmenAdi = txtYonetmenAdi.Text,
                YonetmenSoyadi = txtYonetmenSoyadi.Text
            });
            YonetmenleriDoldur();
            Tools.Temizle(tbYonetmenler.Controls);
        }

        private void dgvYonetmenler_DoubleClick(object sender, EventArgs e)
        {
            if (dgvYonetmenler.SelectedRows.Count > 0)
            {
                guncellenecekYonetmen = yr.SelectById(Convert.ToInt32(dgvYonetmenler.SelectedRows[0].Cells[0].Value));
                txtYonetmenSoyadi.Text = guncellenecekYonetmen.YonetmenSoyadi;
                txtYonetmenAdi.Text = guncellenecekYonetmen.YonetmenAdi;
            }
        }

        private void btnYonetmenGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtYonetmenAdi.Text))
            {
                MessageBox.Show("Yonetmen adı boş geçilemez.");
                return;
            }
            guncellenecekYonetmen.YonetmenAdi = txtYonetmenAdi.Text;
            guncellenecekYonetmen.YonetmenSoyadi = txtYonetmenSoyadi.Text;
            yr.Update(guncellenecekYonetmen);
            YonetmenleriDoldur();
            Tools.Temizle(tbYonetmenler.Controls);
        }

        private void btnYonetmenSil_Click(object sender, EventArgs e)
        {
            if (dgvYonetmenler.SelectedRows.Count > 0)
            {
                yr.Delete(Convert.ToInt32(dgvYonetmenler.SelectedRows[0].Cells[0].Value));
                YonetmenleriDoldur();
                Tools.Temizle(tbYonetmenler.Controls);
            }
        }
        #endregion

        #region Oyuncu Islemleri
        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOyuncuAdi.Text))
            {
                MessageBox.Show("Oyuncu adı boş geçilemez.");
                return;
            }

            or.Insert(new Oyuncular
            {
                OyuncuAdi = txtOyuncuAdi.Text,
                OyuncuSoyadi = txtOyuncuSoyadi.Text
            });
            OyunculariDoldur();
            Tools.Temizle(tbOyuncular.Controls);
        }

        private void dgvOyuncular_DoubleClick(object sender, EventArgs e)
        {
            if (dgvOyuncular.SelectedRows.Count > 0)
            {
                guncellenecekOyuncu = or.SelectById(Convert.ToInt32(dgvOyuncular.SelectedRows[0].Cells[0].Value));
                txtOyuncuAdi.Text = guncellenecekOyuncu.OyuncuAdi;
                txtOyuncuSoyadi.Text = guncellenecekOyuncu.OyuncuSoyadi;
            }
        }

        private void btnOyuncuGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOyuncuAdi.Text))
            {
                MessageBox.Show("Oyuncu adı boş geçilemez.");
                return;
            }
            guncellenecekOyuncu.OyuncuAdi = txtOyuncuAdi.Text;
            guncellenecekOyuncu.OyuncuSoyadi = txtOyuncuSoyadi.Text;
            or.Update(guncellenecekOyuncu);
            OyunculariDoldur();
            Tools.Temizle(tbOyuncular.Controls);
        }

        private void btnOyuncuSil_Click(object sender, EventArgs e)
        {
            if (dgvOyuncular.SelectedRows.Count > 0)
            {
                or.Delete(Convert.ToInt32(dgvOyuncular.SelectedRows[0].Cells[0].Value));
                OyunculariDoldur();
                Tools.Temizle(tbOyuncular.Controls);
            }

        } 
        #endregion
    }
}
