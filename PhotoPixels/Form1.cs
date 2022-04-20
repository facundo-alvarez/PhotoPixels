namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Image i;


        public Form1()
        {
            InitializeComponent();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            photoViewer.Image = bitmap;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string fileName = Path.GetFileNameWithoutExtension(path);
                    i = Image.FromFile(path);
                    bitmap = (Bitmap)i;
                    photoViewer.Image = bitmap;

                    GetMetadata(fileName);
                    GetPixels();
                }
            }
        }

        private void GetMetadata(string name)
        {
            widthData.Text = bitmap.Width.ToString();
            heightData.Text = bitmap.Height.ToString();
            nameData.Text = name;
        }

        private void GetPixels()
        {
            uint red = 0, orange = 0, yellow = 0, lightGreen = 0, green = 0, turquoise = 0, cyan = 0, lightBlue = 0, blue = 0, violet = 0, magenta = 0, raspberry = 0, grey = 0, black = 0, white = 0;
            uint totalPixels = (uint)(bitmap.Width * bitmap.Height);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for(int j = 0; j < bitmap.Height; j++)
                {
                    Color c = bitmap.GetPixel(i, j);

                    var hue = c.GetHue();
                    var sat = c.GetSaturation();
                    var lum = c.GetBrightness();
                    
                    if (lum <= 0.05) black++;
                    else if (lum >= 0.95 || (lum >= 0.85 && sat <= 0.10)) white++;
                    else
                    {
                        if(sat <= 0.05) grey++;
                        else
                        {
                            if (hue >= 0 && hue < 10) red++;
                            if (hue >= 10 && hue < 35) orange++;
                            if (hue >= 35 && hue < 45) yellow++;
                            if (hue >= 45 && hue < 70) lightGreen++;
                            if (hue >= 70 && hue < 95) green++;
                            if (hue >= 95 && hue < 145) turquoise++;
                            if (hue >= 145 && hue < 170) cyan++;
                            if (hue >= 170 && hue < 190) lightBlue++;
                            if (hue >= 190 && hue < 250) blue++;
                            if (hue >= 250 && hue < 280) violet++;
                            if (hue >= 280 && hue < 300) magenta++;
                            if (hue >= 300 && hue < 330) raspberry++;
                            if (hue >= 330 && hue < 361) red++;
                        }
                    }
                }
            }

            redData.Text = PixelPercentage(red,totalPixels).ToString("0.00") + "%";
            orangeData.Text = PixelPercentage(orange,totalPixels).ToString("0.00") + "%";
            yellowData.Text = PixelPercentage(yellow, totalPixels).ToString("0.00") + "%";
            lgreenData.Text = PixelPercentage(lightGreen, totalPixels).ToString("0.00") + "%";
            greenData.Text = PixelPercentage(green, totalPixels).ToString("0.00") + "%";
            turquoiseData.Text = PixelPercentage(turquoise, totalPixels).ToString("0.00") + "%";
            cyanData.Text = PixelPercentage(cyan, totalPixels).ToString("0.00") + "%";
            lblueData.Text = PixelPercentage(lightBlue, totalPixels).ToString("0.00") + "%";
            blueData.Text= PixelPercentage(blue, totalPixels).ToString("0.00") + "%";
            violetData.Text = PixelPercentage(violet, totalPixels).ToString("0.00") + "%";
            magentaData.Text = PixelPercentage(magenta, totalPixels).ToString("0.00") + "%";
            raspberryData.Text = PixelPercentage(raspberry, totalPixels).ToString("0.00") + "%";
            blackData.Text = PixelPercentage(black, totalPixels).ToString("0.00") + "%";
            whiteData.Text = PixelPercentage(white, totalPixels).ToString("0.00") + "%";
            greyData.Text = PixelPercentage(grey, totalPixels).ToString("0.00") + "%";


            decimal PixelPercentage(uint color, uint pixels)
            {
                decimal p = (color / (decimal)pixels)*100;
                return p;
            }
        }
    }
}