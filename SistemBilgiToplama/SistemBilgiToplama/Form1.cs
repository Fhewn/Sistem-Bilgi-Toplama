using System;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;


namespace SistemBilgiToplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            GetTemelBilgiler();
            GetIslemciTuru();
            GetDepolamaAlani();
            GetOfficeSurumu();

            MessageBox.Show("Sistem bilgileri baþarýyla alýndý ve formda gösterildi.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      

        private void GetTemelBilgiler()
        {
            txtKullaniciAdi.Text = Environment.UserName;
            txtIsletimSistemi.Text = Environment.OSVersion.VersionString;
        }

        private void GetIslemciTuru()
        {
            try
            {
                ManagementObjectSearcher arayici = new ManagementObjectSearcher("select Name from Win32_Processor");
                foreach (ManagementObject islemci in arayici.Get())
                {
                    txtIslemciTuru.Text = islemci["Name"].ToString();
                    break;
                }
            }
            catch
            {
                txtIslemciTuru.Text = "Bilgi Alýnamadý (WMI Hatasý)";
            }
        }

        private void GetDepolamaAlani()
        {
            try
            {
                ManagementObjectSearcher arayici = new ManagementObjectSearcher("select FreeSpace, Size from Win32_LogicalDisk where DeviceID='C:'");
                foreach (ManagementObject disk in arayici.Get())
                {
                    long toplamBoyut = Convert.ToInt64(disk["Size"]);
                    long bosAlan = Convert.ToInt64(disk["FreeSpace"]);

                    double toplamBoyutGB = (double)toplamBoyut / Math.Pow(1024, 3);
                    double bosAlanGB = (double)bosAlan / Math.Pow(1024, 3);

                    string bilgi = $"Toplam: {toplamBoyutGB:F2} GB, Boþ: {bosAlanGB:F2} GB";
                    txtDepolamaAlani.Text = bilgi;
                    break;
                }
            }
            catch
            {
                txtDepolamaAlani.Text = "Bilgi Alýnamadý (WMI Hatasý)";
            }
        }

     
        private void GetOfficeSurumu()
        {
            string surum = "Kurulu Office Bulunamadý";
            try
            {
                string[] officeYollari = new string[]
                {
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
                    @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall" 
                };

                foreach (string yol in officeYollari)
                {
                    using (RegistryKey anahtar = Registry.LocalMachine.OpenSubKey(yol))
                    {
                        if (anahtar != null)
                        {
                            foreach (string altAnahtarAdi in anahtar.GetSubKeyNames())
                            {
                                using (RegistryKey altAnahtar = anahtar.OpenSubKey(altAnahtarAdi))
                                {
                                    object ad = altAnahtar.GetValue("DisplayName");
                                    if (ad != null && ad.ToString().Contains("Microsoft Office"))
                                    {
                                        surum = ad.ToString();
                                        txtOfficeSurum.Text = surum;
                                        return; 
                                    }
                                }
                            }
                        }
                    }
                }

                txtOfficeSurum.Text = surum;
            }
            catch
            {
                txtOfficeSurum.Text = "Bilgi Alýnamadý (Registry Hatasý)";
            }
        }
    }
}