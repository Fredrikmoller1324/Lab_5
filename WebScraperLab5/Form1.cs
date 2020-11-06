using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScraperLab5
{
    public partial class Form1 : Form
    {
        private List<string> urlStrings = new List<string>();
        private HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }
        private void ExtractUrls()
        {
            button_SaveImages.Enabled = true;
            urlStrings.Clear();
            listBox_AllLoadedImages.Items.Clear();

            if(textBox_URLInsertion.Text == string.Empty)
            {
                MessageBox.Show("enter a webadress", "invalid Input");
                return;
            }

            if (!textBox_URLInsertion.Text.Contains("http://"))
            {
                textBox_URLInsertion.Text = $"http://{textBox_URLInsertion.Text}";
            }

            Task<string> website = client.GetStringAsync(textBox_URLInsertion.Text);

            string regEx = @"(?<=src="").*(?="" )";

            MatchCollection matchCollection = Regex.Matches(website.Result, regEx);

            foreach (Match img in matchCollection)
            {
                if (img.ToString().Contains(".png") || img.ToString().Contains(".jpeg") || img.ToString().Contains(".jpg") ||
                    img.ToString().Contains(".bmp") || img.ToString().Contains(".gif"))
                {
                    if (img.ToString().StartsWith("http://www.gp.se"))
                    {
                        urlStrings.Add(img.ToString());
                    }
                    if (!img.ToString().StartsWith("https"))
                    {
                        string newUrl = $"http://www.gp.se{img}";
                        urlStrings.Add(newUrl);
                    }
                }
            }
            foreach (string url in urlStrings)
            {
                listBox_AllLoadedImages.Items.Add(url);
            }

            label_ImgCounter.Visible = true;
            label_ImgCounter.Text = $"Number of images: {listBox_AllLoadedImages.Items.Count}";
        }

        private void button_ExtractWeb_Click(object sender, EventArgs e)
        {
            ExtractUrls();
        }

        private void textBox_URLInsertion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { ExtractUrls(); e.SuppressKeyPress = true; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_ImgCounter.Visible = false;
            button_SaveImages.Enabled = false;
        }
        private async void button_SaveImages_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int numPic = 0;

                    List<Task<byte[]>> downloadPic = new List<Task<byte[]>>();
                    foreach (var url in urlStrings)
                    {
                        downloadPic.Add(client.GetByteArrayAsync(url));
                    }

                    while (downloadPic.Count > 0)
                    {
                        int bar = 0;

                        foreach (var url in listBox_AllLoadedImages.Items)
                        {
                            Task<byte[]> completedTask = await Task.WhenAny(downloadPic);

                            numPic++;

                            if (url.ToString().Contains(".jpg") || url.ToString().Contains(".jpeg"))
                            {
                                FileStream fsjpg = new FileStream($@"{dialog.SelectedPath}\image{numPic}.jpg", FileMode.Create);
                                await fsjpg.WriteAsync(completedTask.Result, 0, completedTask.Result.Length);
                            }
                            if (url.ToString().Contains(".bmp"))
                            {
                                FileStream fsbmp = new FileStream($@"{dialog.SelectedPath}\image{numPic}.bmp", FileMode.Create);
                                await fsbmp.WriteAsync(completedTask.Result, 0, completedTask.Result.Length);
                            }
                            if (url.ToString().Contains(".png"))
                            {
                                FileStream fspng = new FileStream($@"{dialog.SelectedPath}\image{numPic}.png", FileMode.Create);
                                await fspng.WriteAsync(completedTask.Result, 0, completedTask.Result.Length);
                            }
                            if (url.ToString().Contains(".gif"))
                            {
                                FileStream fsgif = new FileStream($@"{dialog.SelectedPath}\image{numPic}.gif", FileMode.Create);
                                await fsgif.WriteAsync(completedTask.Result, 0, completedTask.Result.Length);
                            }

                            downloadPic.Remove(completedTask);
                            progressBar1.Maximum = listBox_AllLoadedImages.Items.Count;
                            bar++;
                            progressBar1.Value = bar;
                        }
                    }
                    MessageBox.Show($"{listBox_AllLoadedImages.Items.Count} images downloaded", "Download Complete");
                    progressBar1.Value = 0;
                    listBox_AllLoadedImages.Items.Clear();
                    label_ImgCounter.Visible = false;
                    label_ImgCounter.Text = $"Number of images: {listBox_AllLoadedImages.Items.Count}";
                }
            }
        }
    }
}
